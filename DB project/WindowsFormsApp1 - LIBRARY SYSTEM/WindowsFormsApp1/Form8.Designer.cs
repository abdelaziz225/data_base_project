
namespace WindowsFormsApp1
{
    partial class Form8
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
            this.STAFF_ID = new System.Windows.Forms.TextBox();
            this.FLOOR = new System.Windows.Forms.TextBox();
            this.SHELF = new System.Windows.Forms.TextBox();
            this.A_ID = new System.Windows.Forms.TextBox();
            this.ED = new System.Windows.Forms.TextBox();
            this.TITLE = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // STAFF_ID
            // 
            this.STAFF_ID.Location = new System.Drawing.Point(167, 207);
            this.STAFF_ID.Name = "STAFF_ID";
            this.STAFF_ID.Size = new System.Drawing.Size(100, 20);
            this.STAFF_ID.TabIndex = 29;
            // 
            // FLOOR
            // 
            this.FLOOR.Location = new System.Drawing.Point(232, 257);
            this.FLOOR.Name = "FLOOR";
            this.FLOOR.Size = new System.Drawing.Size(35, 20);
            this.FLOOR.TabIndex = 28;
            // 
            // SHELF
            // 
            this.SHELF.Location = new System.Drawing.Point(167, 257);
            this.SHELF.Name = "SHELF";
            this.SHELF.Size = new System.Drawing.Size(35, 20);
            this.SHELF.TabIndex = 27;
            // 
            // A_ID
            // 
            this.A_ID.Location = new System.Drawing.Point(167, 181);
            this.A_ID.Name = "A_ID";
            this.A_ID.Size = new System.Drawing.Size(100, 20);
            this.A_ID.TabIndex = 26;
            // 
            // ED
            // 
            this.ED.Location = new System.Drawing.Point(104, 257);
            this.ED.Name = "ED";
            this.ED.Size = new System.Drawing.Size(35, 20);
            this.ED.TabIndex = 25;
            // 
            // TITLE
            // 
            this.TITLE.Location = new System.Drawing.Point(167, 155);
            this.TITLE.Name = "TITLE";
            this.TITLE.Size = new System.Drawing.Size(100, 20);
            this.TITLE.TabIndex = 24;
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(167, 129);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(100, 20);
            this.ISBN.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "BOOKS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Add New Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 117);
            this.label3.TabIndex = 23;
            this.label3.Text = "ISBN\r\n\r\nTitle\r\n\r\nAuthor ID\r\n\r\nStaff ID\r\n\r\nEdition           Shelf no.        Floo" +
    "r no.\r\n";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(13, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 30;
            this.button2.Text = "< Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(377, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.STAFF_ID);
            this.Controls.Add(this.FLOOR);
            this.Controls.Add(this.SHELF);
            this.Controls.Add(this.A_ID);
            this.Controls.Add(this.ED);
            this.Controls.Add(this.TITLE);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Name = "Form8";
            this.Text = "Add new book";
            this.Load += new System.EventHandler(this.Form8_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox STAFF_ID;
        private System.Windows.Forms.TextBox FLOOR;
        private System.Windows.Forms.TextBox SHELF;
        private System.Windows.Forms.TextBox A_ID;
        private System.Windows.Forms.TextBox ED;
        private System.Windows.Forms.TextBox TITLE;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
    }
}