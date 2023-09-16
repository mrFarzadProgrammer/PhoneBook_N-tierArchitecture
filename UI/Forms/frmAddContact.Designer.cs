namespace UI.Forms
{
    partial class frmAddContact
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
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            txtName = new System.Windows.Forms.TextBox();
            txtLastName = new System.Windows.Forms.TextBox();
            txtCompany = new System.Windows.Forms.TextBox();
            txtPhoneNumber = new System.Windows.Forms.TextBox();
            rtxtDescription = new System.Windows.Forms.RichTextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Yellow;
            label1.Location = new System.Drawing.Point(96, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(282, 33);
            label1.TabIndex = 0;
            label1.Text = "افزودن مخاطب  جدید";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(387, 137);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(30, 18);
            label2.TabIndex = 0;
            label2.Text = "نام:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(387, 175);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(93, 18);
            label3.TabIndex = 0;
            label3.Text = "نام خانوادگی:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(387, 230);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(55, 18);
            label4.TabIndex = 0;
            label4.Text = "شرکت:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = System.Drawing.Color.White;
            label5.Location = new System.Drawing.Point(387, 279);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(93, 18);
            label5.TabIndex = 0;
            label5.Text = "شماره تماس:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(387, 322);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(67, 18);
            label6.TabIndex = 0;
            label6.Text = "توضیحات:";
            // 
            // txtName
            // 
            txtName.Location = new System.Drawing.Point(96, 134);
            txtName.Name = "txtName";
            txtName.Size = new System.Drawing.Size(256, 25);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new System.Drawing.Point(96, 176);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new System.Drawing.Size(256, 25);
            txtLastName.TabIndex = 1;
            // 
            // txtCompany
            // 
            txtCompany.Location = new System.Drawing.Point(96, 223);
            txtCompany.Name = "txtCompany";
            txtCompany.Size = new System.Drawing.Size(256, 25);
            txtCompany.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new System.Drawing.Point(96, 272);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new System.Drawing.Size(256, 25);
            txtPhoneNumber.TabIndex = 1;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new System.Drawing.Point(96, 319);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new System.Drawing.Size(256, 96);
            rtxtDescription.TabIndex = 2;
            rtxtDescription.Text = "";
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(210, 439);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(142, 23);
            button1.TabIndex = 3;
            button1.Text = "افزودن مخاطب جدید";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(96, 439);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(108, 23);
            button2.TabIndex = 4;
            button2.Text = "بازگشت";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // frmAddContact
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.Gray;
            ClientSize = new System.Drawing.Size(507, 540);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(rtxtDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCompany);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.Gray;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmAddContact";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "frmAddContact";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.RichTextBox rtxtDescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}