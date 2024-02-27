﻿namespace MoveGameplays.Wfp.Views
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
            btn_last_gameplay = new Button();
            btn_last_10_gameplays = new Button();
            button2 = new Button();
            lb_progress_move_gameplays = new Label();
            progressBar_gameplays = new ProgressBar();
            lb_png_gameplays = new Label();
            lb_mp4_gameplays = new Label();
            lb_move_gameplays = new Label();
            panel1 = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_last_gameplay
            // 
            btn_last_gameplay.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_last_gameplay.ForeColor = SystemColors.WindowFrame;
            btn_last_gameplay.Location = new Point(14, 59);
            btn_last_gameplay.Name = "btn_last_gameplay";
            btn_last_gameplay.Size = new Size(204, 58);
            btn_last_gameplay.TabIndex = 0;
            btn_last_gameplay.Text = "Mover última gameplay";
            btn_last_gameplay.UseVisualStyleBackColor = true;
            btn_last_gameplay.Click += Btn_last_gameplay_Click;
            // 
            // btn_last_10_gameplays
            // 
            btn_last_10_gameplays.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_last_10_gameplays.ForeColor = SystemColors.WindowFrame;
            btn_last_10_gameplays.Location = new Point(304, 59);
            btn_last_10_gameplays.Name = "btn_last_10_gameplays";
            btn_last_10_gameplays.Size = new Size(204, 58);
            btn_last_10_gameplays.TabIndex = 1;
            btn_last_10_gameplays.Text = "Mover as 10 últimas gameplays";
            btn_last_10_gameplays.UseVisualStyleBackColor = true;
            btn_last_10_gameplays.Click += Btn_last_10_gameplays_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.WindowFrame;
            button2.Location = new Point(584, 59);
            button2.Name = "button2";
            button2.Size = new Size(204, 58);
            button2.TabIndex = 2;
            button2.Text = "Mover última gameplay";
            button2.UseVisualStyleBackColor = true;
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
            // OptionsAndMoveFilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(800, 320);
            Controls.Add(panel1);
            Controls.Add(lb_mp4_gameplays);
            Controls.Add(lb_png_gameplays);
            Controls.Add(progressBar_gameplays);
            Controls.Add(lb_progress_move_gameplays);
            Controls.Add(button2);
            Controls.Add(btn_last_10_gameplays);
            Controls.Add(btn_last_gameplay);
            ForeColor = SystemColors.Desktop;
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OptionsAndMoveFilesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OptionsAndMoveFilesForm";
            Load += OptionsAndMoveFilesForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_last_gameplay;
        private Button btn_last_10_gameplays;
        private Button button2;
        private Label lb_progress_move_gameplays;
        private ProgressBar progressBar_gameplays;
        private Label lb_png_gameplays;
        private Label lb_mp4_gameplays;
        private Label lb_move_gameplays;
        private Panel panel1;
        private Button btn_minimize;
        private Button btn_close;
    }
}