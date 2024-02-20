using MoveGameplays.Wfp.BackgroundService.Interfaces;

namespace MoveGameplays.Wfp
{
    public partial class Form1 : Form
    {
        private readonly IMonitorExternalHdInput _monitorExternalHdInput;

        public Form1(IMonitorExternalHdInput monitorExternalHdInput)
        {
            InitializeComponent();
            _monitorExternalHdInput = monitorExternalHdInput;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
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