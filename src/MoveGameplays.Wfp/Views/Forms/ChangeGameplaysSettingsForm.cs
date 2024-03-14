using Microsoft.Extensions.DependencyInjection;
using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Interfaces;
using MoveGameplays.Wfp.Helpers;
using System.Runtime.InteropServices;

namespace MoveGameplays.Wfp.Views.Forms
{
    public partial class ChangeGameplaysSettingsForm : Form
    {
        private readonly IMoveGameplaysSettignsService _moveGameplaysSettingsService;

        public ChangeGameplaysSettingsForm(IServiceProvider services)
        {
            InitializeComponent();

            _ = new DraggableForm(this, headerUserControl1.GetPanel());
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            _moveGameplaysSettingsService = services.GetRequiredService<IMoveGameplaysSettignsService>();
        }

        private void ChangeGameplaysSettingsForm_Load(object sender, EventArgs e)
        {
            var configs = _moveGameplaysSettingsService.GetConfigs();

            txt_hd_name.Text = configs.ExternalHdName;
            txt_folder_gameplays_hd.Text = configs.FolderGameplaysHd;
            txt_path_gameplays_pc.Text = configs.PathGameplaysPc;
            checkBox_deleteFiles.Checked = configs.DeleteFiles;
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            var monitorForm = (MonitorHdForm)Application.OpenForms["MonitorHdForm"]!;
            monitorForm.Show();
            Close();
        }

        private void Btn_save_moveGameplays_configs_Click(object sender, EventArgs e)
        {
            try
            {
                var newConfigs = new ChangeGameplaysSettingsDto(ExternalHdName: txt_hd_name.Text,
                                                                FolderGameplaysHd: txt_folder_gameplays_hd.Text,
                                                                PathGameplaysPc: txt_path_gameplays_pc.Text,
                                                                DeleteFiles: checkBox_deleteFiles.Checked);

                _moveGameplaysSettingsService.UpdateConfigs(newConfigs);

                MessageBox.Show("Configurações alteradas com sucesso, a aplicação será reiniciada");

                RestartApplication();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu algum erro ao salvar as configurações: {ex.Message}");
            }
        }

        private static void RestartApplication()
        {
            Application.Restart();
            Environment.Exit(0);
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
