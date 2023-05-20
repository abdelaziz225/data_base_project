
namespace WindowsFormsApp1
{
    partial class Form14
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
            this.components = new System.ComponentModel.Container();
            this.lIBRARYDataSet = new WindowsFormsApp1.LIBRARYDataSet();
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new WindowsFormsApp1.LIBRARYDataSetTableAdapters.BOOKTableAdapter();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new WindowsFormsApp1.LIBRARYDataSetTableAdapters.STUDENTTableAdapter();
            this.lIBRARYDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lIBRARYDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TITLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EDITION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_PHONE_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.S_EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RESERVE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUE_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RETURN_DATE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lIBRARYDataSet
            // 
            this.lIBRARYDataSet.DataSetName = "LIBRARYDataSet";
            this.lIBRARYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bOOKBindingSource
            // 
            this.bOOKBindingSource.DataMember = "BOOK";
            this.bOOKBindingSource.DataSource = this.lIBRARYDataSet;
            // 
            // bOOKTableAdapter
            // 
            this.bOOKTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.lIBRARYDataSet;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // lIBRARYDataSetBindingSource
            // 
            this.lIBRARYDataSetBindingSource.DataSource = this.lIBRARYDataSet;
            this.lIBRARYDataSetBindingSource.Position = 0;
            // 
            // lIBRARYDataSetBindingSource1
            // 
            this.lIBRARYDataSetBindingSource1.DataSource = this.lIBRARYDataSet;
            this.lIBRARYDataSetBindingSource1.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Tan;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ISBN,
            this.TITLE,
            this.EDITION,
            this.S_ID,
            this.S_NAME,
            this.DEPT,
            this.S_PHONE_NO,
            this.S_EMAIL,
            this.RESERVE_DATE,
            this.DUE_DATE,
            this.RETURN_DATE});
            this.dataGridView1.DataSource = this.bOOKBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(687, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1095, 258);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ISBN
            // 
            this.ISBN.DataPropertyName = "ISBN";
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            // 
            // TITLE
            // 
            this.TITLE.DataPropertyName = "TITLE";
            this.TITLE.HeaderText = "TITLE";
            this.TITLE.Name = "TITLE";
            // 
            // EDITION
            // 
            this.EDITION.DataPropertyName = "EDITION";
            this.EDITION.HeaderText = "EDITION";
            this.EDITION.Name = "EDITION";
            // 
            // S_ID
            // 
            this.S_ID.DataPropertyName = "S_ID";
            this.S_ID.HeaderText = "S_ID";
            this.S_ID.Name = "S_ID";
            // 
            // S_NAME
            // 
            this.S_NAME.DataPropertyName = "S_NAME";
            this.S_NAME.HeaderText = "S_NAME";
            this.S_NAME.Name = "S_NAME";
            // 
            // DEPT
            // 
            this.DEPT.DataPropertyName = "DEPT";
            this.DEPT.HeaderText = "DEPT";
            this.DEPT.Name = "DEPT";
            // 
            // S_PHONE_NO
            // 
            this.S_PHONE_NO.DataPropertyName = "S_PHONE_NO";
            this.S_PHONE_NO.HeaderText = "S_PHONE_NO";
            this.S_PHONE_NO.Name = "S_PHONE_NO";
            // 
            // S_EMAIL
            // 
            this.S_EMAIL.DataPropertyName = "S_EMAIL";
            this.S_EMAIL.HeaderText = "S_EMAIL";
            this.S_EMAIL.Name = "S_EMAIL";
            // 
            // RESERVE_DATE
            // 
            this.RESERVE_DATE.DataPropertyName = "RESERVE_DATE";
            this.RESERVE_DATE.HeaderText = "RESERVE_DATE";
            this.RESERVE_DATE.Name = "RESERVE_DATE";
            // 
            // DUE_DATE
            // 
            this.DUE_DATE.DataPropertyName = "DUE_DATE";
            this.DUE_DATE.HeaderText = "DUE_DATE";
            this.DUE_DATE.Name = "DUE_DATE";
            // 
            // RETURN_DATE
            // 
            this.RETURN_DATE.DataPropertyName = "RETURN_DATE";
            this.RETURN_DATE.HeaderText = "RETURN_DATE";
            this.RETURN_DATE.Name = "RETURN_DATE";
            // 
            // Form14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form14";
            this.Text = "All reserved books";
            this.Load += new System.EventHandler(this.Form14_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private LIBRARYDataSet lIBRARYDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private LIBRARYDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private LIBRARYDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.BindingSource lIBRARYDataSetBindingSource;
        private System.Windows.Forms.BindingSource lIBRARYDataSetBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TITLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EDITION;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_PHONE_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn S_EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RESERVE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUE_DATE;
        private System.Windows.Forms.DataGridViewTextBoxColumn RETURN_DATE;
    }
}