namespace MoveGameplays.Wfp.Views.UseControlls
{
    public partial class HeaderUserControl : UserControl
    {
        public HeaderUserControl()
        {
            InitializeComponent();
        }

        private void Btn_minimize_Click(object sender, EventArgs e)
        {
            if (Parent is Form form)
            {
                //form.WindowState = FormWindowState.Minimized;
                CurrentForm.Update(form);
            }
        }

        private void Btn_close_Click(object sender, EventArgs e)
        {
            if (Parent is Form form)
            {
                form.WindowState = FormWindowState.Minimized;
                form.Hide();
                CurrentForm.Update(form);
            }
        }
    }
}
