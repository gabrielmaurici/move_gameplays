using System.Runtime.InteropServices;

namespace MoveGameplays.Wfp.Views.Forms
{
    public partial class ChangeGameplaysSettingsForm : Form
    {
        //private readonly IChangeGameplaysSettings _changeGameplaysSettings;

        public ChangeGameplaysSettingsForm(/*IChangeGameplaysSettings changeGameplaysSettings*/)
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            //_changeGameplaysSettings = changeGameplaysSettings;
        }

        private void CustomButton2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Close();
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
