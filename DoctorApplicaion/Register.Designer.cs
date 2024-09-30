namespace DoctorSazi
{
    partial class Register
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
            label3 = new Label();
            label4 = new Label();
            first_name = new TextBox();
            label8 = new Label();
            last_name = new TextBox();
            age = new TextBox();
            file_number = new TextBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            button1 = new Button();
            doctor = new DomainUpDown();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 135);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 1;
            label1.Text = "First Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(651, 143);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 2;
            label2.Text = "Last Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 252);
            label3.Name = "label3";
            label3.Size = new Size(36, 20);
            label3.TabIndex = 3;
            label3.Text = "Age";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 259);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 4;
            label4.Text = "File Number";
            // 
            // first_name
            // 
            first_name.BackColor = SystemColors.Info;
            first_name.Location = new Point(179, 132);
            first_name.Name = "first_name";
            first_name.Size = new Size(417, 27);
            first_name.TabIndex = 8;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.AppWorkspace;
            label8.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label8.Location = new Point(275, 25);
            label8.Name = "label8";
            label8.Size = new Size(430, 46);
            label8.TabIndex = 9;
            label8.Text = "Patient Registration Form";
            // 
            // last_name
            // 
            last_name.BackColor = SystemColors.Info;
            last_name.Location = new Point(762, 136);
            last_name.Name = "last_name";
            last_name.Size = new Size(417, 27);
            last_name.TabIndex = 10;
            // 
            // age
            // 
            age.BackColor = SystemColors.Info;
            age.Location = new Point(179, 252);
            age.Name = "age";
            age.Size = new Size(136, 27);
            age.TabIndex = 11;
            // 
            // file_number
            // 
            file_number.BackColor = SystemColors.Info;
            file_number.Location = new Point(484, 259);
            file_number.Name = "file_number";
            file_number.Size = new Size(112, 27);
            file_number.TabIndex = 12;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(779, 260);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 24);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "Cash";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(779, 357);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(110, 24);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "Medical Aid";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(484, 596);
            button1.Name = "button1";
            button1.Size = new Size(273, 68);
            button1.TabIndex = 16;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // doctor
            // 
            doctor.Items.Add("Doctor 1");
            doctor.Items.Add("Doctor 2");
            doctor.Items.Add("Doctor 3");
            doctor.Items.Add("Doctor 4");
            doctor.Items.Add("Doctor 5");
            doctor.Location = new Point(179, 366);
            doctor.Name = "doctor";
            doctor.Size = new Size(424, 27);
            doctor.TabIndex = 17;
            doctor.Text = "Select--Doctor";
            doctor.SelectedItemChanged += domainUpDown1_SelectedItemChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 373);
            label5.Name = "label5";
            label5.Size = new Size(120, 20);
            label5.TabIndex = 18;
            label5.Text = "Doctor Selection";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1217, 727);
            Controls.Add(label5);
            Controls.Add(doctor);
            Controls.Add(button1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(file_number);
            Controls.Add(age);
            Controls.Add(last_name);
            Controls.Add(label8);
            Controls.Add(first_name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox first_name;
        private Label label8;
        private TextBox last_name;
        private TextBox age;
        private TextBox file_number;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Button button1;
        private DomainUpDown doctor;
        private Label label5;
    }
}