
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.vertinimasDa = new pirma.vertinimasDa();
            this.ivertinimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ivertinimasTableAdapter = new pirma.vertinimasDaTableAdapters.ivertinimasTableAdapter();
            this.studentoNumerisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modulioPavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kredituSkaiciusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iskaitytaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ivertinimasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivertinimasBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentoNumerisDataGridViewTextBoxColumn,
            this.vardasDataGridViewTextBoxColumn,
            this.pavardeDataGridViewTextBoxColumn,
            this.grupeDataGridViewTextBoxColumn,
            this.modulioPavadinimasDataGridViewTextBoxColumn,
            this.kredituSkaiciusDataGridViewTextBoxColumn,
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn,
            this.iskaitytaDataGridViewTextBoxColumn,
            this.ivertinimasDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ivertinimasBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(52, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(987, 581);
            this.dataGridView1.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(480, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 45;
            this.label3.Text = "PAŽYMIAI";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(989, 740);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 46;
            this.button1.Text = "Atsijungti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(48, 697);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 40);
            this.label2.TabIndex = 101;
            this.label2.Text = "Vidurkis";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(160, 697);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 40);
            this.textBox1.TabIndex = 100;
            // 
            // vertinimasDa
            // 
            this.vertinimasDa.DataSetName = "vertinimasDa";
            this.vertinimasDa.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ivertinimasBindingSource
            // 
            this.ivertinimasBindingSource.DataMember = "ivertinimas";
            this.ivertinimasBindingSource.DataSource = this.vertinimasDa;
            // 
            // ivertinimasTableAdapter
            // 
            this.ivertinimasTableAdapter.ClearBeforeFill = true;
            // 
            // studentoNumerisDataGridViewTextBoxColumn
            // 
            this.studentoNumerisDataGridViewTextBoxColumn.DataPropertyName = "StudentoNumeris";
            this.studentoNumerisDataGridViewTextBoxColumn.HeaderText = "Studento Numeris";
            this.studentoNumerisDataGridViewTextBoxColumn.Name = "studentoNumerisDataGridViewTextBoxColumn";
            this.studentoNumerisDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            this.vardasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pavardeDataGridViewTextBoxColumn
            // 
            this.pavardeDataGridViewTextBoxColumn.DataPropertyName = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.HeaderText = "Pavardė";
            this.pavardeDataGridViewTextBoxColumn.Name = "pavardeDataGridViewTextBoxColumn";
            this.pavardeDataGridViewTextBoxColumn.ReadOnly = true;
            this.pavardeDataGridViewTextBoxColumn.Width = 120;
            // 
            // grupeDataGridViewTextBoxColumn
            // 
            this.grupeDataGridViewTextBoxColumn.DataPropertyName = "Grupe";
            this.grupeDataGridViewTextBoxColumn.HeaderText = "Grupė";
            this.grupeDataGridViewTextBoxColumn.Name = "grupeDataGridViewTextBoxColumn";
            this.grupeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modulioPavadinimasDataGridViewTextBoxColumn
            // 
            this.modulioPavadinimasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modulioPavadinimasDataGridViewTextBoxColumn.DataPropertyName = "ModulioPavadinimas";
            this.modulioPavadinimasDataGridViewTextBoxColumn.HeaderText = "Modulis";
            this.modulioPavadinimasDataGridViewTextBoxColumn.Name = "modulioPavadinimasDataGridViewTextBoxColumn";
            this.modulioPavadinimasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kredituSkaiciusDataGridViewTextBoxColumn
            // 
            this.kredituSkaiciusDataGridViewTextBoxColumn.DataPropertyName = "KredituSkaicius";
            this.kredituSkaiciusDataGridViewTextBoxColumn.HeaderText = "Kreditų Sk.";
            this.kredituSkaiciusDataGridViewTextBoxColumn.Name = "kredituSkaiciusDataGridViewTextBoxColumn";
            this.kredituSkaiciusDataGridViewTextBoxColumn.ReadOnly = true;
            this.kredituSkaiciusDataGridViewTextBoxColumn.Width = 50;
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
            this.iskaitytaDataGridViewTextBoxColumn.Width = 50;
            // 
            // ivertinimasDataGridViewTextBoxColumn
            // 
            this.ivertinimasDataGridViewTextBoxColumn.DataPropertyName = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.HeaderText = "Įvertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.Name = "ivertinimasDataGridViewTextBoxColumn";
            this.ivertinimasDataGridViewTextBoxColumn.ReadOnly = true;
            this.ivertinimasDataGridViewTextBoxColumn.Width = 80;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Studento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pirma.Properties.Resources.papers_co_so15_purple_pastel_blur_gradation_1_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 789);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Studento";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Studentui";
            this.Load += new System.EventHandler(this.Studento_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivertinimasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private vertinimasDa vertinimasDa;
        private System.Windows.Forms.BindingSource ivertinimasBindingSource;
        private vertinimasDaTableAdapters.ivertinimasTableAdapter ivertinimasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentoNumerisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modulioPavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kredituSkaiciusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uzduotiesPavadinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iskaitytaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ivertinimasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
    }
}