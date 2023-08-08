namespace UltraGamesStoreNoSteamNONONO
{
    partial class GameTabControl
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
            pictureBoxForMainImage = new PictureBox();
            panelForGameView = new Panel();
            buttonExit = new Button();
            labelPower = new Label();
            labelAge = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            numericUpDown1 = new NumericUpDown();
            buttonSaveReview = new Button();
            richTextBoxNewReview = new RichTextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForMainImage).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxForMainImage
            // 
            pictureBoxForMainImage.Location = new Point(0, 0);
            pictureBoxForMainImage.Name = "pictureBoxForMainImage";
            pictureBoxForMainImage.Size = new Size(876, 143);
            pictureBoxForMainImage.TabIndex = 0;
            pictureBoxForMainImage.TabStop = false;
            // 
            // panelForGameView
            // 
            panelForGameView.Location = new Point(0, 139);
            panelForGameView.Name = "panelForGameView";
            panelForGameView.Size = new Size(876, 98);
            panelForGameView.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(851, 3);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(25, 26);
            buttonExit.TabIndex = 0;
            buttonExit.Text = "X";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // labelPower
            // 
            labelPower.AutoSize = true;
            labelPower.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPower.Location = new Point(16, 51);
            labelPower.Name = "labelPower";
            labelPower.Size = new Size(185, 21);
            labelPower.TabIndex = 6;
            labelPower.Text = "Системные требования: ";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(16, 18);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(165, 21);
            labelAge.TabIndex = 5;
            labelAge.Text = "Требуемый возвраст: ";
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAge);
            panel1.Controls.Add(labelPower);
            panel1.Location = new Point(0, 233);
            panel1.Name = "panel1";
            panel1.Size = new Size(876, 100);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(numericUpDown1);
            panel2.Controls.Add(buttonSaveReview);
            panel2.Controls.Add(richTextBoxNewReview);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 330);
            panel2.Name = "panel2";
            panel2.Size = new Size(880, 415);
            panel2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDown1.Location = new Point(586, 364);
            numericUpDown1.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 9;
            numericUpDown1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonSaveReview
            // 
            buttonSaveReview.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSaveReview.Location = new Point(732, 350);
            buttonSaveReview.Name = "buttonSaveReview";
            buttonSaveReview.Size = new Size(133, 47);
            buttonSaveReview.TabIndex = 8;
            buttonSaveReview.Text = "Сохранить отзыв";
            buttonSaveReview.UseVisualStyleBackColor = true;
            buttonSaveReview.Click += buttonSaveReview_Click;
            // 
            // richTextBoxNewReview
            // 
            richTextBoxNewReview.Font = new Font("Yu Gothic UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxNewReview.Location = new Point(5, 349);
            richTextBoxNewReview.Name = "richTextBoxNewReview";
            richTextBoxNewReview.Size = new Size(575, 59);
            richTextBoxNewReview.TabIndex = 7;
            richTextBoxNewReview.Text = "";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(880, 343);
            flowLayoutPanel1.TabIndex = 6;
            flowLayoutPanel1.WrapContents = false;
            // 
            // GameTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(buttonExit);
            Controls.Add(panelForGameView);
            Controls.Add(pictureBoxForMainImage);
            Name = "GameTabControl";
            Size = new Size(880, 745);
            ((System.ComponentModel.ISupportInitialize)pictureBoxForMainImage).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxForMainImage;
        private Panel panelForGameView;
        private Button buttonExit;
        private Label labelPower;
        private Label labelAge;
        private Panel panel1;
        private Panel panel2;
        private NumericUpDown numericUpDown1;
        private Button buttonSaveReview;
        private RichTextBox richTextBoxNewReview;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
