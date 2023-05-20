
namespace WindowsFormsApp1
{
    partial class Form9
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
            this.DEPT = new System.Windows.Forms.TextBox();
            this.PHONE = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.TextBox();
            this.NAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DEPT
            // 
            this.DEPT.Location = new System.Drawing.Point(172, 242);
            this.DEPT.Name = "DEPT";
            this.DEPT.Size = new System.Drawing.Size(100, 20);
            this.DEPT.TabIndex = 25;
            // 
            // PHONE
            // 
            this.PHONE.Location = new System.Drawing.Point(172, 216);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(100, 20);
            this.PHONE.TabIndex = 24;
            // 
            // EMAIL
            // 
            this.EMAIL.Location = new System.Drawing.Point(172, 190);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(100, 20);
            this.EMAIL.TabIndex = 23;
            // 
            // NAME
            // 
            this.NAME.Location = new System.Drawing.Point(172, 164);
            this.NAME.Name = "NAME";
            this.NAME.Size = new System.Drawing.Size(100, 20);
            this.NAME.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 117);
            this.label4.TabIndex = 21;
            this.label4.Text = "ID\r\n\r\nName\r\n\r\nEmail\r\n\r\nPhone no.\r\n\r\nDept.";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(172, 138);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 20);
            this.ID.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "STUDENTS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(109, 301);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 18;
            this.button2.Text = "Add New Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 26;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DEPT);
            this.Controls.Add(this.PHONE);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.NAME);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "Form9";
            this.Text = "Add new student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DEPT;
        private System.Windows.Forms.TextBox PHONE;
        private System.Windows.Forms.TextBox EMAIL;
        private System.Windows.Forms.TextBox NAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}