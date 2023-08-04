namespace UltraGamesStoreNoSteamNONONO
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
            labelName = new Label();
            labelPrice = new Label();
            labelAge = new Label();
            labelPowerOfPc = new Label();
            buttonImage = new Button();
            buttonIcon = new Button();
            buttonSave = new Button();
            numericUpDownPrice = new NumericUpDown();
            numericUpDownAge = new NumericUpDown();
            numericUpDownPower = new NumericUpDown();
            myPictureBoxImage = new MyPictureBox();
            myPictureBoxIcon = new MyPictureBox();
            flowLayoutPanelForInfo = new FlowLayoutPanel();
            textBoxName = new TextBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myPictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myPictureBoxIcon).BeginInit();
            SuspendLayout();
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
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
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
            // myPictureBoxImage
            // 
            myPictureBoxImage.Dock = DockStyle.Top;
            myPictureBoxImage.Image = null;
            myPictureBoxImage.Location = new Point(0, 0);
            myPictureBoxImage.Name = "myPictureBoxImage";
            myPictureBoxImage.Size = new Size(703, 143);
            myPictureBoxImage.TabIndex = 19;
            myPictureBoxImage.TabStop = false;
            // 
            // myPictureBoxIcon
            // 
            myPictureBoxIcon.Anchor = AnchorStyles.None;
            myPictureBoxIcon.Image = null;
            myPictureBoxIcon.Location = new Point(11, 158);
            myPictureBoxIcon.Name = "myPictureBoxIcon";
            myPictureBoxIcon.Size = new Size(110, 90);
            myPictureBoxIcon.TabIndex = 20;
            myPictureBoxIcon.TabStop = false;
            // 
            // flowLayoutPanelForInfo
            // 
            flowLayoutPanelForInfo.Location = new Point(464, 158);
            flowLayoutPanelForInfo.Name = "flowLayoutPanelForInfo";
            flowLayoutPanelForInfo.Size = new Size(200, 90);
            flowLayoutPanelForInfo.TabIndex = 21;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(106, 279);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(133, 23);
            textBoxName.TabIndex = 22;
            // 
            // AuthorGameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(703, 504);
            Controls.Add(textBoxName);
            Controls.Add(flowLayoutPanelForInfo);
            Controls.Add(myPictureBoxIcon);
            Controls.Add(myPictureBoxImage);
            Controls.Add(numericUpDownPower);
            Controls.Add(numericUpDownAge);
            Controls.Add(numericUpDownPrice);
            Controls.Add(buttonSave);
            Controls.Add(buttonIcon);
            Controls.Add(buttonImage);
            Controls.Add(labelPowerOfPc);
            Controls.Add(labelAge);
            Controls.Add(labelPrice);
            Controls.Add(labelName);
            Name = "AuthorGameForm";
            Text = "AuthorGameForm";
            Load += AuthorGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)myPictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)myPictureBoxIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        protected Label labelName;
        protected Label labelPrice;
        protected Label labelAge;
        protected Label labelPowerOfPc;
        protected Button buttonImage;
        protected Button buttonIcon;
        protected Button buttonSave;
        protected NumericUpDown numericUpDownPrice;
        protected NumericUpDown numericUpDownAge;
        protected NumericUpDown numericUpDownPower;
        protected MyPictureBox myPictureBoxImage;
        protected MyPictureBox myPictureBoxIcon;
        protected FlowLayoutPanel flowLayoutPanelForInfo;
        protected TextBox textBoxName;
    }
}