namespace UltraGamesStoreNoSteamNONONO.Forms
{
    partial class AuthorGameForm
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
            pictureBoxImage = new PictureBox();
            pictureBoxIcon = new PictureBox();
            labelName = new Label();
            labelPrice = new Label();
            labelRate = new Label();
            labelRealese = new Label();
            labelAge = new Label();
            labelPowerOfPc = new Label();
            buttonImage = new Button();
            buttonIcon = new Button();
            buttonSave = new Button();
            buttonReviews = new Button();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownAge = new NumericUpDown();
            numericUpDownPower = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPower).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.Dock = DockStyle.Top;
            pictureBoxImage.Location = new Point(0, 0);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(703, 143);
            pictureBoxImage.TabIndex = 0;
            pictureBoxImage.TabStop = false;
            // 
            // pictureBoxIcon
            // 
            pictureBoxIcon.Location = new Point(12, 149);
            pictureBoxIcon.Name = "pictureBoxIcon";
            pictureBoxIcon.Size = new Size(120, 99);
            pictureBoxIcon.TabIndex = 1;
            pictureBoxIcon.TabStop = false;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(12, 281);
            labelName.Name = "labelName";
            labelName.Size = new Size(85, 21);
            labelName.TabIndex = 2;
            labelName.Text = "Название: ";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPrice.Location = new Point(12, 317);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(54, 21);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Цена: ";
            // 
            // labelRate
            // 
            labelRate.AutoSize = true;
            labelRate.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRate.Location = new Point(506, 173);
            labelRate.Name = "labelRate";
            labelRate.Size = new Size(74, 21);
            labelRate.TabIndex = 4;
            labelRate.Text = "Рейтинг: ";
            // 
            // labelRealese
            // 
            labelRealese.AutoSize = true;
            labelRealese.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelRealese.Location = new Point(506, 220);
            labelRealese.Name = "labelRealese";
            labelRealese.Size = new Size(63, 21);
            labelRealese.TabIndex = 5;
            labelRealese.Text = "Realese";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelAge.Location = new Point(11, 355);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(69, 21);
            labelAge.TabIndex = 6;
            labelAge.Text = "Возраст:";
            // 
            // labelPowerOfPc
            // 
            labelPowerOfPc.AutoSize = true;
            labelPowerOfPc.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPowerOfPc.Location = new Point(11, 394);
            labelPowerOfPc.Name = "labelPowerOfPc";
            labelPowerOfPc.Size = new Size(89, 21);
            labelPowerOfPc.TabIndex = 7;
            labelPowerOfPc.Text = "Мощность:";
            // 
            // buttonImage
            // 
            buttonImage.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImage.Location = new Point(154, 158);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new Size(222, 36);
            buttonImage.TabIndex = 8;
            buttonImage.Text = "Поменять изображение";
            buttonImage.UseVisualStyleBackColor = true;
            buttonImage.Click += buttonImage_Click;
            // 
            // buttonIcon
            // 
            buttonIcon.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIcon.Location = new Point(154, 212);
            buttonIcon.Name = "buttonIcon";
            buttonIcon.Size = new Size(222, 36);
            buttonIcon.TabIndex = 9;
            buttonIcon.Text = "Поменять значок";
            buttonIcon.UseVisualStyleBackColor = true;
            buttonIcon.Click += buttonIcon_Click;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(12, 442);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(227, 43);
            buttonSave.TabIndex = 10;
            buttonSave.Text = "Сохранить изменения";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonReviews
            // 
            buttonReviews.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonReviews.Location = new Point(464, 442);
            buttonReviews.Name = "buttonReviews";
            buttonReviews.Size = new Size(227, 43);
            buttonReviews.TabIndex = 11;
            buttonReviews.Text = "Отзывы";
            buttonReviews.UseVisualStyleBackColor = true;
            // 
            // numericUpDownPrice
            // 
            numericUpDownPrice.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownPrice.Location = new Point(106, 309);
            numericUpDownPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownPrice.Name = "numericUpDownPrice";
            numericUpDownPrice.Size = new Size(133, 29);
            numericUpDownPrice.TabIndex = 16;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownAge.Location = new Point(106, 347);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(133, 29);
            numericUpDownAge.TabIndex = 17;
            // 
            // numericUpDownPower
            // 
            numericUpDownPower.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownPower.Location = new Point(106, 386);
            numericUpDownPower.Name = "numericUpDownPower";
            numericUpDownPower.Size = new Size(133, 29);
            numericUpDownPower.TabIndex = 18;
            // 
            // AuthorGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(703, 504);
            Controls.Add(numericUpDownPower);
            Controls.Add(numericUpDownAge);
            Controls.Add(numericUpDownPrice);
            Controls.Add(buttonReviews);
            Controls.Add(buttonSave);
            Controls.Add(buttonIcon);
            Controls.Add(buttonImage);
            Controls.Add(labelPowerOfPc);
            Controls.Add(labelAge);
            Controls.Add(labelRealese);
            Controls.Add(labelRate);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Controls.Add(pictureBoxIcon);
            Controls.Add(pictureBoxImage);
            Name = "AuthorGameForm";
            Text = "AuthorGameForm";
            Load += AuthorGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPower).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxImage;
        private PictureBox pictureBoxIcon;
        private Label labelName;
        private Label labelPrice;
        private Label labelRate;
        private Label labelRealese;
        private Label labelAge;
        private Label labelPowerOfPc;
        private Button buttonImage;
        private Button buttonIcon;
        private Button buttonSave;
        private Button buttonReviews;
        private NumericUpDown numericUpDownPrice;
        private NumericUpDown numericUpDownAge;
        private NumericUpDown numericUpDownPower;
    }
}