namespace UltraGamesStoreNoSteamNONONO
{
    partial class InfoAboutUserForm
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonImage = new Button();
            buttonSave = new Button();
            numericUpDownAge = new NumericUpDown();
            numericUpDownPower = new NumericUpDown();
            myPictureBox1 = new MyPictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPower).BeginInit();
            ((System.ComponentModel.ISupportInitialize)myPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(56, 158);
            label1.Name = "label1";
            label1.Size = new Size(145, 21);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(131, 205);
            label3.Name = "label3";
            label3.Size = new Size(70, 21);
            label3.TabIndex = 2;
            label3.Text = "Возраст ";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(30, 252);
            label4.Name = "label4";
            label4.Size = new Size(171, 21);
            label4.TabIndex = 3;
            label4.Text = "Мощность комьютера";
            // 
            // buttonImage
            // 
            buttonImage.Anchor = AnchorStyles.None;
            buttonImage.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonImage.Location = new Point(223, 40);
            buttonImage.Name = "buttonImage";
            buttonImage.Size = new Size(96, 72);
            buttonImage.TabIndex = 9;
            buttonImage.Text = "Поменять аватарку";
            buttonImage.UseVisualStyleBackColor = true;
            buttonImage.Click += buttonImage_Click;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.None;
            buttonSave.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(30, 297);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(278, 36);
            buttonSave.TabIndex = 12;
            buttonSave.Text = "Cохранить изменения";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(223, 205);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(120, 23);
            numericUpDownAge.TabIndex = 13;
            // 
            // numericUpDownPower
            // 
            numericUpDownPower.Location = new Point(223, 250);
            numericUpDownPower.Name = "numericUpDownPower";
            numericUpDownPower.Size = new Size(120, 23);
            numericUpDownPower.TabIndex = 14;
            // 
            // myPictureBox1
            // 
            myPictureBox1.Image = null;
            myPictureBox1.Location = new Point(56, 31);
            myPictureBox1.Name = "myPictureBox1";
            myPictureBox1.Size = new Size(145, 91);
            myPictureBox1.TabIndex = 15;
            myPictureBox1.TabStop = false;
            // 
            // InfoAboutUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(363, 367);
            Controls.Add(myPictureBox1);
            Controls.Add(numericUpDownPower);
            Controls.Add(numericUpDownAge);
            Controls.Add(buttonSave);
            Controls.Add(buttonImage);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "InfoAboutUserForm";
            Text = "InfoAboutUserForm";
            Load += InfoAboutUserForm_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPower).EndInit();
            ((System.ComponentModel.ISupportInitialize)myPictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Button buttonImage;
        private Button button2;
        private Button button3;
        private Button buttonSave;
        private NumericUpDown numericUpDownAge;
        private NumericUpDown numericUpDownPower;
        private MyPictureBox myPictureBox1;
    }
}