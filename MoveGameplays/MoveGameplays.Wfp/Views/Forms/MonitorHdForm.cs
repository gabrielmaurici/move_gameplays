using Microsoft.Extensions.DependencyInjection;
using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Interfaces.Observer;
using MoveGameplays.Wfp.BackgroundService.Interfaces;
using MoveGameplays.Wfp.Views.Forms;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace MoveGameplays.Wfp.Views
{
    public partial class MonitorHdForm : Form, IObserverContract<ExpectedHdConnectedDto>
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IMonitorExternalHdInput _monitorExternalHdInput;

        public MonitorHdForm(IServiceProvider services)
        {
            InitializeComponent();
            CurrentForm.Update(this);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            _serviceProvider = services;
            _monitorExternalHdInput = services.GetRequiredService<IMonitorExternalHdInput>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _monitorExternalHdInput.Subscribe(this);
            _monitorExternalHdInput.Monitor();

            HideFormAfter5Seconds();
        }

        public void Notify(ExpectedHdConnectedDto notification)
        {
            Hide();
            new OptionsAndMoveFilesForm(notification.DiskDrive, notification.MoveGameplaysConfig).ShowDialog();
            Show();
        }

        private void Btn_configurations_Click(object sender, EventArgs e)
        {
            Hide();
            new ChangeGameplaysSettingsForm(_serviceProvider).ShowDialog();
            Show();
        }

        private void MonitorHdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _monitorExternalHdInput.Unsubscribe(this);
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var form = CurrentForm.Current;
            if (form != null)
            {
                form.Show();
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void HideFormAfter5Seconds()
        {
            Timer timer = new()
            {
                Interval = 5000
            };

            timer.Tick += (s, args) =>
            {
                timer.Stop();
                Hide();
            };
            timer.Start();
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