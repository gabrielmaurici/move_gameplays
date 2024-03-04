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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeGameplaysSettingsForm));
            lb_configuracoes = new Label();
            label1 = new Label();
            lb_path_gameplays_hd = new Label();
            label3 = new Label();
            txt_hd_name = new TextBox();
            txt_folder_gameplays_hd = new TextBox();
            txt_path_gameplays_pc = new TextBox();
            btn_back = new UIExtensions.CustomButton();
            btn_save_moveGameplays_configs = new UIExtensions.CustomButton();
            headerUserControl1 = new UseControlls.HeaderUserControl();
            SuspendLayout();
            // 
            // lb_configuracoes
            // 
            lb_configuracoes.Font = new Font("Segoe UI Black", 17.75F, FontStyle.Bold);
            lb_configuracoes.ForeColor = SystemColors.ButtonFace;
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
            label1.ForeColor = SystemColors.ButtonFace;
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
            lb_path_gameplays_hd.ForeColor = SystemColors.ButtonFace;
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
            label3.ForeColor = SystemColors.ButtonFace;
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
            // txt_folder_gameplays_hd
            // 
            txt_folder_gameplays_hd.BackColor = Color.FromArgb(75, 75, 75);
            txt_folder_gameplays_hd.BorderStyle = BorderStyle.FixedSingle;
            txt_folder_gameplays_hd.ForeColor = SystemColors.Control;
            txt_folder_gameplays_hd.Location = new Point(234, 155);
            txt_folder_gameplays_hd.Name = "txt_folder_gameplays_hd";
            txt_folder_gameplays_hd.Size = new Size(329, 23);
            txt_folder_gameplays_hd.TabIndex = 6;
            // 
            // txt_path_gameplays_pc
            // 
            txt_path_gameplays_pc.BackColor = Color.FromArgb(75, 75, 75);
            txt_path_gameplays_pc.BorderStyle = BorderStyle.FixedSingle;
            txt_path_gameplays_pc.ForeColor = SystemColors.Control;
            txt_path_gameplays_pc.Location = new Point(234, 206);
            txt_path_gameplays_pc.Name = "txt_path_gameplays_pc";
            txt_path_gameplays_pc.Size = new Size(329, 23);
            txt_path_gameplays_pc.TabIndex = 7;
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
            // btn_save_moveGameplays_configs
            // 
            btn_save_moveGameplays_configs.BackColor = Color.FromArgb(137, 180, 70);
            btn_save_moveGameplays_configs.BackgroundColor = Color.FromArgb(137, 180, 70);
            btn_save_moveGameplays_configs.BorderColor = Color.PaleVioletRed;
            btn_save_moveGameplays_configs.BorderRadius = 10;
            btn_save_moveGameplays_configs.BorderSize = 0;
            btn_save_moveGameplays_configs.FlatAppearance.BorderSize = 0;
            btn_save_moveGameplays_configs.FlatStyle = FlatStyle.Flat;
            btn_save_moveGameplays_configs.ForeColor = Color.White;
            btn_save_moveGameplays_configs.Location = new Point(421, 247);
            btn_save_moveGameplays_configs.Name = "btn_save_moveGameplays_configs";
            btn_save_moveGameplays_configs.Size = new Size(142, 34);
            btn_save_moveGameplays_configs.TabIndex = 9;
            btn_save_moveGameplays_configs.Text = "Salvar";
            btn_save_moveGameplays_configs.TextColor = Color.White;
            btn_save_moveGameplays_configs.UseVisualStyleBackColor = false;
            btn_save_moveGameplays_configs.Click += Btn_save_moveGameplays_configs_Click;
            // 
            // headerUserControl1
            // 
            headerUserControl1.Location = new Point(0, 0);
            headerUserControl1.Name = "headerUserControl1";
            headerUserControl1.Size = new Size(796, 33);
            headerUserControl1.TabIndex = 10;
            // 
            // ChangeGameplaysSettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(800, 320);
            Controls.Add(headerUserControl1);
            Controls.Add(btn_save_moveGameplays_configs);
            Controls.Add(btn_back);
            Controls.Add(txt_path_gameplays_pc);
            Controls.Add(txt_folder_gameplays_hd);
            Controls.Add(txt_hd_name);
            Controls.Add(label3);
            Controls.Add(lb_path_gameplays_hd);
            Controls.Add(label1);
            Controls.Add(lb_configuracoes);
            ForeColor = Color.FromArgb(5, 5, 5);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "ChangeGameplaysSettingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangeGameplaysSettingsForm";
            Load += ChangeGameplaysSettingsForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lb_configuracoes;
        private Label label1;
        private Label lb_path_gameplays_hd;
        private Label label3;
        private TextBox txt_hd_name;
        private TextBox txt_folder_gameplays_hd;
        private TextBox txt_path_gameplays_pc;
        private UIExtensions.CustomButton btn_back;
        private UIExtensions.CustomButton btn_save_moveGameplays_configs;
        private UseControlls.HeaderUserControl headerUserControl1;
    }
}