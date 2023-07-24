namespace UltraGamesStoreNoSteamNONONO.logic
{
    partial class GameView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            labelName = new Label();
            labelAuthor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Yu Gothic UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(166, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(103, 25);
            labelName.TabIndex = 1;
            labelName.Text = "labelName";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthor.Location = new Point(166, 69);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(91, 21);
            labelAuthor.TabIndex = 3;
            labelAuthor.Text = "labelAuthor";
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            Controls.Add(labelAuthor);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Name = "GameView";
            Size = new Size(696, 100);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelName;
        private Label labelAuthor;
    }
}
