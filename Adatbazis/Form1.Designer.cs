﻿namespace Adatbazis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            neptunDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            birthDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            averageGradeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isActiveDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            studentBindingSource = new BindingSource(components);
            buttonMentes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, neptunDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, birthDateDataGridViewTextBoxColumn, averageGradeDataGridViewTextBoxColumn, isActiveDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = studentBindingSource;
            dataGridView1.Location = new Point(15, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(705, 239);
            dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // neptunDataGridViewTextBoxColumn
            // 
            neptunDataGridViewTextBoxColumn.DataPropertyName = "Neptun";
            neptunDataGridViewTextBoxColumn.HeaderText = "Neptun";
            neptunDataGridViewTextBoxColumn.Name = "neptunDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // averageGradeDataGridViewTextBoxColumn
            // 
            averageGradeDataGridViewTextBoxColumn.DataPropertyName = "AverageGrade";
            averageGradeDataGridViewTextBoxColumn.HeaderText = "AverageGrade";
            averageGradeDataGridViewTextBoxColumn.Name = "averageGradeDataGridViewTextBoxColumn";
            // 
            // isActiveDataGridViewCheckBoxColumn
            // 
            isActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive";
            isActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive";
            isActiveDataGridViewCheckBoxColumn.Name = "isActiveDataGridViewCheckBoxColumn";
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Models.Student);
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(579, 21);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(98, 27);
            buttonMentes.TabIndex = 1;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 437);
            Controls.Add(buttonMentes);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn neptunDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn averageGradeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isActiveDataGridViewCheckBoxColumn;
        private BindingSource studentBindingSource;
        private Button buttonMentes;
    }
}