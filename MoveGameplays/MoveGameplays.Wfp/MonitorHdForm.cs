using MoveGameplays.Wfp.BackgroundService.Interfaces;

namespace MoveGameplays.Wfp
{
    public partial class MonitorHdForm : Form
    {
        private readonly IMonitorExternalHdInput _monitorExternalHdInput;

        public MonitorHdForm(IMonitorExternalHdInput monitorExternalHdInput)
        {
            InitializeComponent();
            _monitorExternalHdInput = monitorExternalHdInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hide();
            _monitorExternalHdInput.Monitor();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
            {
                Hide();
            }
        }
    }
}