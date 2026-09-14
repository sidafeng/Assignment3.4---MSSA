namespace Assignment3._4
{
    partial class PersonalInfoForm
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
            lblName = new Label();
            lblPhone = new Label();
            lblPay = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            rbtnCash = new RadioButton();
            rbtnCard = new RadioButton();
            btnPaySubmit = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(78, 79);
            lblName.Name = "lblName";
            lblName.Size = new System.Drawing.Size(49, 20);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Location = new Point(78, 162);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new System.Drawing.Size(108, 20);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone Number";
            // 
            // lblPay
            // 
            lblPay.AutoSize = true;
            lblPay.Location = new Point(78, 279);
            lblPay.Name = "lblPay";
            lblPay.Size = new System.Drawing.Size(100, 20);
            lblPay.TabIndex = 2;
            lblPay.Text = "Payment Type";
            // 
            // txtName
            // 
            txtName.Location = new Point(234, 76);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(125, 27);
            txtName.TabIndex = 3;
            txtName.Validating += txtName_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(234, 162);
            txtPhone.Name = "txtPhone";
            txtPhone.PlaceholderText = "123-345-6789";
            txtPhone.Size = new System.Drawing.Size(125, 27);
            txtPhone.TabIndex = 4;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // rbtnCash
            // 
            rbtnCash.AutoSize = true;
            rbtnCash.Location = new Point(234, 254);
            rbtnCash.Name = "rbtnCash";
            rbtnCash.Size = new System.Drawing.Size(61, 24);
            rbtnCash.TabIndex = 5;
            rbtnCash.TabStop = true;
            rbtnCash.Text = "Cash";
            rbtnCash.UseVisualStyleBackColor = true;
            // 
            // rbtnCard
            // 
            rbtnCard.AutoSize = true;
            rbtnCard.Location = new Point(234, 307);
            rbtnCard.Name = "rbtnCard";
            rbtnCard.Size = new System.Drawing.Size(105, 24);
            rbtnCard.TabIndex = 6;
            rbtnCard.TabStop = true;
            rbtnCard.Text = "Credit Card";
            rbtnCard.UseVisualStyleBackColor = true;
            // 
            // btnPaySubmit
            // 
            btnPaySubmit.Location = new Point(153, 371);
            btnPaySubmit.Name = "btnPaySubmit";
            btnPaySubmit.Size = new System.Drawing.Size(157, 29);
            btnPaySubmit.TabIndex = 7;
            btnPaySubmit.Text = "Confirm Payment";
            btnPaySubmit.UseVisualStyleBackColor = true;
            btnPaySubmit.Click += btnPaySubmit_Click;
            // 
            // PersonalInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(480, 450);
            Controls.Add(btnPaySubmit);
            Controls.Add(rbtnCard);
            Controls.Add(rbtnCash);
            Controls.Add(txtPhone);
            Controls.Add(txtName);
            Controls.Add(lblPay);
            Controls.Add(lblPhone);
            Controls.Add(lblName);
            Name = "PersonalInfoForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "PersonalInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblPhone;
        private Label lblPay;
        private TextBox txtName;
        private TextBox txtPhone;
        private RadioButton rbtnCash;
        private RadioButton rbtnCard;
        private Button btnPaySubmit;
    }
}