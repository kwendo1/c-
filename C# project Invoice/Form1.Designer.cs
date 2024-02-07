namespace C__project_Invoice
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            subTotal = new TextBox();
            discountPercent = new TextBox();
            discountAmount = new TextBox();
            mnTax = new TextBox();
            mnTaxAmount = new TextBox();
            total = new TextBox();
            calculateButton = new Button();
            exitButton = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 68);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            label1.Click += this.label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 119);
            label2.Name = "label2";
            label2.Size = new Size(100, 15);
            label2.TabIndex = 1;
            label2.Text = "Discount Percent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(-2, 173);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 2;
            label3.Text = "Discount Amount:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 213);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 3;
            label4.Text = "MN Tax%:";
            label4.Click += this.label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(5, 254);
            label5.Name = "label5";
            label5.Size = new Size(97, 15);
            label5.TabIndex = 4;
            label5.Text = "MN Tax Amount:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 295);
            label6.Name = "label6";
            label6.Size = new Size(35, 15);
            label6.TabIndex = 5;
            label6.Text = "Total:";
            label6.Click += this.label6_Click;
            // 
            // subTotal
            // 
            subTotal.Location = new Point(108, 60);
            subTotal.Name = "subTotal";
            subTotal.Size = new Size(100, 23);
            subTotal.TabIndex = 1;
            subTotal.TextChanged += subTotal_TextChanged;
            // 
            // discountPercent
            // 
            discountPercent.Location = new Point(108, 111);
            discountPercent.Name = "discountPercent";
            discountPercent.Size = new Size(100, 23);
            discountPercent.TabIndex = 2;
            // 
            // discountAmount
            // 
            discountAmount.Enabled = false;
            discountAmount.Location = new Point(108, 165);
            discountAmount.Name = "discountAmount";
            discountAmount.Size = new Size(100, 23);
            discountAmount.TabIndex = 8;
            discountAmount.TabStop = false;
            // 
            // mnTax
            // 
            mnTax.Location = new Point(108, 205);
            mnTax.Name = "mnTax";
            mnTax.Size = new Size(100, 23);
            mnTax.TabIndex = 9;
            // 
            // mnTaxAmount
            // 
            mnTaxAmount.Enabled = false;
            mnTaxAmount.Location = new Point(108, 246);
            mnTaxAmount.Name = "mnTaxAmount";
            mnTaxAmount.Size = new Size(100, 23);
            mnTaxAmount.TabIndex = 10;
            mnTaxAmount.TabStop = false;
            // 
            // total
            // 
            total.Enabled = false;
            total.Location = new Point(108, 287);
            total.Name = "total";
            total.Size = new Size(100, 23);
            total.TabIndex = 11;
            total.TabStop = false;
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(75, 356);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 3;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += this.calculateButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(261, 356);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 6;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(237, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(295, 214);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            pictureBox1.Click += this.pictureBox1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(299, 290);
            label7.Name = "label7";
            label7.Size = new Size(196, 15);
            label7.TabIndex = 15;
            label7.Text = "Program Enhanced by Ayub Huruse";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 450);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(total);
            Controls.Add(mnTaxAmount);
            Controls.Add(mnTax);
            Controls.Add(discountAmount);
            Controls.Add(discountPercent);
            Controls.Add(subTotal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Invoice Total";
            Load += this.Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox subTotal;
        private TextBox discountPercent;
        private TextBox discountAmount;
        private TextBox mnTax;
        private TextBox mnTaxAmount;
        private TextBox total;
        private Button calculateButton;
        private Button exitButton;
        private PictureBox pictureBox1;
        private Label label7;
    }
}