
namespace WindowsFormsApp1
{
    partial class Form3
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
            this.STUDENTS = new System.Windows.Forms.DataGridView();
            this.lIBRARYDataSet = new WindowsFormsApp1.LIBRARYDataSet();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new WindowsFormsApp1.LIBRARYDataSetTableAdapters.STUDENTTableAdapter();
            this.rEGSYSTEMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEG_SYSTEMTableAdapter = new WindowsFormsApp1.LIBRARYDataSetTableAdapters.REG_SYSTEMTableAdapter();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sEMAILDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sPHONENODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dEPTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGSYSTEMBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // STUDENTS
            // 
            this.STUDENTS.AutoGenerateColumns = false;
            this.STUDENTS.BackgroundColor = System.Drawing.Color.Tan;
            this.STUDENTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.STUDENTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sIDDataGridViewTextBoxColumn,
            this.sNAMEDataGridViewTextBoxColumn,
            this.sEMAILDataGridViewTextBoxColumn,
            this.sPHONENODataGridViewTextBoxColumn,
            this.dEPTDataGridViewTextBoxColumn});
            this.STUDENTS.DataSource = this.sTUDENTBindingSource;
            this.STUDENTS.Location = new System.Drawing.Point(-1, -3);
            this.STUDENTS.Name = "STUDENTS";
            this.STUDENTS.Size = new System.Drawing.Size(542, 420);
            this.STUDENTS.TabIndex = 0;
            this.STUDENTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.STUDENTS_CellContentClick);
            // 
            // lIBRARYDataSet
            // 
            this.lIBRARYDataSet.DataSetName = "LIBRARYDataSet";
            this.lIBRARYDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // rEGSYSTEMBindingSource
            // 
            this.rEGSYSTEMBindingSource.DataMember = "REG_SYSTEM";
            this.rEGSYSTEMBindingSource.DataSource = this.lIBRARYDataSet;
            // 
            // rEG_SYSTEMTableAdapter
            // 
            this.rEG_SYSTEMTableAdapter.ClearBeforeFill = true;
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "S_ID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // sNAMEDataGridViewTextBoxColumn
            // 
            this.sNAMEDataGridViewTextBoxColumn.DataPropertyName = "S_NAME";
            this.sNAMEDataGridViewTextBoxColumn.HeaderText = "S_NAME";
            this.sNAMEDataGridViewTextBoxColumn.Name = "sNAMEDataGridViewTextBoxColumn";
            // 
            // sEMAILDataGridViewTextBoxColumn
            // 
            this.sEMAILDataGridViewTextBoxColumn.DataPropertyName = "S_EMAIL";
            this.sEMAILDataGridViewTextBoxColumn.HeaderText = "S_EMAIL";
            this.sEMAILDataGridViewTextBoxColumn.Name = "sEMAILDataGridViewTextBoxColumn";
            // 
            // sPHONENODataGridViewTextBoxColumn
            // 
            this.sPHONENODataGridViewTextBoxColumn.DataPropertyName = "S_PHONE_NO";
            this.sPHONENODataGridViewTextBoxColumn.HeaderText = "S_PHONE_NO";
            this.sPHONENODataGridViewTextBoxColumn.Name = "sPHONENODataGridViewTextBoxColumn";
            // 
            // dEPTDataGridViewTextBoxColumn
            // 
            this.dEPTDataGridViewTextBoxColumn.DataPropertyName = "DEPT";
            this.dEPTDataGridViewTextBoxColumn.HeaderText = "DEPT";
            this.dEPTDataGridViewTextBoxColumn.Name = "dEPTDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(599, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 392);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.STUDENTS);
            this.Name = "Form3";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEGSYSTEMBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView STUDENTS;
        private LIBRARYDataSet lIBRARYDataSet;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private LIBRARYDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.BindingSource rEGSYSTEMBindingSource;
        private LIBRARYDataSetTableAdapters.REG_SYSTEMTableAdapter rEG_SYSTEMTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sEMAILDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sPHONENODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dEPTDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}