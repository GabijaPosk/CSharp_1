
namespace pirma
{
    partial class RedaguotiP
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
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.ivertinimasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertinimasDa = new pirma.vertinimasDa();
            this.label3 = new System.Windows.Forms.Label();
            this.ivertinimasTableAdapter = new pirma.vertinimasDaTableAdapters.ivertinimasTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivertinimasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDa)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(989, 740);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 48;
            this.button2.Text = "Grįžti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(51, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(987, 550);
            this.dataGridView1.TabIndex = 46;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 40;
            // 
            // grupeDataGridViewTextBoxColumn
            // 
            this.grupeDataGridViewTextBoxColumn.DataPropertyName = "Grupe";
            this.grupeDataGridViewTextBoxColumn.HeaderText = "Grupė";
            this.grupeDataGridViewTextBoxColumn.Name = "grupeDataGridViewTextBoxColumn";
            // 
            // pavardeDataGridViewTextBoxColumn
            // 
            this.pavardeDataGridViewTextBoxColumn.DataPropertyName = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.HeaderText = "Pavardė";
            this.pavardeDataGridViewTextBoxColumn.Name = "pavardeDataGridViewTextBoxColumn";
            this.pavardeDataGridViewTextBoxColumn.Width = 120;
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            // 
            // modulioPavadinimasDataGridViewTextBoxColumn
            // 
            this.modulioPavadinimasDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.modulioPavadinimasDataGridViewTextBoxColumn.DataPropertyName = "ModulioPavadinimas";
            this.modulioPavadinimasDataGridViewTextBoxColumn.HeaderText = "Modulis";
            this.modulioPavadinimasDataGridViewTextBoxColumn.Name = "modulioPavadinimasDataGridViewTextBoxColumn";
            // 
            // kredituSkaiciusDataGridViewTextBoxColumn
            // 
            this.kredituSkaiciusDataGridViewTextBoxColumn.DataPropertyName = "KredituSkaicius";
            this.kredituSkaiciusDataGridViewTextBoxColumn.HeaderText = "Kreditų Sk.";
            this.kredituSkaiciusDataGridViewTextBoxColumn.Name = "kredituSkaiciusDataGridViewTextBoxColumn";
            this.kredituSkaiciusDataGridViewTextBoxColumn.Width = 50;
            // 
            // uzduotiesPavadinimasDataGridViewTextBoxColumn
            // 
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn.DataPropertyName = "UzduotiesPavadinimas";
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn.HeaderText = "Užduotis";
            this.uzduotiesPavadinimasDataGridViewTextBoxColumn.Name = "uzduotiesPavadinimasDataGridViewTextBoxColumn";
            // 
            // iskaitytaDataGridViewTextBoxColumn
            // 
            this.iskaitytaDataGridViewTextBoxColumn.DataPropertyName = "Iskaityta";
            this.iskaitytaDataGridViewTextBoxColumn.HeaderText = "IS";
            this.iskaitytaDataGridViewTextBoxColumn.Name = "iskaitytaDataGridViewTextBoxColumn";
            this.iskaitytaDataGridViewTextBoxColumn.Width = 50;
            // 
            // ivertinimasDataGridViewTextBoxColumn
            // 
            this.ivertinimasDataGridViewTextBoxColumn.DataPropertyName = "Ivertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.HeaderText = "Įvertinimas";
            this.ivertinimasDataGridViewTextBoxColumn.Name = "ivertinimasDataGridViewTextBoxColumn";
            this.ivertinimasDataGridViewTextBoxColumn.Width = 80;
            // 
            // studentoNumerisDataGridViewTextBoxColumn
            // 
            this.studentoNumerisDataGridViewTextBoxColumn.DataPropertyName = "StudentoNumeris";
            this.studentoNumerisDataGridViewTextBoxColumn.HeaderText = "Studento Nr.";
            this.studentoNumerisDataGridViewTextBoxColumn.Name = "studentoNumerisDataGridViewTextBoxColumn";
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(467, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 32);
            this.label3.TabIndex = 47;
            this.label3.Text = "PAŽYMIAI";
            // 
            // ivertinimasTableAdapter
            // 
            this.ivertinimasTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(51, 87);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(345, 37);
            this.textBox1.TabIndex = 59;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(406, 87);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 37);
            this.button4.TabIndex = 58;
            this.button4.Text = "Paieška";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(814, 87);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 37);
            this.button3.TabIndex = 57;
            this.button3.Text = "Išsaugoti";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(947, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 37);
            this.button1.TabIndex = 56;
            this.button1.Text = "Ištrinti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RedaguotiP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pirma.Properties.Resources.papers_co_so15_purple_pastel_blur_gradation_1_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1092, 789);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RedaguotiP";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destytojui";
            this.Load += new System.EventHandler(this.RedaguotiP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ivertinimasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private vertinimasDa vertinimasDa;
        private System.Windows.Forms.BindingSource ivertinimasBindingSource;
        private vertinimasDaTableAdapters.ivertinimasTableAdapter ivertinimasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}