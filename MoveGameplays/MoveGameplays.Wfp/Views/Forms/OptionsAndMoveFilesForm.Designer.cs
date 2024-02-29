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
            lb_png_gameplays = new Label();
            lb_mp4_gameplays = new Label();
            btn_move_last_gameplay = new UIExtensions.CustomButton();
            btn_move_last_10_gameplays = new UIExtensions.CustomButton();
            progressBar_gameplays = new UIExtensions.CustomProgressBar();
            headerUserControl1 = new UseControlls.HeaderUserControl();
            SuspendLayout();
            // 
            // lb_progress_move_gameplays
            // 
            lb_progress_move_gameplays.Font = new Font("Sans Serif Collection", 14.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_progress_move_gameplays.ForeColor = SystemColors.ButtonFace;
            lb_progress_move_gameplays.Location = new Point(1, 162);
            lb_progress_move_gameplays.Name = "lb_progress_move_gameplays";
            lb_progress_move_gameplays.Size = new Size(799, 50);
            lb_progress_move_gameplays.TabIndex = 3;
            lb_progress_move_gameplays.Text = "Escolha uma opção a cima";
            lb_progress_move_gameplays.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_png_gameplays
            // 
            lb_png_gameplays.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_png_gameplays.ForeColor = SystemColors.ButtonFace;
            lb_png_gameplays.Location = new Point(61, 140);
            lb_png_gameplays.Name = "lb_png_gameplays";
            lb_png_gameplays.Size = new Size(739, 50);
            lb_png_gameplays.TabIndex = 5;
            lb_png_gameplays.Text = "teste1";
            lb_png_gameplays.TextAlign = ContentAlignment.MiddleLeft;
            lb_png_gameplays.Visible = false;
            // 
            // lb_mp4_gameplays
            // 
            lb_mp4_gameplays.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_mp4_gameplays.ForeColor = SystemColors.ButtonFace;
            lb_mp4_gameplays.Location = new Point(61, 190);
            lb_mp4_gameplays.Name = "lb_mp4_gameplays";
            lb_mp4_gameplays.Size = new Size(739, 50);
            lb_mp4_gameplays.TabIndex = 6;
            lb_mp4_gameplays.Text = "teste2";
            lb_mp4_gameplays.TextAlign = ContentAlignment.MiddleLeft;
            lb_mp4_gameplays.Visible = false;
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
            btn_move_last_gameplay.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_move_last_gameplay.ForeColor = Color.White;
            btn_move_last_gameplay.Location = new Point(61, 80);
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
            btn_move_last_10_gameplays.Font = new Font("Segoe UI Black", 9.75F, FontStyle.Bold);
            btn_move_last_10_gameplays.ForeColor = Color.White;
            btn_move_last_10_gameplays.Location = new Point(416, 80);
            btn_move_last_10_gameplays.Name = "btn_move_last_10_gameplays";
            btn_move_last_10_gameplays.Size = new Size(329, 48);
            btn_move_last_10_gameplays.TabIndex = 9;
            btn_move_last_10_gameplays.Text = "Mover últimas 10 Gameplays";
            btn_move_last_10_gameplays.TextColor = Color.White;
            btn_move_last_10_gameplays.UseVisualStyleBackColor = false;
            btn_move_last_10_gameplays.Click += Btn_move_last_10_gameplays_Click;
            // 
            // progressBar_gameplays
            // 
            progressBar_gameplays.ChannelColor = Color.LightSteelBlue;
            progressBar_gameplays.ChannelHeight = 10;
            progressBar_gameplays.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            progressBar_gameplays.ForeBackColor = Color.FromArgb(5, 5, 5);
            progressBar_gameplays.ForeColor = Color.White;
            progressBar_gameplays.Location = new Point(61, 243);
            progressBar_gameplays.Name = "progressBar_gameplays";
            progressBar_gameplays.ShowMaximun = false;
            progressBar_gameplays.ShowValue = UIExtensions.TextPosition.Right;
            progressBar_gameplays.Size = new Size(684, 33);
            progressBar_gameplays.SliderColor = Color.FromArgb(0, 165, 255);
            progressBar_gameplays.SliderHeight = 10;
            progressBar_gameplays.Style = ProgressBarStyle.Marquee;
            progressBar_gameplays.SymbolAfter = "%";
            progressBar_gameplays.SymbolBefore = "";
            progressBar_gameplays.TabIndex = 10;
            // 
            // headerUserControl1
            // 
            headerUserControl1.Location = new Point(0, 0);
            headerUserControl1.Name = "headerUserControl1";
            headerUserControl1.Size = new Size(796, 33);
            headerUserControl1.TabIndex = 11;
            // 
            // OptionsAndMoveFilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(800, 320);
            Controls.Add(headerUserControl1);
            Controls.Add(progressBar_gameplays);
            Controls.Add(btn_move_last_10_gameplays);
            Controls.Add(btn_move_last_gameplay);
            Controls.Add(lb_mp4_gameplays);
            Controls.Add(lb_png_gameplays);
            Controls.Add(lb_progress_move_gameplays);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OptionsAndMoveFilesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OptionsAndMoveFilesForm";
            Resize += OptionsAndMoveFilesForm_Resize;
            ResumeLayout(false);
        }

        #endregion
        private Label lb_progress_move_gameplays;
        private Label lb_png_gameplays;
        private Label lb_mp4_gameplays;
        private UIExtensions.CustomButton btn_move_last_gameplay;
        private UIExtensions.CustomButton btn_move_last_10_gameplays;
        private UIExtensions.CustomProgressBar progressBar_gameplays;
        private UseControlls.HeaderUserControl headerUserControl1;
    }
}