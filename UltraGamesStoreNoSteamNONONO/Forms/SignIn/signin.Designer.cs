namespace UltraGamesStoreNoSteamNONONO
{
    partial class SignIn
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
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(376, 400);
            panel1.TabIndex = 0;
            // 
            // linkLabel2
            // 
            linkLabel2.Anchor = AnchorStyles.None;
            linkLabel2.AutoSize = true;
            linkLabel2.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel2.Location = new Point(39, 403);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(288, 15);
            linkLabel2.TabIndex = 5;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Нет аккаунта? нажмите, чтобы зарегистрироваться";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // signin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(376, 471);
            Controls.Add(linkLabel2);
            Controls.Add(panel1);
            Name = "signin";
            Text = "signin";
            Load += signin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Panel panel1;
        private LinkLabel linkLabel2;
    }
}