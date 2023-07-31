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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxForMainImage).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxForMainImage
            // 
            pictureBoxForMainImage.Location = new Point(0, 0);
            pictureBoxForMainImage.Name = "pictureBoxForMainImage";
            pictureBoxForMainImage.Size = new Size(768, 143);
            pictureBoxForMainImage.TabIndex = 0;
            pictureBoxForMainImage.TabStop = false;
            // 
            // panelForGameView
            // 
            panelForGameView.Location = new Point(0, 139);
            panelForGameView.Name = "panelForGameView";
            panelForGameView.Size = new Size(768, 98);
            panelForGameView.TabIndex = 1;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(740, 3);
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 235);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(768, 381);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(labelAge);
            panel1.Controls.Add(labelPower);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(762, 100);
            panel1.TabIndex = 0;
            // 
            // GameTabControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(buttonExit);
            Controls.Add(panelForGameView);
            Controls.Add(pictureBoxForMainImage);
            Name = "GameTabControl";
            Size = new Size(768, 616);
            ((System.ComponentModel.ISupportInitialize)pictureBoxForMainImage).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxForMainImage;
        private Panel panelForGameView;
        private Button buttonExit;
        private Label labelPower;
        private Label labelAge;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
    }
}
