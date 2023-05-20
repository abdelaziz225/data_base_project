
namespace WindowsFormsApp1
{
    partial class Form4
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
            this.bOOKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bOOKTableAdapter = new WindowsFormsApp1.LIBRARYDataSetTableAdapters.BOOKTableAdapter();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sHELFNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fLOORNODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tITLEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eDITIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pUBLISHERNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rESERVEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUEDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rETURNDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // STUDENTS
            // 
            this.STUDENTS.AutoGenerateColumns = false;
            this.STUDENTS.BackgroundColor = System.Drawing.Color.Tan;
            this.STUDENTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.STUDENTS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.aIDDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn,
            this.sIDDataGridViewTextBoxColumn,
            this.sHELFNODataGridViewTextBoxColumn,
            this.fLOORNODataGridViewTextBoxColumn,
            this.tITLEDataGridViewTextBoxColumn,
            this.eDITIONDataGridViewTextBoxColumn,
            this.pUBLISHERNAMEDataGridViewTextBoxColumn,
            this.rESERVEDATEDataGridViewTextBoxColumn,
            this.dUEDATEDataGridViewTextBoxColumn,
            this.rETURNDATEDataGridViewTextBoxColumn});
            this.STUDENTS.DataSource = this.bOOKBindingSource;
            this.STUDENTS.Location = new System.Drawing.Point(-1, -4);
            this.STUDENTS.Name = "STUDENTS";
            this.STUDENTS.Size = new System.Drawing.Size(739, 420);
            this.STUDENTS.TabIndex = 1;
            this.STUDENTS.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.STUDENTS_CellContentClick);
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
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            // 
            // aIDDataGridViewTextBoxColumn
            // 
            this.aIDDataGridViewTextBoxColumn.DataPropertyName = "A_ID";
            this.aIDDataGridViewTextBoxColumn.HeaderText = "A_ID";
            this.aIDDataGridViewTextBoxColumn.Name = "aIDDataGridViewTextBoxColumn";
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // sIDDataGridViewTextBoxColumn
            // 
            this.sIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID";
            this.sIDDataGridViewTextBoxColumn.HeaderText = "S_ID";
            this.sIDDataGridViewTextBoxColumn.Name = "sIDDataGridViewTextBoxColumn";
            // 
            // sHELFNODataGridViewTextBoxColumn
            // 
            this.sHELFNODataGridViewTextBoxColumn.DataPropertyName = "SHELF_NO";
            this.sHELFNODataGridViewTextBoxColumn.HeaderText = "SHELF_NO";
            this.sHELFNODataGridViewTextBoxColumn.Name = "sHELFNODataGridViewTextBoxColumn";
            // 
            // fLOORNODataGridViewTextBoxColumn
            // 
            this.fLOORNODataGridViewTextBoxColumn.DataPropertyName = "FLOOR_NO";
            this.fLOORNODataGridViewTextBoxColumn.HeaderText = "FLOOR_NO";
            this.fLOORNODataGridViewTextBoxColumn.Name = "fLOORNODataGridViewTextBoxColumn";
            // 
            // tITLEDataGridViewTextBoxColumn
            // 
            this.tITLEDataGridViewTextBoxColumn.DataPropertyName = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.HeaderText = "TITLE";
            this.tITLEDataGridViewTextBoxColumn.Name = "tITLEDataGridViewTextBoxColumn";
            // 
            // eDITIONDataGridViewTextBoxColumn
            // 
            this.eDITIONDataGridViewTextBoxColumn.DataPropertyName = "EDITION";
            this.eDITIONDataGridViewTextBoxColumn.HeaderText = "EDITION";
            this.eDITIONDataGridViewTextBoxColumn.Name = "eDITIONDataGridViewTextBoxColumn";
            // 
            // pUBLISHERNAMEDataGridViewTextBoxColumn
            // 
            this.pUBLISHERNAMEDataGridViewTextBoxColumn.DataPropertyName = "PUBLISHER_NAME";
            this.pUBLISHERNAMEDataGridViewTextBoxColumn.HeaderText = "PUBLISHER_NAME";
            this.pUBLISHERNAMEDataGridViewTextBoxColumn.Name = "pUBLISHERNAMEDataGridViewTextBoxColumn";
            // 
            // rESERVEDATEDataGridViewTextBoxColumn
            // 
            this.rESERVEDATEDataGridViewTextBoxColumn.DataPropertyName = "RESERVE_DATE";
            this.rESERVEDATEDataGridViewTextBoxColumn.HeaderText = "RESERVE_DATE";
            this.rESERVEDATEDataGridViewTextBoxColumn.Name = "rESERVEDATEDataGridViewTextBoxColumn";
            // 
            // dUEDATEDataGridViewTextBoxColumn
            // 
            this.dUEDATEDataGridViewTextBoxColumn.DataPropertyName = "DUE_DATE";
            this.dUEDATEDataGridViewTextBoxColumn.HeaderText = "DUE_DATE";
            this.dUEDATEDataGridViewTextBoxColumn.Name = "dUEDATEDataGridViewTextBoxColumn";
            // 
            // rETURNDATEDataGridViewTextBoxColumn
            // 
            this.rETURNDATEDataGridViewTextBoxColumn.DataPropertyName = "RETURN_DATE";
            this.rETURNDATEDataGridViewTextBoxColumn.HeaderText = "RETURN_DATE";
            this.rETURNDATEDataGridViewTextBoxColumn.Name = "rETURNDATEDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(766, 286);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.STUDENTS);
            this.Name = "Form4";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.STUDENTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lIBRARYDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bOOKBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView STUDENTS;
        private LIBRARYDataSet lIBRARYDataSet;
        private System.Windows.Forms.BindingSource bOOKBindingSource;
        private LIBRARYDataSetTableAdapters.BOOKTableAdapter bOOKTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sHELFNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fLOORNODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tITLEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eDITIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pUBLISHERNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rESERVEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUEDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rETURNDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}