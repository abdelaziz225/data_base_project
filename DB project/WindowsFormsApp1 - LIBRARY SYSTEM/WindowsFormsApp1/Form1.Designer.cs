
namespace WindowsFormsApp1
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
            this.login_button = new System.Windows.Forms.Button();
            this.user_id = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Linen;
            this.login_button.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(376, 231);
            this.login_button.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(103, 35);
            this.login_button.TabIndex = 0;
            this.login_button.Text = "Log in";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // user_id
            // 
            this.user_id.BackColor = System.Drawing.Color.Linen;
            this.user_id.Location = new System.Drawing.Point(160, 100);
            this.user_id.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(204, 22);
            this.user_id.TabIndex = 1;
            this.user_id.TextChanged += new System.EventHandler(this.id_text_TextChanged);
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.SystemColors.Window;
            this.password.Location = new System.Drawing.Point(160, 170);
            this.password.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(204, 22);
            this.password.TabIndex = 2;
            this.password.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(157, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 96);
            this.label1.TabIndex = 3;
            this.label1.Text = "User ID :\r\n\r\n\r\nPassword :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(517, 279);
            this.Controls.Add(this.password);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft JhengHei", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Logging in";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label1;
    }
}

