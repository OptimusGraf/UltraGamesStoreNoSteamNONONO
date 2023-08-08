namespace UltraGamesStoreNoSteamNONONO
{
    partial class ReviewView
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
            richTextBoxReview = new RichTextBox();
            labelRate = new Label();
            labelAuthor = new Label();
            richTextBoxAuthor = new RichTextBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(109, 88);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(130, 10);
            labelName.Name = "labelName";
            labelName.Size = new Size(52, 21);
            labelName.TabIndex = 1;
            labelName.Text = "label1";
            // 
            // richTextBoxReview
            // 
            richTextBoxReview.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxReview.Location = new Point(0, 99);
            richTextBoxReview.Name = "richTextBoxReview";
            richTextBoxReview.ReadOnly = true;
            richTextBoxReview.Size = new Size(808, 122);
            richTextBoxReview.TabIndex = 2;
            richTextBoxReview.Text = "";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRate.Location = new Point(130, 55);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(52, 21);
            labelRate.TabIndex = 3;
            labelRate.Text = "label2";
            // 
            // labelAuthor
            // 
            labelAuthor.AutoSize = true;
            labelAuthor.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAuthor.Location = new Point(15, 224);
            labelAuthor.Name = "labelAuthor";
            labelAuthor.Size = new Size(52, 21);
            labelAuthor.TabIndex = 4;
            labelAuthor.Text = "label1";
            // 
            // richTextBoxAuthor
            // 
            richTextBoxAuthor.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxAuthor.Location = new Point(15, 247);
            richTextBoxAuthor.Name = "richTextBoxAuthor";
            richTextBoxAuthor.ReadOnly = true;
            richTextBoxAuthor.Size = new Size(620, 86);
            richTextBoxAuthor.TabIndex = 5;
            richTextBoxAuthor.Text = "";
            // 
            // panel1
            // 
            panel1.Location = new Point(669, 261);
            panel1.Name = "panel1";
            panel1.Size = new Size(139, 56);
            panel1.TabIndex = 6;
            // 
            // ReviewView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(panel1);
            Controls.Add(richTextBoxAuthor);
            Controls.Add(labelAuthor);
            Controls.Add(labelRate);
            Controls.Add(richTextBoxReview);
            Controls.Add(labelName);
            Controls.Add(pictureBox1);
            Name = "ReviewView";
            Size = new Size(828, 352);
            Load += ReviewView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label labelName;
        private RichTextBox richTextBoxReview;
        private Label labelRate;
        protected Panel panel1;
        protected RichTextBox richTextBoxAuthor;
        protected Label labelAuthor;
    }
}
