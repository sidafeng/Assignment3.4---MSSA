namespace Assignment3._4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblHeading = new Label();
            btnCreateOrder = new Button();
            btnDelOrder = new Button();
            orderGrid1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)orderGrid1).BeginInit();
            SuspendLayout();
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.BackColor = Color.Transparent;
            lblHeading.BorderStyle = BorderStyle.Fixed3D;
            lblHeading.Font = new Font("Rockwell Extra Bold", 25F, FontStyle.Bold | FontStyle.Underline);
            lblHeading.ForeColor = Color.FromArgb(255, 192, 128);
            lblHeading.Location = new Point(292, 56);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new System.Drawing.Size(445, 52);
            lblHeading.TabIndex = 0;
            lblHeading.Text = "Beverage Orders";
            lblHeading.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnCreateOrder
            // 
            btnCreateOrder.Location = new Point(268, 452);
            btnCreateOrder.Name = "btnCreateOrder";
            btnCreateOrder.Size = new System.Drawing.Size(145, 58);
            btnCreateOrder.TabIndex = 2;
            btnCreateOrder.Text = "Create Order";
            btnCreateOrder.UseVisualStyleBackColor = true;
            btnCreateOrder.Click += btnCreateOrder_Click;
            // 
            // btnDelOrder
            // 
            btnDelOrder.Location = new Point(700, 452);
            btnDelOrder.Name = "btnDelOrder";
            btnDelOrder.Size = new System.Drawing.Size(145, 58);
            btnDelOrder.TabIndex = 3;
            btnDelOrder.Text = "Delete Order";
            btnDelOrder.UseVisualStyleBackColor = true;
            btnDelOrder.Click += btnDelOrder_Click;
            // 
            // orderGrid1
            // 
            orderGrid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderGrid1.Location = new Point(12, 142);
            orderGrid1.Name = "orderGrid1";
            orderGrid1.RowHeadersWidth = 51;
            orderGrid1.Size = new System.Drawing.Size(1004, 293);
            orderGrid1.TabIndex = 4;
            orderGrid1.CellClick += orderGrid1_CellClick;
            orderGrid1.AllowUserToAddRows = false;

            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new System.Drawing.Size(1028, 700);
            Controls.Add(orderGrid1);
            Controls.Add(btnDelOrder);
            Controls.Add(btnCreateOrder);
            Controls.Add(lblHeading);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)orderGrid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeading;
        private DataGridView orderGrid;
        private Button btnCreateOrder;
        private Button btnDelOrder;
        private DataGridView orderGrid1;
    }
}
