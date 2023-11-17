namespace WF_JeuDuPendu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            txtMot = new TextBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            cboLettre = new ComboBox();
            imgPendu = new PictureBox();
            btnRejouer = new Button();
            btnQuitter = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPendu).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtMot);
            groupBox1.Font = new Font("Noto Sans Cond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(351, 88);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mot à chercher";
            // 
            // txtMot
            // 
            txtMot.Font = new Font("Consolas", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtMot.Location = new Point(14, 39);
            txtMot.Name = "txtMot";
            txtMot.Size = new Size(324, 39);
            txtMot.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(cboLettre);
            groupBox2.Font = new Font("Noto Sans Cond", 12F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(17, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(351, 151);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Lettres proposées";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(16, 94);
            label1.Name = "label1";
            label1.Size = new Size(322, 24);
            label1.TabIndex = 2;
            label1.Text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            // 
            // cboLettre
            // 
            cboLettre.Font = new Font("Noto Sans", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cboLettre.FormattingEnabled = true;
            cboLettre.Location = new Point(16, 36);
            cboLettre.Name = "cboLettre";
            cboLettre.Size = new Size(64, 34);
            cboLettre.TabIndex = 0;
            // 
            // imgPendu
            // 
            imgPendu.Location = new Point(393, 31);
            imgPendu.Name = "imgPendu";
            imgPendu.Size = new Size(318, 335);
            imgPendu.TabIndex = 2;
            imgPendu.TabStop = false;
            // 
            // btnRejouer
            // 
            btnRejouer.BackColor = SystemColors.ButtonHighlight;
            btnRejouer.ForeColor = SystemColors.ControlText;
            btnRejouer.Image = (Image)resources.GetObject("btnRejouer.Image");
            btnRejouer.Location = new Point(309, 316);
            btnRejouer.Name = "btnRejouer";
            btnRejouer.Size = new Size(59, 50);
            btnRejouer.TabIndex = 3;
            btnRejouer.UseVisualStyleBackColor = false;
            // 
            // btnQuitter
            // 
            btnQuitter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnQuitter.BackColor = SystemColors.ButtonHighlight;
            btnQuitter.ForeColor = SystemColors.ControlText;
            btnQuitter.Image = (Image)resources.GetObject("btnQuitter.Image");
            btnQuitter.Location = new Point(17, 316);
            btnQuitter.Name = "btnQuitter";
            btnQuitter.Size = new Size(59, 50);
            btnQuitter.TabIndex = 4;
            btnQuitter.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(723, 387);
            Controls.Add(btnQuitter);
            Controls.Add(btnRejouer);
            Controls.Add(imgPendu);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("MV Boli", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Jeu du pendu";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPendu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtMot;
        private GroupBox groupBox2;
        private Label label1;
        private ComboBox cboLettre;
        private PictureBox imgPendu;
        private Button btnRejouer;
        private Button btnQuitter;
    }
}