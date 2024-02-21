using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Domain.Models;
using MoveGameplays.Infraestruct;

namespace MoveGameplays.Wfp
{
    public partial class OptionsAndMoveFilesForm : Form
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

        private void Btn_last_gameplay_Click(object sender, EventArgs e)
        {
            IMoveFiles moveFiles = new MoveLastMp4File();
            moveFiles.Move(_diskDrive + _configs.FolderGameplaysHd, _configs.PathGameplaysPc);
        }
    }
}
