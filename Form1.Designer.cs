namespace Nah
{
    partial class NewStar
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmpName = new System.Windows.Forms.TextBox();
            this.txtEmpCity = new System.Windows.Forms.TextBox();
            this.txtEmpAdd = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.starNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starCoordinateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.starsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.stars9DataSet = new Nah.Stars9DataSet();
            this.starsTableAdapter = new Nah.Stars9DataSetTableAdapters.StarsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.starsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stars9DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Star Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Star Type:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Star Coordinates";
            // 
            // txtEmpName
            // 
            this.txtEmpName.Location = new System.Drawing.Point(132, 54);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Size = new System.Drawing.Size(149, 22);
            this.txtEmpName.TabIndex = 3;
            // 
            // txtEmpCity
            // 
            this.txtEmpCity.Location = new System.Drawing.Point(132, 124);
            this.txtEmpCity.Name = "txtEmpCity";
            this.txtEmpCity.Size = new System.Drawing.Size(149, 22);
            this.txtEmpCity.TabIndex = 4;
            // 
            // txtEmpAdd
            // 
            this.txtEmpAdd.Location = new System.Drawing.Point(132, 189);
            this.txtEmpAdd.Name = "txtEmpAdd";
            this.txtEmpAdd.Size = new System.Drawing.Size(149, 22);
            this.txtEmpAdd.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(227, 23);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Add Star";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 379);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(132, 379);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(107, 23);
            this.btnBack.TabIndex = 8;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.starNameDataGridViewTextBoxColumn,
            this.starTypeDataGridViewTextBoxColumn,
            this.starCoordinateDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.starsBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(354, 49);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(434, 353);
            this.dataGridView.TabIndex = 9;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // starNameDataGridViewTextBoxColumn
            // 
            this.starNameDataGridViewTextBoxColumn.DataPropertyName = "StarName";
            this.starNameDataGridViewTextBoxColumn.HeaderText = "StarName";
            this.starNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starNameDataGridViewTextBoxColumn.Name = "starNameDataGridViewTextBoxColumn";
            this.starNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // starTypeDataGridViewTextBoxColumn
            // 
            this.starTypeDataGridViewTextBoxColumn.DataPropertyName = "StarType";
            this.starTypeDataGridViewTextBoxColumn.HeaderText = "StarType";
            this.starTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starTypeDataGridViewTextBoxColumn.Name = "starTypeDataGridViewTextBoxColumn";
            this.starTypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // starCoordinateDataGridViewTextBoxColumn
            // 
            this.starCoordinateDataGridViewTextBoxColumn.DataPropertyName = "StarCoordinate";
            this.starCoordinateDataGridViewTextBoxColumn.HeaderText = "StarCoordinate";
            this.starCoordinateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.starCoordinateDataGridViewTextBoxColumn.Name = "starCoordinateDataGridViewTextBoxColumn";
            this.starCoordinateDataGridViewTextBoxColumn.Width = 125;
            // 
            // starsBindingSource
            // 
            this.starsBindingSource.DataMember = "Stars";
            this.starsBindingSource.DataSource = this.stars9DataSet;
            // 
            // stars9DataSet
            // 
            this.stars9DataSet.DataSetName = "Stars9DataSet";
            this.stars9DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // starsTableAdapter
            // 
            this.starsTableAdapter.ClearBeforeFill = true;
            // 
            // NewStar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtEmpAdd);
            this.Controls.Add(this.txtEmpCity);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NewStar";
            this.Text = "New Star";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.starsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stars9DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmpName;
        private System.Windows.Forms.TextBox txtEmpCity;
        private System.Windows.Forms.TextBox txtEmpAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridView;
        private Stars9DataSet stars9DataSet;
        private System.Windows.Forms.BindingSource starsBindingSource;
        private Stars9DataSetTableAdapters.StarsTableAdapter starsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn starNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn starCoordinateDataGridViewTextBoxColumn;
    }
}

