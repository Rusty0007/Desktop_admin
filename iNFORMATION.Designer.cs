namespace CAAP_ADMIN
{
    partial class iNFORMATION
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(iNFORMATION));
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            lblUsername = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtFirstname = new TextBox();
            txtLastname = new TextBox();
            txtOffice = new TextBox();
            txtEmailAddress = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(lblUsername);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(700, 180);
            panel1.TabIndex = 1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(666, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(31, 31);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(290, 67);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(361, 62);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "INFORMATION";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1183, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(42, 31);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 196);
            label1.Name = "label1";
            label1.Size = new Size(119, 28);
            label1.TabIndex = 9;
            label1.Text = "First Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 270);
            label4.Name = "label4";
            label4.Size = new Size(115, 28);
            label4.TabIndex = 12;
            label4.Text = "Last Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(349, 270);
            label5.Name = "label5";
            label5.Size = new Size(152, 28);
            label5.TabIndex = 13;
            label5.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(349, 196);
            label6.Name = "label6";
            label6.Size = new Size(72, 28);
            label6.TabIndex = 14;
            label6.Text = "Office";
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(16, 227);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(305, 27);
            txtFirstname.TabIndex = 15;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(16, 301);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(305, 27);
            txtLastname.TabIndex = 16;
            // 
            // txtOffice
            // 
            txtOffice.Location = new Point(349, 227);
            txtOffice.Name = "txtOffice";
            txtOffice.Size = new Size(305, 27);
            txtOffice.TabIndex = 18;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(349, 301);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(305, 27);
            txtEmailAddress.TabIndex = 20;
            // 
            // iNFORMATION
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 362);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtOffice);
            Controls.Add(txtLastname);
            Controls.Add(txtFirstname);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "iNFORMATION";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "iNFORMATION";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label lblUsername;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtFirstname;
        private TextBox txtLastname;
        private TextBox txtOffice;
        private TextBox txtEmailAddress;
        private PictureBox pictureBox3;
    }
}