namespace MoveGameplays.Wfp.Views.UseControlls
{
    partial class HeaderUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeaderUserControl));
            panel1 = new Panel();
            btn_minimize = new Button();
            btn_close = new Button();
            lb_move_gameplays = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(btn_minimize);
            panel1.Controls.Add(btn_close);
            panel1.Controls.Add(lb_move_gameplays);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 33);
            panel1.TabIndex = 2;
            // 
            // btn_minimize
            // 
            btn_minimize.BackgroundImage = Properties.Resources.icons8_macos_minimize_20;
            btn_minimize.FlatStyle = FlatStyle.Flat;
            btn_minimize.Location = new Point(736, 5);
            btn_minimize.Name = "btn_minimize";
            btn_minimize.Size = new Size(22, 22);
            btn_minimize.TabIndex = 2;
            btn_minimize.UseVisualStyleBackColor = true;
            btn_minimize.Click += Btn_minimize_Click_1;
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
            btn_close.Click += Btn_close_Click_1;
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
            // HeaderUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HeaderUserControl";
            Size = new Size(796, 33);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btn_minimize;
        private Button btn_close;
        private Label lb_move_gameplays;
    }
}
