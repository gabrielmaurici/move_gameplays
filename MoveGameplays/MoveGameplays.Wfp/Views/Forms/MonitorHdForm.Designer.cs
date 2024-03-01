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
            headerUserControl1 = new UseControlls.HeaderUserControl();
            btn_configurations = new UIExtensions.CustomButton();
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
            label1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(2, 134);
            label1.Name = "label1";
            label1.Size = new Size(796, 50);
            label1.TabIndex = 0;
            label1.Text = "Aguardando HD esperado ser conectado";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // headerUserControl1
            // 
            headerUserControl1.Location = new Point(0, 0);
            headerUserControl1.Name = "headerUserControl1";
            headerUserControl1.Size = new Size(796, 33);
            headerUserControl1.TabIndex = 1;
            // 
            // btn_configurations
            // 
            btn_configurations.BackColor = Color.FromArgb(75, 75, 75);
            btn_configurations.BackgroundColor = Color.FromArgb(75, 75, 75);
            btn_configurations.BorderColor = Color.PaleVioletRed;
            btn_configurations.BorderRadius = 10;
            btn_configurations.BorderSize = 0;
            btn_configurations.FlatAppearance.BorderSize = 0;
            btn_configurations.FlatStyle = FlatStyle.Flat;
            btn_configurations.ForeColor = Color.White;
            btn_configurations.Location = new Point(663, 39);
            btn_configurations.Name = "btn_configurations";
            btn_configurations.Size = new Size(125, 27);
            btn_configurations.TabIndex = 2;
            btn_configurations.Text = "Configurações";
            btn_configurations.TextColor = Color.White;
            btn_configurations.UseVisualStyleBackColor = false;
            btn_configurations.Click += Btn_configurations_Click;
            // 
            // MonitorHdForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(5, 5, 5);
            ClientSize = new Size(800, 320);
            Controls.Add(btn_configurations);
            Controls.Add(headerUserControl1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MonitorHdForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MonitorHdForm";
            FormClosed += MonitorHdForm_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private NotifyIcon notifyIcon1;
        private Label label1;
        private UseControlls.HeaderUserControl headerUserControl1;
        private UIExtensions.CustomButton btn_configurations;
    }
}