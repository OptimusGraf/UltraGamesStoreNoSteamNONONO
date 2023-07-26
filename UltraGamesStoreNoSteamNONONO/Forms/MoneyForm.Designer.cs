namespace UltraGamesStoreNoSteamNONONO
{
    partial class MoneyForm
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
            label2 = new Label();
            numericUpDownMoney = new NumericUpDown();
            buttonAddMoney = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMoney).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(47, 42);
            label1.Name = "label1";
            label1.Size = new Size(68, 30);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(47, 111);
            label2.Name = "label2";
            label2.Size = new Size(161, 21);
            label2.TabIndex = 1;
            label2.Text = "Пополнить Ваш счет:";
            // 
            // numericUpDownMoney
            // 
            numericUpDownMoney.Anchor = AnchorStyles.None;
            numericUpDownMoney.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            numericUpDownMoney.Location = new Point(227, 109);
            numericUpDownMoney.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownMoney.Name = "numericUpDownMoney";
            numericUpDownMoney.Size = new Size(120, 29);
            numericUpDownMoney.TabIndex = 2;
            // 
            // buttonAddMoney
            // 
            buttonAddMoney.Anchor = AnchorStyles.None;
            buttonAddMoney.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAddMoney.Location = new Point(369, 98);
            buttonAddMoney.Name = "buttonAddMoney";
            buttonAddMoney.Size = new Size(98, 47);
            buttonAddMoney.TabIndex = 3;
            buttonAddMoney.Text = "Пополнить";
            buttonAddMoney.UseVisualStyleBackColor = true;
            buttonAddMoney.Click += buttonAddMoney_Click;
            // 
            // MoneyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 215);
            Controls.Add(buttonAddMoney);
            Controls.Add(numericUpDownMoney);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MoneyForm";
            Text = "MoneyForm";
            ((System.ComponentModel.ISupportInitialize)numericUpDownMoney).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private NumericUpDown numericUpDownMoney;
        private Button buttonAddMoney;
    }
}