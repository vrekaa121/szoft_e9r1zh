namespace Adatkötés
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
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            populationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            areaInSquareKmDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            countryDataBindingSource = new BindingSource(components);
            buttonSzerkesztes = new Button();
            buttonTorles = new Button();
            buttonMegnyitas = new Button();
            buttonMentes = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, populationDataGridViewTextBoxColumn, areaInSquareKmDataGridViewTextBoxColumn });
            dataGridView1.DataSource = countryDataBindingSource;
            dataGridView1.Location = new Point(12, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(775, 265);
            dataGridView1.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // populationDataGridViewTextBoxColumn
            // 
            populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            populationDataGridViewTextBoxColumn.HeaderText = "Population";
            populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            // 
            // areaInSquareKmDataGridViewTextBoxColumn
            // 
            areaInSquareKmDataGridViewTextBoxColumn.DataPropertyName = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.HeaderText = "AreaInSquareKm";
            areaInSquareKmDataGridViewTextBoxColumn.Name = "areaInSquareKmDataGridViewTextBoxColumn";
            // 
            // countryDataBindingSource
            // 
            countryDataBindingSource.DataSource = typeof(CountryData);
            // 
            // buttonSzerkesztes
            // 
            buttonSzerkesztes.Location = new Point(674, 407);
            buttonSzerkesztes.Name = "buttonSzerkesztes";
            buttonSzerkesztes.Size = new Size(113, 31);
            buttonSzerkesztes.TabIndex = 1;
            buttonSzerkesztes.Text = "Szerkesztés";
            buttonSzerkesztes.UseVisualStyleBackColor = true;
            buttonSzerkesztes.Click += button1_Click;
            // 
            // buttonTorles
            // 
            buttonTorles.Location = new Point(555, 407);
            buttonTorles.Name = "buttonTorles";
            buttonTorles.Size = new Size(113, 31);
            buttonTorles.TabIndex = 2;
            buttonTorles.Text = "Törlés";
            buttonTorles.UseVisualStyleBackColor = true;
            buttonTorles.Click += buttonTorles_Click;
            // 
            // buttonMegnyitas
            // 
            buttonMegnyitas.Location = new Point(674, 24);
            buttonMegnyitas.Name = "buttonMegnyitas";
            buttonMegnyitas.Size = new Size(113, 31);
            buttonMegnyitas.TabIndex = 3;
            buttonMegnyitas.Text = "Megnyitás";
            buttonMegnyitas.UseVisualStyleBackColor = true;
            buttonMegnyitas.Click += buttonMegnyitas_Click;
            // 
            // buttonMentes
            // 
            buttonMentes.Location = new Point(433, 408);
            buttonMentes.Name = "buttonMentes";
            buttonMentes.Size = new Size(116, 30);
            buttonMentes.TabIndex = 4;
            buttonMentes.Text = "Mentés";
            buttonMentes.UseVisualStyleBackColor = true;
            buttonMentes.Click += buttonMentes_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonMentes);
            Controls.Add(buttonMegnyitas);
            Controls.Add(buttonTorles);
            Controls.Add(buttonSzerkesztes);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)countryDataBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonSzerkesztes;
        private Button buttonTorles;
        private Button buttonMegnyitas;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn areaInSquareKmDataGridViewTextBoxColumn;
        private BindingSource countryDataBindingSource;
        private Button buttonMentes;
    }
}