
namespace WindowsFormsApp1
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.S_ID = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.RESERVE_DATE = new System.Windows.Forms.DateTimePicker();
            this.DUE_DATE = new System.Windows.Forms.DateTimePicker();
            this.RETURN_DATE = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ISBN\r\n\r\nStudent\'s ID";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reserve";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ISBN
            // 
            this.ISBN.Location = new System.Drawing.Point(175, 60);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(235, 20);
            this.ISBN.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(355, 295);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Return";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 68);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reserve Date                                                         Return Date\r" +
    "\n\r\n\r\n    Due Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // S_ID
            // 
            this.S_ID.Location = new System.Drawing.Point(175, 97);
            this.S_ID.Name = "S_ID";
            this.S_ID.Size = new System.Drawing.Size(235, 20);
            this.S_ID.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "< Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RESERVE_DATE
            // 
            this.RESERVE_DATE.Location = new System.Drawing.Point(30, 203);
            this.RESERVE_DATE.Name = "RESERVE_DATE";
            this.RESERVE_DATE.Size = new System.Drawing.Size(200, 20);
            this.RESERVE_DATE.TabIndex = 32;
            // 
            // DUE_DATE
            // 
            this.DUE_DATE.Location = new System.Drawing.Point(30, 254);
            this.DUE_DATE.Name = "DUE_DATE";
            this.DUE_DATE.Size = new System.Drawing.Size(200, 20);
            this.DUE_DATE.TabIndex = 33;
            // 
            // RETURN_DATE
            // 
            this.RETURN_DATE.Location = new System.Drawing.Point(284, 203);
            this.RETURN_DATE.Name = "RETURN_DATE";
            this.RETURN_DATE.Size = new System.Drawing.Size(200, 20);
            this.RETURN_DATE.TabIndex = 34;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(514, 401);
            this.Controls.Add(this.RETURN_DATE);
            this.Controls.Add(this.DUE_DATE);
            this.Controls.Add(this.RESERVE_DATE);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.S_ID);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "Form5";
            this.Text = "Reserve A Book";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ISBN;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox S_ID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DateTimePicker RESERVE_DATE;
        private System.Windows.Forms.DateTimePicker DUE_DATE;
        private System.Windows.Forms.DateTimePicker RETURN_DATE;
    }
}