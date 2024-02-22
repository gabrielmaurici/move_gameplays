using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Interfaces.Observer;
using MoveGameplays.Domain.Models;
using MoveGameplays.Infraestruct;

namespace MoveGameplays.Wfp
{
    public partial class OptionsAndMoveFilesForm : Form, IObserverContract<ProgressGameplayDto>
    {
        private readonly MoveGameplaysConfigModel _configs;
        private readonly string _diskDrive;

        public OptionsAndMoveFilesForm(string diskDrive, MoveGameplaysConfigModel configs)
        {
            InitializeComponent();
            _configs = configs;
            _diskDrive = diskDrive;
        }

        private void OptionsAndMoveFilesForm_Load(object sender, EventArgs e)
        {

        }

        public void Notify(ProgressGameplayDto notification)
        {
            progressBar_gameplays.Visible = true;
            lb_progress_move_gameplays.Text = notification.GameplayFileName + " - " + notification.PercentageOfProgress + "%";
            progressBar_gameplays.Value = notification.PercentageOfProgress;
        }

        private async void Btn_last_gameplay_Click(object sender, EventArgs e)
        {
            var moveFiles = new MoveLastMp4File();

            moveFiles.Subscribe(this);
            await moveFiles.Move(_diskDrive + "\\" + _configs.FolderGameplaysHd, _configs.PathGameplaysPc);
            moveFiles.Unsubscribe(this);
            progressBar_gameplays.Visible = false;
        }
    }
}
