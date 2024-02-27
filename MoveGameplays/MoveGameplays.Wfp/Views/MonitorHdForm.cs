using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Interfaces.Observer;
using MoveGameplays.Wfp.BackgroundService.Interfaces;
using Timer = System.Windows.Forms.Timer;

namespace MoveGameplays.Wfp.Views
{
    public partial class MonitorHdForm : Form, IObserverContract<ExpectedHdConnectedDto>
    {
        private readonly IMonitorExternalHdInput _monitorExternalHdInput;

        public MonitorHdForm(IMonitorExternalHdInput monitorExternalHdInput)
        {
            InitializeComponent();
            _monitorExternalHdInput = monitorExternalHdInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _monitorExternalHdInput.Subscribe(this);
            _monitorExternalHdInput.Monitor();

            HideFormAfter5Seconds();
        }

        public void Notify(ExpectedHdConnectedDto notification)
        {
            new OptionsAndMoveFilesForm(notification.diskDrive, notification.moveGameplaysConfig).ShowDialog();
            HideFormAfter5Seconds();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
            }
        }

        private void MonitorHdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _monitorExternalHdInput.Unsubscribe(this);
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
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
    }
}