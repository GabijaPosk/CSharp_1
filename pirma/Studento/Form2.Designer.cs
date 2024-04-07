
namespace pirma
{
    partial class Studento
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
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ivertinimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertinimasDa = new pirma.vertinimasDa();
            this.vertinimasDaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ivertinimasTableAdapter = new pirma.vertinimasDaTableAdapters.ivertinimasTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulioPavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kredituSkaiciusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskaitytaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivertinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentoNumerisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ivertinimasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(453, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 35;
            this.label3.Text = "PAŽYMIAI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(977, 728);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 37;
            this.button1.Text = "Atsijungti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ivertinimasBindingSource
            // 
            this.ivertinimasBindingSource.DataMember = "ivertinimas";
            this.ivertinimasBindingSource.DataSource = this.vertinimasDa;
            // 
            // vertinimasDa
            // 
            this.vertinimasDa.DataSetName = "vertinimasDa";
            this.vertinimasDa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vertinimasDaBindingSource
            // 
            this.vertinimasDaBindingSource.DataSource = this.vertinimasDa;
            this.vertinimasDaBindingSource.Position = 0;
            // 
            // ivertinimasTableAdapter
            // 
            this.ivertinimasTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.grupeDataGridViewTextBoxColumn,
            this.pavardeDataGridViewTextBoxColumn,
            this.vardasDataGridViewTextBoxColumn,
            this.modulioPavadinimasDataGridViewTextBoxColumn,
            this.kredituSkaiciusDataGridViewTextBoxColumn,
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn,
            this.iskaitytaDataGridViewTextBoxColumn,
            this.ivertinimasDataGridViewTextBoxColumn,
            this.studentoNumerisDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ivertinimasBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(49, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(987, 546);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // grupeDataGridViewTextBoxColumn
            // 
            this.grupeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grupeDataGridViewTextBoxColumn.DataPropertyName = "Grupe";
            this.grupeDataGridViewTextBoxColumn.HeaderText = "Grupe";
            this.grupeDataGridViewTextBoxColumn.Name = "grupeDataGridViewTextBoxColumn";
            this.grupeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pavardeDataGridViewTextBoxColumn
            // 
            this.pavardeDataGridViewTextBoxColumn.DataPropertyName = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.HeaderText = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.Name = "pavardeDataGridViewTextBoxColumn";
            this.pavardeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            this.vardasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modulioPavadinimasDataGridViewTextBoxColumn
            // 
            this.modulioPavadinimasDataGridViewTextBoxColumn.DataPropertyName = "ModulioPavadinimas";
            this.modulioPavadinimasDataGridViewTextBoxColumn.HeaderText = "Pavadinimas";
            this.modulioPavadinimasDataGridViewTextBoxColumn.Name = "modulioPavadinimasDataGridViewTextBoxColumn";
            this.modulioPavadinimasDataGridViewTextBoxColumn.ReadOnly = true;
            this.modulioPavadinimasDataGridViewTextBoxColumn.Width = 180;
            // 
            // kredituSkaiciusDataGridViewTextBoxColumn
            // 
            this.kredituSkaiciusDataGridViewTextBoxColumn.DataPropertyName = "KredituSkaicius";
            this.kredituSkaiciusDataGridViewTextBoxColumn.HeaderText = "Kredit.";
            this.kredituSkaiciusDataGridViewTextBoxColumn.Name = "kredituSkaiciusDataGridViewTextBoxColumn";
            this.kredituSkaiciusDataGridViewTextBoxColumn.ReadOnly = true;
            this.kredituSkaiciusDataGridViewTextBoxColumn.Width = 40;
            // 
            // uzduotiesPavadinimasDataGridViewTextBoxColumn
            // 
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn.DataPropertyName = "UzduotiesPavadinimas";
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn.HeaderText = "Užduotis";
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn.Name = "uzduotiesPavadinimasDataGridViewTextBoxColumn";
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iskaitytaDataGridViewTextBoxColumn
            // 
            this.iskaitytaDataGridViewTextBoxColumn.DataPropertyName = "Iskaityta";
            this.iskaitytaDataGridViewTextBoxColumn.HeaderText = "IS";
            this.iskaitytaDataGridViewTextBoxColumn.Name = "iskaitytaDataGridViewTextBoxColumn";
            this.iskaitytaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iskaitytaDataGridViewTextBoxColumn.Width = 30;
            // 
            // ivertinimasDataGridViewTextBoxColumn
            // 
            this.ivertinimasDataGridViewTextBoxColumn.DataPropertyName = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.HeaderText = "Paž.";
            this.ivertinimasDataGridViewTextBoxColumn.Name = "ivertinimasDataGridViewTextBoxColumn";
            this.ivertinimasDataGridViewTextBoxColumn.ReadOnly = true;
            this.ivertinimasDataGridViewTextBoxColumn.Width = 55;
            // 
            // studentoNumerisDataGridViewTextBoxColumn
            // 
            this.studentoNumerisDataGridViewTextBoxColumn.DataPropertyName = "StudentoNumeris";
            this.studentoNumerisDataGridViewTextBoxColumn.HeaderText = "Stud. Nr.";
            this.studentoNumerisDataGridViewTextBoxColumn.Name = "studentoNumerisDataGridViewTextBoxColumn";
            this.studentoNumerisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(154, 655);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(253, 39);
            this.textBox1.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(45, 655);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 39);
            this.label2.TabIndex = 57;
            this.label2.Text = "Vidurkis";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Studento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pirma.Properties.Resources.papers_co_so15_purple_pastel_blur_gradation_1_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1080, 777);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Studento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentui";
            this.Load += new System.EventHandler(this.Studento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ivertinimasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource vertinimasDaBindingSource;
        private vertinimasDa vertinimasDa;
        private System.Windows.Forms.BindingSource ivertinimasBindingSource;
        private vertinimasDaTableAdapters.ivertinimasTableAdapter ivertinimasTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eilesNrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulioPavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kredituSkaiciusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzduotiesPavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskaitytaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivertinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentoNumerisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}