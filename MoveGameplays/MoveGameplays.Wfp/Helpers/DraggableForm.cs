namespace MoveGameplays.Wfp.Helpers
{
    public class DraggableForm
    {
        private bool dragging = false;
        private Point startPoint = Point.Empty;
        private readonly Form? _form;
        private readonly Panel? _panel;

        public DraggableForm(Form form, Panel panel)
        {
            _form = form;
            _panel = panel;
            AttachEvents();
        }

        private void AttachEvents()
        {
            _form!.MouseDown += Form_MouseDown!;
            _form!.MouseMove += Form_MouseMove!;
            _form!.MouseUp += Form_MouseUp!;

            _panel!.MouseDown += Form_MouseDown!;
            _panel!.MouseMove += Form_MouseMove!;
            _panel!.MouseUp += Form_MouseUp!;
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = _form!.PointToScreen(e.Location);
                _form.Location = new Point(p.X - startPoint.X, p.Y - startPoint.Y);
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}
