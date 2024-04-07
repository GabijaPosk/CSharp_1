
namespace pirma
{
    partial class Studentai
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
            this.studentoNumerisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vertinimasDa = new pirma.vertinimasDa();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.studentaiTableAdapter = new pirma.vertinimasDaTableAdapters.studentaiTableAdapter();
            this.studentaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentaiBindingSource1)).BeginInit();
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
            this.grupeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentaiBindingSource1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.Location = new System.Drawing.Point(49, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.Size = new System.Drawing.Size(987, 597);
            this.dataGridView1.TabIndex = 38;
            // 
            // studentoNumerisDataGridViewTextBoxColumn
            // 
            this.studentoNumerisDataGridViewTextBoxColumn.DataPropertyName = "StudentoNumeris";
            this.studentoNumerisDataGridViewTextBoxColumn.HeaderText = "Studento Numeris";
            this.studentoNumerisDataGridViewTextBoxColumn.Name = "studentoNumerisDataGridViewTextBoxColumn";
            this.studentoNumerisDataGridViewTextBoxColumn.ReadOnly = true;
            this.studentoNumerisDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.studentoNumerisDataGridViewTextBoxColumn.Width = 200;
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            this.vardasDataGridViewTextBoxColumn.ReadOnly = true;
            this.vardasDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vardasDataGridViewTextBoxColumn.Width = 200;
            // 
            // grupeDataGridViewTextBoxColumn
            // 
            this.grupeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grupeDataGridViewTextBoxColumn.DataPropertyName = "Grupe";
            this.grupeDataGridViewTextBoxColumn.HeaderText = "Grupė";
            this.grupeDataGridViewTextBoxColumn.Name = "grupeDataGridViewTextBoxColumn";
            this.grupeDataGridViewTextBoxColumn.ReadOnly = true;
            this.grupeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // studentaiBindingSource
            // 
            this.studentaiBindingSource.DataMember = "studentai";
            this.studentaiBindingSource.DataSource = this.vertinimasDa;
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
            this.label3.Location = new System.Drawing.Point(458, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 32);
            this.label3.TabIndex = 39;
            this.label3.Text = "STUDENTAI";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(981, 732);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 37);
            this.button2.TabIndex = 41;
            this.button2.Text = "Grįžti";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // studentaiTableAdapter
            // 
            this.studentaiTableAdapter.ClearBeforeFill = true;
            // 
            // studentaiBindingSource1
            // 
            this.studentaiBindingSource1.DataMember = "studentai";
            this.studentaiBindingSource1.DataSource = this.vertinimasDa;
            // 
            // Studentai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pirma.Properties.Resources.papers_co_so15_purple_pastel_blur_gradation_1_wallpaper;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1084, 781);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Studentai";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Destytojo";
            this.Load += new System.EventHandler(this.Destytojo_studentai_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentaiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vertinimasDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentaiBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private vertinimasDa vertinimasDa;
        private System.Windows.Forms.BindingSource studentaiBindingSource;
        private vertinimasDaTableAdapters.studentaiTableAdapter studentaiTableAdapter;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentoNumerisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardÄDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource studentaiBindingSource1;
    }
}