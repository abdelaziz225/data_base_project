
namespace WindowsFormsApp1
{
    partial class Form13
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
            this.button1 = new System.Windows.Forms.Button();
            this.DEPT = new System.Windows.Forms.TextBox();
            this.S_PHONE_NO = new System.Windows.Forms.TextBox();
            this.S_EMAIL = new System.Windows.Forms.TextBox();
            this.S_NAME = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.S_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 35;
            this.button1.Text = "< Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DEPT
            // 
            this.DEPT.Location = new System.Drawing.Point(169, 270);
            this.DEPT.Name = "DEPT";
            this.DEPT.Size = new System.Drawing.Size(118, 20);
            this.DEPT.TabIndex = 34;
            // 
            // S_PHONE_NO
            // 
            this.S_PHONE_NO.Location = new System.Drawing.Point(169, 244);
            this.S_PHONE_NO.Name = "S_PHONE_NO";
            this.S_PHONE_NO.Size = new System.Drawing.Size(118, 20);
            this.S_PHONE_NO.TabIndex = 33;
            // 
            // S_EMAIL
            // 
            this.S_EMAIL.Location = new System.Drawing.Point(169, 218);
            this.S_EMAIL.Name = "S_EMAIL";
            this.S_EMAIL.Size = new System.Drawing.Size(118, 20);
            this.S_EMAIL.TabIndex = 32;
            // 
            // S_NAME
            // 
            this.S_NAME.Location = new System.Drawing.Point(169, 192);
            this.S_NAME.Name = "S_NAME";
            this.S_NAME.Size = new System.Drawing.Size(118, 20);
            this.S_NAME.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(94, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 143);
            this.label4.TabIndex = 30;
            this.label4.Text = "CURRENT ID\r\n\r\n                       NEW \r\n  \r\nName\r\n\r\nEmail\r\n\r\nPhone no.\r\n\r\nDept" +
    ".";
            // 
            // S_ID
            // 
            this.S_ID.Location = new System.Drawing.Point(169, 139);
            this.S_ID.Name = "S_ID";
            this.S_ID.Size = new System.Drawing.Size(118, 20);
            this.S_ID.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 28;
            this.label2.Text = "STUDENTS";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(110, 308);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 23);
            this.button2.TabIndex = 27;
            this.button2.Text = "Update Student";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DEPT);
            this.Controls.Add(this.S_PHONE_NO);
            this.Controls.Add(this.S_EMAIL);
            this.Controls.Add(this.S_NAME);
            this.Controls.Add(this.S_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Name = "Form13";
            this.Text = "Update a student";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DEPT;
        private System.Windows.Forms.TextBox S_PHONE_NO;
        private System.Windows.Forms.TextBox S_EMAIL;
        private System.Windows.Forms.TextBox S_NAME;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox S_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}