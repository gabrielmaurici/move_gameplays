namespace MoveGameplays.Wfp.Views.UseControlls
{
    public partial class HeaderUserControl : UserControl
    {
        public HeaderUserControl()
        {
            InitializeComponent();
        }

        private void Btn_minimize_Click_1(object sender, EventArgs e)
        {
            if (Parent is Form form)
            {
                form.WindowState = FormWindowState.Minimized;
                CurrentForm.Update(form);
            }
        }

        private void Btn_close_Click_1(object sender, EventArgs e)
        {
            if (Parent is Form form)
            {
                form.WindowState = FormWindowState.Minimized;
                form.Hide();
                CurrentForm.Update(form);
            }
        }

        public Panel GetPanel() => panel1;

        private void Btn_minimize_MouseEnter(object sender, EventArgs e)
        {
            btn_minimize.BackgroundImage = Properties.Resources.icons8_macos_minimize_25_hover;
        }

        private void Btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.BackgroundImage = Properties.Resources.icons8_macos_minimize_25;
        }

        private void Btn_close_MouseEnter(object sender, EventArgs e)
        {
            btn_close.BackgroundImage = Properties.Resources.icons8_macos_close_27_hover;

        }

        private void Btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.BackgroundImage = Properties.Resources.icons8_macos_close_27;
        }
    }
}