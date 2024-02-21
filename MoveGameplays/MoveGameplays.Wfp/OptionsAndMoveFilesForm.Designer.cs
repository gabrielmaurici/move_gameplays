namespace MoveGameplays.Wfp
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
            SuspendLayout();
            // 
            // btn_last_gameplay
            // 
            btn_last_gameplay.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_last_gameplay.ForeColor = SystemColors.WindowFrame;
            btn_last_gameplay.Location = new Point(12, 39);
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
            btn_last_10_gameplays.Location = new Point(293, 39);
            btn_last_10_gameplays.Name = "btn_last_10_gameplays";
            btn_last_10_gameplays.Size = new Size(204, 58);
            btn_last_10_gameplays.TabIndex = 1;
            btn_last_10_gameplays.Text = "Mover as 10 últimas gameplays";
            btn_last_10_gameplays.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.WindowFrame;
            button2.Location = new Point(584, 39);
            button2.Name = "button2";
            button2.Size = new Size(204, 58);
            button2.TabIndex = 2;
            button2.Text = "Mover última gameplay";
            button2.UseVisualStyleBackColor = true;
            // 
            // OptionsAndMoveFilesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Desktop;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(btn_last_10_gameplays);
            Controls.Add(btn_last_gameplay);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "OptionsAndMoveFilesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "OptionsAndMoveFilesForm";
            Load += OptionsAndMoveFilesForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_last_gameplay;
        private Button btn_last_10_gameplays;
        private Button button2;
    }
}