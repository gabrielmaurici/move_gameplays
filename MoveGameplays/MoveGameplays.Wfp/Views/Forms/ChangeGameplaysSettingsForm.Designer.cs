namespace MoveGameplays.Wfp.Views.Forms
{
    partial class ChangeGameplaysSettingsForm
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
            headerUserControl1 = new UseControlls.HeaderUserControl();
            lb_configuracoes = new Label();
            label1 = new Label();
            lb_path_gameplays_hd = new Label();
            label3 = new Label();
            txt_hd_name = new TextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            btn_back = new UIExtensions.CustomButton();
            customButton2 = new UIExtensions.CustomButton();
            SuspendLayout();
            // 
            // headerUserControl1
            // 
            headerUserControl1.Location = new Point(0, 0);
            headerUserControl1.Name = "headerUserControl1";
            headerUserControl1.Size = new Size(796, 33);
            headerUserControl1.TabIndex = 0;
            // 
            // lb_configuracoes
            // 
            lb_configuracoes.Font = new Font("Segoe UI Black", 17.75F, FontStyle.Bold);
            lb_configuracoes.Location = new Point(0, 36);
            lb_configuracoes.Name = "lb_configuracoes";
            lb_configuracoes.Size = new Size(796, 32);
            lb_configuracoes.TabIndex = 1;
            lb_configuracoes.Text = "Configurações Move Gameplays";
            lb_configuracoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 82);
            label1.Name = "label1";
            label1.Size = new Size(796, 22);
            label1.TabIndex = 2;
            label1.Text = "Nome do HD/Pendriver";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb_path_gameplays_hd
            // 
            lb_path_gameplays_hd.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_path_gameplays_hd.Location = new Point(2, 133);
            lb_path_gameplays_hd.Name = "lb_path_gameplays_hd";
            lb_path_gameplays_hd.Size = new Size(796, 19);
            lb_path_gameplays_hd.TabIndex = 3;
            lb_path_gameplays_hd.Text = "Pasta origem com as Gameplays";
            lb_path_gameplays_hd.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(2, 181);
            label3.Name = "label3";
            label3.Size = new Size(796, 22);
            label3.TabIndex = 4;
            label3.Text = "Caminho completo destino das Gameplays";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_hd_name
            // 
            txt_hd_name.BackColor = Color.FromArgb(75, 75, 75);
            txt_hd_name.BorderStyle = BorderStyle.FixedSingle;
            txt_hd_name.ForeColor = SystemColors.Control;
            txt_hd_name.Location = new Point(234, 107);
            txt_hd_name.Name = "txt_hd_name";
            txt_hd_name.Size = new Size(329, 23);
            txt_hd_name.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(75, 75, 75);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.Control;
            textBox1.Location = new Point(234, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(329, 23);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(75, 75, 75);
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.ForeColor = SystemColors.Control;
            textBox2.Location = new Point(234, 206);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(329, 23);
            textBox2.TabIndex = 7;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(213, 199, 50);
            btn_back.BackgroundColor = Color.FromArgb(213, 199, 50);
            btn_back.BorderColor = Color.PaleVioletRed;
            btn_back.BorderRadius = 10;
            btn_back.BorderSize = 0;
            btn_back.FlatAppearance.BorderSize = 0;
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(234, 247);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(142, 34);
            btn_back.TabIndex = 8;
            btn_back.Text = "Voltar";
            btn_back.TextColor = Color.White;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += Btn_back_Click;
            // 
            // customButton2
            // 
            customButton2.BackColor = Color.FromArgb(137, 180, 70);
            customButton2.BackgroundColor = Color.FromArgb(137, 180, 70);
            customButton2.BorderColor = Color.PaleVioletRed;
            customButton2.BorderRadius = 10;
            customButton2.BorderSize = 0;
            customButton2.FlatAppearance.BorderSize = 0;
            customButton2.FlatStyle = FlatStyle.Flat;
            customButton2.ForeColor = Color.White;
            customButton2.Location = new Point(421, 247);
            customButton2.Name = "customButton2";
            customButton2.Size = new Size(142, 34);
            customButton2.TabIndex = 9;
            customButton2.Text = "Salvar";
            customButton2.TextColor = Color.White;
            customButton2.UseVisualStyleBackColor = false;
            customButton2.Click += CustomButton2_Click;
            // 
            // ChangeGameplaysSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(800, 320);
            Controls.Add(customButton2);
            Controls.Add(btn_back);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(txt_hd_name);
            Controls.Add(label3);
            Controls.Add(lb_path_gameplays_hd);
            Controls.Add(label1);
            Controls.Add(lb_configuracoes);
            Controls.Add(headerUserControl1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeGameplaysSettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangeGameplaysSettingsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private UseControlls.HeaderUserControl headerUserControl1;
        private Label lb_configuracoes;
        private Label label1;
        private Label lb_path_gameplays_hd;
        private Label label3;
        private TextBox txt_hd_name;
        private TextBox textBox1;
        private TextBox textBox2;
        private UIExtensions.CustomButton btn_back;
        private UIExtensions.CustomButton customButton2;
    }
}