namespace TAX_NX_Calculator
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
            groupBox = new GroupBox();
            gtotal = new Label();
            label12 = new Label();
            label13 = new Label();
            label11 = new Label();
            rateBox = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            button2 = new Button();
            button1 = new Button();
            taxBtn = new Button();
            resetBtn = new Button();
            sumResult = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label1 = new Label();
            Title = new Label();
            label2 = new Label();
            label9 = new Label();
            label10 = new Label();
            pictureBox1 = new PictureBox();
            groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(gtotal);
            groupBox.Controls.Add(label12);
            groupBox.Controls.Add(label13);
            groupBox.Controls.Add(label11);
            groupBox.Controls.Add(rateBox);
            groupBox.Controls.Add(label7);
            groupBox.Controls.Add(label8);
            groupBox.Controls.Add(button2);
            groupBox.Controls.Add(button1);
            groupBox.Controls.Add(taxBtn);
            groupBox.Controls.Add(resetBtn);
            groupBox.Controls.Add(sumResult);
            groupBox.Controls.Add(label4);
            groupBox.Controls.Add(label5);
            groupBox.Controls.Add(textBox1);
            groupBox.Controls.Add(label3);
            groupBox.Controls.Add(label1);
            groupBox.Location = new Point(12, 54);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(283, 212);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "VAT / NET Calculator";
            groupBox.Enter += groupBox1_Enter;
            // 
            // gtotal
            // 
            gtotal.AutoSize = true;
            gtotal.Location = new Point(82, 128);
            gtotal.Name = "gtotal";
            gtotal.Size = new Size(19, 15);
            gtotal.TabIndex = 16;
            gtotal.Text = "....";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(71, 128);
            label12.Name = "label12";
            label12.Size = new Size(10, 15);
            label12.TabIndex = 15;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(6, 128);
            label13.Name = "label13";
            label13.Size = new Size(67, 15);
            label13.TabIndex = 14;
            label13.Text = "Grand Total";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(155, 67);
            label11.Name = "label11";
            label11.Size = new Size(17, 15);
            label11.TabIndex = 13;
            label11.Text = "%";
            // 
            // rateBox
            // 
            rateBox.FormattingEnabled = true;
            rateBox.Items.AddRange(new object[] { "13", "5", "28" });
            rateBox.Location = new Point(82, 64);
            rateBox.Name = "rateBox";
            rateBox.Size = new Size(72, 23);
            rateBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 67);
            label7.Name = "label7";
            label7.Size = new Size(10, 15);
            label7.TabIndex = 11;
            label7.Text = ":";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 67);
            label8.Name = "label8";
            label8.Size = new Size(30, 15);
            label8.TabIndex = 10;
            label8.Text = "Rate";
            // 
            // button2
            // 
            button2.Location = new Point(196, 181);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 9;
            button2.Text = "QUIT";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(178, 152);
            button1.Name = "button1";
            button1.Size = new Size(93, 23);
            button1.TabIndex = 8;
            button1.Text = "Calculate NET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // taxBtn
            // 
            taxBtn.Location = new Point(79, 152);
            taxBtn.Name = "taxBtn";
            taxBtn.Size = new Size(93, 23);
            taxBtn.TabIndex = 7;
            taxBtn.Text = "Calculate TAX";
            taxBtn.UseVisualStyleBackColor = true;
            taxBtn.Click += taxBtn_Click;
            // 
            // resetBtn
            // 
            resetBtn.Location = new Point(196, 63);
            resetBtn.Name = "resetBtn";
            resetBtn.Size = new Size(75, 23);
            resetBtn.TabIndex = 6;
            resetBtn.Text = "Reset";
            resetBtn.UseVisualStyleBackColor = true;
            resetBtn.Click += resetBtn_Click;
            // 
            // sumResult
            // 
            sumResult.AutoSize = true;
            sumResult.Location = new Point(82, 102);
            sumResult.Name = "sumResult";
            sumResult.Size = new Size(19, 15);
            sumResult.TabIndex = 5;
            sumResult.Text = "....";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(71, 102);
            label4.Name = "label4";
            label4.Size = new Size(10, 15);
            label4.TabIndex = 4;
            label4.Text = ":";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 102);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 3;
            label5.Text = "Result";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(82, 35);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Enter Amount";
            textBox1.Size = new Size(189, 23);
            textBox1.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(71, 38);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 1;
            label3.Text = ":";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Amount";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Arial Rounded MT Bold", 13F);
            Title.Location = new Point(33, 18);
            Title.Name = "Title";
            Title.Size = new Size(262, 21);
            Title.TabIndex = 1;
            Title.Text = "VAT / Net Amount Calculator";
            Title.Click += Title_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 37);
            label2.Name = "label2";
            label2.Size = new Size(0, 28);
            label2.TabIndex = 2;
            label2.Click += label2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(75, 269);
            label9.Name = "label9";
            label9.Size = new Size(163, 18);
            label9.TabIndex = 3;
            label9.Text = "Developed by Tularam";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(102, 287);
            label10.Name = "label10";
            label10.Size = new Size(100, 15);
            label10.TabIndex = 4;
            label10.Text = "https://trk.com.np";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(14, 19);
            pictureBox1.MaximumSize = new Size(20, 20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(20, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 312);
            Controls.Add(pictureBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label2);
            Controls.Add(Title);
            Controls.Add(groupBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "TAX / Net Price Calculator";
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox;
        private Label label1;
        private Label Title;
        private Label label2;
        private TextBox textBox1;
        private Label label3;
        private Label label7;
        private Label label8;
        private Button button2;
        private Button button1;
        private Button taxBtn;
        private Button resetBtn;
        private Label sumResult;
        private Label label4;
        private Label label5;
        private ComboBox rateBox;
        private Label label9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox1;
        private Label gtotal;
        private Label label12;
        private Label label13;
    }
}
