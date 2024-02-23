using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Enums;
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
            try
            {
                switch(notification.FileType)
                {
                    case EFileType.Png:
                        lb_png_gameplays.Text = $"Movendo imagens: {notification.FileName} - {notification.NumberOfFiles}";
                        lb_png_gameplays.Visible = true;
                        break;
                    case EFileType.Mp4:
                        lb_mp4_gameplays.Visible = true;
                        lb_mp4_gameplays.Text = $"Movendo gameplays: {notification.FileName} - {notification.NumberOfFiles}";
                        progressBar_gameplays.Visible = true;
                        progressBar_gameplays.Value = notification.PercentageOfProgress;
                    break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void Btn_last_gameplay_Click(object sender, EventArgs e)
        {
            var moveFiles = new MoveLastMp4File();
            await MoveGameplays(moveFiles);
        }


        private async void Btn_last_10_gameplays_Click(object sender, EventArgs e)
        {
            var moveFiles = new MoveLast10Mp4Files();
            await MoveGameplays(moveFiles);
        }

        private async Task MoveGameplays(MoveFilesBase moveFiles)
        {
            lb_progress_move_gameplays.Visible = false;
            progressBar_gameplays.Visible = true;

            moveFiles.Subscribe(this);
            await moveFiles.Move(_diskDrive + "\\" + _configs.FolderGameplaysHd, _configs.PathGameplaysPc);
            moveFiles.Unsubscribe(this);

            progressBar_gameplays.Visible = false;

            MessageBox.Show("Todas as imagens e gameplays foram movidas com sucesso!");
            Close();
        }
    }
}
