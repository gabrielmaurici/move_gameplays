using MoveGameplays.Domain.Dtos;
using MoveGameplays.Domain.Interfaces.Observer;
using MoveGameplays.Wfp.BackgroundService.Interfaces;
using System.Runtime.InteropServices;
using Timer = System.Windows.Forms.Timer;

namespace MoveGameplays.Wfp.Views
{
    public partial class MonitorHdForm : Form, IObserverContract<ExpectedHdConnectedDto>
    {
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

        private readonly IMonitorExternalHdInput _monitorExternalHdInput;

        public MonitorHdForm(IMonitorExternalHdInput monitorExternalHdInput)
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            _monitorExternalHdInput = monitorExternalHdInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _monitorExternalHdInput.Subscribe(this);
            _monitorExternalHdInput.Monitor();

            //HideFormAfter5Seconds();
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
                //Hide();
            }
        }

        private void MonitorHdForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //_monitorExternalHdInput.Unsubscribe(this);
        }

        private void NotifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
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

        private void Btn_close_Click(object sender, EventArgs e)
        {
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}