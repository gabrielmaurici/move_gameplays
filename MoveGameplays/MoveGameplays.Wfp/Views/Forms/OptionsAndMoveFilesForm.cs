using Microsoft.Extensions.DependencyInjection;
using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Enums;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Domain.Interfaces.Observer;
using MoveGameplays.Domain.Models;
using MoveGameplays.Infraestruct;
using MoveGameplays.Wfp.Helpers;
using System.Runtime.InteropServices;

namespace MoveGameplays.Wfp.Views
{
    public partial class OptionsAndMoveFilesForm : Form, IObserverContract<ProgressGameplayDto>
    {
        private readonly string _diskDrive;
        private bool _fileMoveProcessError = false;
        private readonly MoveGameplaysConfigModel _configs;

        private readonly IDeleteFilesService _deleteFilesService;

        public OptionsAndMoveFilesForm(IServiceProvider services,string diskDrive, MoveGameplaysConfigModel configs)
        {
            InitializeComponent();

            _ = new DraggableForm(this, headerUserControl1.GetPanel());
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            _configs = configs;
            _diskDrive = diskDrive;
            _deleteFilesService = services.GetRequiredService<IDeleteFilesService>();
        }

        public void Notify(ProgressGameplayDto notification)
        {
            if (notification.Success)
            {
                switch (notification.FileType)
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
            else
            {
                _fileMoveProcessError = true;
                MessageBox.Show(notification.MessageError);
            }
        }

        private async void Btn_move_last_gameplay_Click(object sender, EventArgs e)
        {
            DisableButtonsAndHideLbChoices();

            var moveFiles = new MoveLastMp4File();
            await MoveGameplaysBase(moveFiles);
        }

        private async void Btn_move_last_10_gameplays_Click(object sender, EventArgs e)
        {
            DisableButtonsAndHideLbChoices();

            var moveFiles = new MoveLast10Mp4Files();
            await MoveGameplaysBase(moveFiles);
        }

        private async Task MoveGameplaysBase(MoveFilesBase moveFiles)
        {
            var pathGameplaysHd = _diskDrive + "\\" + _configs.FolderGameplaysHd;

            moveFiles.Subscribe(this);
            await moveFiles.Move(pathGameplaysHd, _configs.PathGameplaysPc);
            moveFiles.Unsubscribe(this);

            if (_fileMoveProcessError)
            {
                var messageDeleteFiles = _configs.DeleteFiles ? " Os arquivos do seu HD não serão deletados" : string.Empty;
                MessageBox.Show("Ocorreu erro ao mover um ou mais arquivos." + messageDeleteFiles);
            }
            else
            {
                MessageBox.Show("Todas as imagens e gameplays foram movidas com sucesso!");
            }

            if (_configs.DeleteFiles)
                _deleteFilesService.Delete(pathGameplaysHd);
            ResetStateOfLabelsAndButtons();

            var monitorForm = (MonitorHdForm)Application.OpenForms["MonitorHdForm"]!;
            CurrentForm.Update(monitorForm);

            Close();
        }

        private void DisableButtonsAndHideLbChoices()
        {
            btn_move_last_gameplay.Enabled = false;
            btn_move_last_10_gameplays.Enabled = false;
            lb_choice_option.Visible = false;
        }

        private void ResetStateOfLabelsAndButtons()
        {
            btn_move_last_gameplay.Enabled = true;
            btn_move_last_10_gameplays.Enabled = true;
            lb_choice_option.Visible = true;
            lb_mp4_gameplays.Visible = false;
            lb_png_gameplays.Visible = false;
        }

        [LibraryImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static partial IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
    }
}
