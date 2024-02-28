namespace MoveGameplays.Wfp.Views
{
    partial class OptionsAndMoveFilesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsAndMoveFilesForm));
            lb_progress_move_gameplays = new Label();
            progressBar_gameplays = new ProgressBar();
            lb_png_gameplays = new Label();
            lb_mp4_gameplays = new Label();
            lb_move_gameplays = new Label();
            panel1 = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            btn_move_last_gameplay = new UIExtensions.CustomButton();
            btn_move_last_10_gameplays = new UIExtensions.CustomButton();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_progress_move_gameplays
            // 
            lb_progress_move_gameplays.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_progress_move_gameplays.ForeColor = SystemColors.ButtonFace;
            lb_progress_move_gameplays.Location = new Point(1, 151);
            lb_progress_move_gameplays.Name = "lb_progress_move_gameplays";
            lb_progress_move_gameplays.Size = new Size(799, 50);
            lb_progress_move_gameplays.TabIndex = 3;
            lb_progress_move_gameplays.Text = "Escolha uma opção a cima";
            lb_progress_move_gameplays.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar_gameplays
            // 
            progressBar_gameplays.BackColor = SystemColors.Desktop;
            progressBar_gameplays.Cursor = Cursors.AppStarting;
            progressBar_gameplays.Location = new Point(61, 242);
            progressBar_gameplays.Name = "progressBar_gameplays";
            progressBar_gameplays.Size = new Size(684, 39);
            progressBar_gameplays.TabIndex = 4;
            progressBar_gameplays.Visible = false;
            // 
            // lb_png_gameplays
            // 
            lb_png_gameplays.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_png_gameplays.ForeColor = SystemColors.ButtonFace;
            lb_png_gameplays.Location = new Point(1, 120);
            lb_png_gameplays.Name = "lb_png_gameplays";
            lb_png_gameplays.Size = new Size(799, 50);
            lb_png_gameplays.TabIndex = 5;
            lb_png_gameplays.Text = "teste1";
            lb_png_gameplays.TextAlign = ContentAlignment.MiddleCenter;
            lb_png_gameplays.Visible = false;
            // 
            // lb_mp4_gameplays
            // 
            lb_mp4_gameplays.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_mp4_gameplays.ForeColor = SystemColors.ButtonFace;
            lb_mp4_gameplays.Location = new Point(1, 170);
            lb_mp4_gameplays.Name = "lb_mp4_gameplays";
            lb_mp4_gameplays.Size = new Size(799, 50);
            lb_mp4_gameplays.TabIndex = 6;
            lb_mp4_gameplays.Text = "teste2";
            lb_mp4_gameplays.TextAlign = ContentAlignment.MiddleCenter;
            lb_mp4_gameplays.Visible = false;
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
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_minimize);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(lb_move_gameplays);
            panel1.Location = new Point(4, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 33);
            panel1.TabIndex = 7;
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
            // btn_move_last_gameplay
            // 
            btn_move_last_gameplay.BackColor = Color.FromArgb(75, 75, 75);
            btn_move_last_gameplay.BackgroundColor = Color.FromArgb(75, 75, 75);
            btn_move_last_gameplay.BorderColor = Color.PaleVioletRed;
            btn_move_last_gameplay.BorderRadius = 10;
            btn_move_last_gameplay.BorderSize = 0;
            btn_move_last_gameplay.FlatAppearance.BorderSize = 0;
            btn_move_last_gameplay.FlatStyle = FlatStyle.Flat;
            btn_move_last_gameplay.ForeColor = Color.White;
            btn_move_last_gameplay.Location = new Point(61, 69);
            btn_move_last_gameplay.Name = "btn_move_last_gameplay";
            btn_move_last_gameplay.Size = new Size(329, 48);
            btn_move_last_gameplay.TabIndex = 8;
            btn_move_last_gameplay.Text = "Mover última Gameplay";
            btn_move_last_gameplay.TextColor = Color.White;
            btn_move_last_gameplay.UseVisualStyleBackColor = false;
            btn_move_last_gameplay.Click += Btn_move_last_gameplay_Click;
            // 
            // btn_move_last_10_gameplays
            // 
            btn_move_last_10_gameplays.BackColor = Color.FromArgb(75, 75, 75);
            btn_move_last_10_gameplays.BackgroundColor = Color.FromArgb(75, 75, 75);
            btn_move_last_10_gameplays.BorderColor = Color.PaleVioletRed;
            btn_move_last_10_gameplays.BorderRadius = 10;
            btn_move_last_10_gameplays.BorderSize = 0;
            btn_move_last_10_gameplays.FlatAppearance.BorderSize = 0;
            btn_move_last_10_gameplays.FlatStyle = FlatStyle.Flat;
            btn_move_last_10_gameplays.ForeColor = Color.White;
            btn_move_last_10_gameplays.Location = new Point(416, 69);
            btn_move_last_10_gameplays.Name = "btn_move_last_10_gameplays";
            btn_move_last_10_gameplays.Size = new Size(329, 48);
            btn_move_last_10_gameplays.TabIndex = 9;
            btn_move_last_10_gameplays.Text = "Mover últimas 10 Gameplays";
            btn_move_last_10_gameplays.TextColor = Color.White;
            btn_move_last_10_gameplays.UseVisualStyleBackColor = false;
            btn_move_last_10_gameplays.Click += Btn_move_last_10_gameplays_Click;
            // 
            // OptionsAndMoveFilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(800, 320);
            Controls.Add(btn_move_last_10_gameplays);
            Controls.Add(btn_move_last_gameplay);
            Controls.Add(panel1);
            Controls.Add(lb_mp4_gameplays);
            Controls.Add(lb_png_gameplays);
            Controls.Add(progressBar_gameplays);
            Controls.Add(lb_progress_move_gameplays);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OptionsAndMoveFilesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OptionsAndMoveFilesForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Label lb_progress_move_gameplays;
        private ProgressBar progressBar_gameplays;
        private Label lb_png_gameplays;
        private Label lb_mp4_gameplays;
        private Label lb_move_gameplays;
        private Panel panel1;
        private Button btn_minimize;
        private Button btn_close;
        private UIExtensions.CustomButton btn_move_last_gameplay;
        private UIExtensions.CustomButton btn_move_last_10_gameplays;
    }
}