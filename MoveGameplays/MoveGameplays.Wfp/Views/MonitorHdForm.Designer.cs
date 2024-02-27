namespace MoveGameplays.Wfp.Views
{
    partial class MonitorHdForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitorHdForm));
            notifyIcon1 = new NotifyIcon(components);
            label1 = new Label();
            panel1 = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            lb_move_gameplays = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // notifyIcon1
            // 
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            notifyIcon1.MouseDoubleClick += NotifyIcon1_MouseDoubleClick;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(5, 5, 5);
            label1.Font = new Font("Sans Serif Collection", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(2, 134);
            label1.Name = "label1";
            label1.Size = new Size(796, 50);
            label1.TabIndex = 0;
            label1.Text = "Aguardando HD esperado ser conectado";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_minimize);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(lb_move_gameplays);
            panel1.Location = new Point(2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 33);
            panel1.TabIndex = 1;
            // 
            // btn_minimize
            // 
            btn_minimize.BackgroundImage = (Image)resources.GetObject("btn_minimize.BackgroundImage");
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Location = new Point(736, 5);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(22, 22);
            btn_minimize.TabIndex = 2;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += Btn_minimize_Click;
            // 
            // btn_close
            // 
            btn_close.BackgroundImage = (Image)resources.GetObject("btn_close.BackgroundImage");
            btn_close.FlatStyle = FlatStyle.Flat;
            btn_close.Location = new Point(764, 5);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(22, 22);
            btn_close.TabIndex = 1;
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += Btn_close_Click;
            // 
            // lb_move_gameplays
            // 
            lb_move_gameplays.AutoSize = true;
            lb_move_gameplays.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_move_gameplays.ForeColor = SystemColors.ButtonFace;
            lb_move_gameplays.Location = new Point(10, 9);
            lb_move_gameplays.Name = "lb_move_gameplays";
            lb_move_gameplays.Size = new Size(99, 15);
            lb_move_gameplays.TabIndex = 0;
            lb_move_gameplays.Text = "MoveGameplays";
            // 
            // MonitorHdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(800, 320);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MonitorHdForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonitorHdForm";
            FormClosed += MonitorHdForm_FormClosed;
            Load += Form1_Load;
            Resize += Form1_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Label label1;
        private Panel panel1;
        private Button btn_close;
        private Label lb_move_gameplays;
        private Button btn_minimize;
    }
}