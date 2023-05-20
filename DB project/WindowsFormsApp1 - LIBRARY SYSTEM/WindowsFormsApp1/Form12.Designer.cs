
namespace WindowsFormsApp1
{
    partial class Form12
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
            this.button2 = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.FLOOR_NO = new System.Windows.Forms.TextBox();
            this.SHELF_NO = new System.Windows.Forms.TextBox();
            this.A_ID = new System.Windows.Forms.TextBox();
            this.EDITION = new System.Windows.Forms.TextBox();
            this.TITLE = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "< Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(182, 234);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(84, 20);
            this.ID.TabIndex = 40;
            // 
            // FLOOR_NO
            // 
            this.FLOOR_NO.Location = new System.Drawing.Point(231, 279);
            this.FLOOR_NO.Name = "FLOOR_NO";
            this.FLOOR_NO.Size = new System.Drawing.Size(35, 20);
            this.FLOOR_NO.TabIndex = 39;
            // 
            // SHELF_NO
            // 
            this.SHELF_NO.Location = new System.Drawing.Point(169, 279);
            this.SHELF_NO.Name = "SHELF_NO";
            this.SHELF_NO.Size = new System.Drawing.Size(35, 20);
            this.SHELF_NO.TabIndex = 38;
            // 
            // A_ID
            // 
            this.A_ID.Location = new System.Drawing.Point(182, 208);
            this.A_ID.Name = "A_ID";
            this.A_ID.Size = new System.Drawing.Size(84, 20);
            this.A_ID.TabIndex = 37;
            // 
            // EDITION
            // 
            this.EDITION.Location = new System.Drawing.Point(103, 279);
            this.EDITION.Name = "EDITION";
            this.EDITION.Size = new System.Drawing.Size(35, 20);
            this.EDITION.TabIndex = 36;
            // 
            // TITLE
            // 
            this.TITLE.Location = new System.Drawing.Point(182, 182);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(84, 20);
            this.TITLE.TabIndex = 35;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(182, 130);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(84, 20);
            this.ISBN.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "BOOKS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(103, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Update Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 143);
            this.label3.TabIndex = 34;
            this.label3.Text = "CURRENT ISBN\r\n\r\n                       NEW\r\n\r\nTitle\r\n\r\nAuthor ID\r\n\r\nStaff ID\r\n\r\nE" +
    "dition           Shelf no.        Floor no.\r\n";
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.FLOOR_NO);
            this.Controls.Add(this.SHELF_NO);
            this.Controls.Add(this.A_ID);
            this.Controls.Add(this.EDITION);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "Form12";
            this.Text = "Update a book";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox FLOOR_NO;
        private System.Windows.Forms.TextBox SHELF_NO;
        private System.Windows.Forms.TextBox A_ID;
        private System.Windows.Forms.TextBox EDITION;
        private System.Windows.Forms.TextBox TITLE;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
    }
}