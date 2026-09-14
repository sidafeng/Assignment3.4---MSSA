namespace Assignment3._4
{
    partial class AddForm
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
            rbtnCoffee = new RadioButton();
            rbtnTea = new RadioButton();
            listBox = new ListBox();
            btnNext = new Button();
            btnBack = new Button();
            ckListBox = new CheckedListBox();
            lblSize = new Label();
            rbtnLarge = new RadioButton();
            rbtnSmall = new RadioButton();
            panel1 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // rbtnCoffee
            // 
            rbtnCoffee.AutoSize = true;
            rbtnCoffee.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnCoffee.Location = new Point(14, 24);
            rbtnCoffee.Name = "rbtnCoffee";
            rbtnCoffee.Size = new System.Drawing.Size(104, 34);
            rbtnCoffee.TabIndex = 0;
            rbtnCoffee.TabStop = true;
            rbtnCoffee.Text = "Coffee";
            rbtnCoffee.UseVisualStyleBackColor = true;
            rbtnCoffee.CheckedChanged += rbtnCoffee_CheckedChanged;
            // 
            // rbtnTea
            // 
            rbtnTea.AutoSize = true;
            rbtnTea.Font = new Font("Modern No. 20", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbtnTea.Location = new Point(206, 24);
            rbtnTea.Name = "rbtnTea";
            rbtnTea.Size = new System.Drawing.Size(75, 34);
            rbtnTea.TabIndex = 1;
            rbtnTea.TabStop = true;
            rbtnTea.Text = "Tea";
            rbtnTea.UseVisualStyleBackColor = true;
            rbtnTea.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.Location = new Point(143, 112);
            listBox.Name = "listBox";
            listBox.Size = new System.Drawing.Size(191, 224);
            listBox.TabIndex = 2;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(290, 358);
            btnNext.Name = "btnNext";
            btnNext.Size = new System.Drawing.Size(94, 29);
            btnNext.TabIndex = 3;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(84, 358);
            btnBack.Name = "btnBack";
            btnBack.Size = new System.Drawing.Size(94, 29);
            btnBack.TabIndex = 4;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ckListBox
            // 
            ckListBox.FormattingEnabled = true;
            ckListBox.Location = new Point(143, 112);
            ckListBox.Name = "ckListBox";
            ckListBox.Size = new System.Drawing.Size(191, 114);
            ckListBox.TabIndex = 5;
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(164, 253);
            lblSize.Name = "lblSize";
            lblSize.Size = new System.Drawing.Size(143, 20);
            lblSize.TabIndex = 8;
            lblSize.Text = "Please choose a size";
            // 
            // rbtnLarge
            // 
            rbtnLarge.AutoSize = true;
            rbtnLarge.Location = new Point(132, 14);
            rbtnLarge.Name = "rbtnLarge";
            rbtnLarge.Size = new System.Drawing.Size(37, 24);
            rbtnLarge.TabIndex = 7;
            rbtnLarge.TabStop = true;
            rbtnLarge.Text = "L";
            rbtnLarge.UseVisualStyleBackColor = true;
            // 
            // rbtnSmall
            // 
            rbtnSmall.AutoSize = true;
            rbtnSmall.Location = new Point(21, 14);
            rbtnSmall.Name = "rbtnSmall";
            rbtnSmall.Size = new System.Drawing.Size(38, 24);
            rbtnSmall.TabIndex = 6;
            rbtnSmall.TabStop = true;
            rbtnSmall.Text = "S";
            rbtnSmall.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(rbtnLarge);
            panel1.Controls.Add(rbtnSmall);
            panel1.Location = new Point(143, 283);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(191, 53);
            panel1.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbtnCoffee);
            panel2.Controls.Add(rbtnTea);
            panel2.Location = new Point(84, 35);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(300, 71);
            panel2.TabIndex = 11;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblSize);
            Controls.Add(ckListBox);
            Controls.Add(btnBack);
            Controls.Add(btnNext);
            Controls.Add(listBox);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddForm";
            Load += AddForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbtnCoffee;
        private RadioButton rbtnTea;
        private ListBox listBox;
        private Button btnNext;
        private Button btnBack;
        private CheckedListBox ckListBox;
        private Label lblSize;
        private RadioButton rbtnLarge;
        private RadioButton rbtnSmall;
        private Panel panel1;
        private Panel panel2;
    }
}