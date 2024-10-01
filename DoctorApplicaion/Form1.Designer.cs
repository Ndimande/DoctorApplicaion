namespace DoctorApplicaion
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.is_cash = new System.Windows.Forms.CheckBox();
            this.is_medical = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.file_number = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.last_name = new System.Windows.Forms.TextBox();
            this.first_name = new System.Windows.Forms.TextBox();
            this.doctor = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.button1.Location = new System.Drawing.Point(411, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "SUBMIT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Age";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(428, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "File Number";
            // 
            // is_cash
            // 
            this.is_cash.AutoSize = true;
            this.is_cash.BackColor = System.Drawing.SystemColors.Info;
            this.is_cash.Location = new System.Drawing.Point(708, 215);
            this.is_cash.Name = "is_cash";
            this.is_cash.Size = new System.Drawing.Size(60, 20);
            this.is_cash.TabIndex = 5;
            this.is_cash.Text = "Cash";
            this.is_cash.UseVisualStyleBackColor = false;
            // 
            // is_medical
            // 
            this.is_medical.AutoSize = true;
            this.is_medical.BackColor = System.Drawing.SystemColors.Info;
            this.is_medical.Location = new System.Drawing.Point(536, 215);
            this.is_medical.Name = "is_medical";
            this.is_medical.Size = new System.Drawing.Size(100, 20);
            this.is_medical.TabIndex = 6;
            this.is_medical.Text = "Medical Aid";
            this.is_medical.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.file_number);
            this.panel1.Controls.Add(this.age);
            this.panel1.Controls.Add(this.last_name);
            this.panel1.Controls.Add(this.first_name);
            this.panel1.Controls.Add(this.doctor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.is_medical);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.is_cash);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 338);
            this.panel1.TabIndex = 7;
            // 
            // file_number
            // 
            this.file_number.BackColor = System.Drawing.SystemColors.Info;
            this.file_number.Location = new System.Drawing.Point(536, 111);
            this.file_number.Name = "file_number";
            this.file_number.Size = new System.Drawing.Size(320, 22);
            this.file_number.TabIndex = 11;
            // 
            // age
            // 
            this.age.BackColor = System.Drawing.SystemColors.Info;
            this.age.Location = new System.Drawing.Point(81, 114);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(320, 22);
            this.age.TabIndex = 10;
            // 
            // last_name
            // 
            this.last_name.BackColor = System.Drawing.SystemColors.Info;
            this.last_name.Location = new System.Drawing.Point(536, 26);
            this.last_name.Name = "last_name";
            this.last_name.Size = new System.Drawing.Size(320, 22);
            this.last_name.TabIndex = 9;
            // 
            // first_name
            // 
            this.first_name.BackColor = System.Drawing.SystemColors.Info;
            this.first_name.Location = new System.Drawing.Point(81, 26);
            this.first_name.Name = "first_name";
            this.first_name.Size = new System.Drawing.Size(320, 22);
            this.first_name.TabIndex = 8;
            // 
            // doctor
            // 
            this.doctor.BackColor = System.Drawing.SystemColors.Info;
            this.doctor.Items.Add("Doctor 1");
            this.doctor.Items.Add("Doctor 2");
            this.doctor.Items.Add("Doctor 3");
            this.doctor.Items.Add("Doctor 4");
            this.doctor.Items.Add("Doctor 5");
            this.doctor.Location = new System.Drawing.Point(81, 213);
            this.doctor.Name = "doctor";
            this.doctor.Size = new System.Drawing.Size(320, 22);
            this.doctor.TabIndex = 7;
            this.doctor.Text = "Select Doctor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(263, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(362, 43);
            this.label5.TabIndex = 8;
            this.label5.Text = "Register Patient Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 99);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(955, 533);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox is_cash;
        private System.Windows.Forms.CheckBox is_medical;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DomainUpDown doctor;
        private System.Windows.Forms.TextBox file_number;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox last_name;
        private System.Windows.Forms.TextBox first_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

