namespace UI.Forms
{
    partial class frmMain
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            txtSearchKey = new System.Windows.Forms.TextBox();
            btnSearch = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            deleteContact = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            dataGridView1.Location = new System.Drawing.Point(0, 151);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(541, 389);
            dataGridView1.TabIndex = 0;
            // 
            // txtSearchKey
            // 
            txtSearchKey.Location = new System.Drawing.Point(287, 55);
            txtSearchKey.Name = "txtSearchKey";
            txtSearchKey.Size = new System.Drawing.Size(242, 25);
            txtSearchKey.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.Location = new System.Drawing.Point(287, 99);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new System.Drawing.Size(242, 23);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "جستجو";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(365, 24);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(86, 18);
            label1.TabIndex = 3;
            label1.Text = "جستجو کنید";
            // 
            // deleteContact
            // 
            deleteContact.Location = new System.Drawing.Point(12, 99);
            deleteContact.Name = "deleteContact";
            deleteContact.Size = new System.Drawing.Size(244, 23);
            deleteContact.TabIndex = 4;
            deleteContact.Text = "حذف";
            deleteContact.UseVisualStyleBackColor = true;
            deleteContact.Click += deleteContact_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(541, 540);
            Controls.Add(deleteContact);
            Controls.Add(label1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearchKey);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            Name = "frmMain";
            RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "frmMain";
            Load += frmMain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchKey;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteContact;
    }
}