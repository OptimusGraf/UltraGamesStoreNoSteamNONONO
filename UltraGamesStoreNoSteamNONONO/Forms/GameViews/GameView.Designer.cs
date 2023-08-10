namespace UltraGamesStoreNoSteamNONONO
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
            button1 = new Button();
            button2 = new Button();
            labelDate = new Label();
            labelRate = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 98);
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
            labelAuthor.Location = new Point(178, 45);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(91, 21);
            labelAuthor.TabIndex = 3;
            labelAuthor.Text = "labelAuthor";
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(584, 8);
            button1.Name = "button1";
            button1.Size = new Size(96, 32);
            button1.TabIndex = 4;
            button1.Text = "В корзину";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Green;
            button2.Font = new Font("Yu Gothic UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(584, 56);
            button2.Name = "button2";
            button2.Size = new Size(96, 32);
            button2.TabIndex = 5;
            button2.Text = "В желаемое";
            button2.UseVisualStyleBackColor = false;
            // 
            // labelDate
            // 
            labelDate.AutoSize = true;
            labelDate.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.Location = new Point(275, 50);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(38, 15);
            labelDate.TabIndex = 6;
            labelDate.Text = "label1";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRate.Location = new Point(513, 14);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(52, 21);
            labelRate.TabIndex = 7;
            labelRate.Text = "label1";
            // 
            // GameView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.GradientActiveCaption;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(labelRate);
            Controls.Add(labelDate);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(labelAuthor);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Name = "GameView";
            Size = new Size(750, 98);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelAuthor;
        private Label labelDate;
        protected Button button1;
        protected Button button2;
        protected Label labelName;
        private Label labelRate;
    }
}
