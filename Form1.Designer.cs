namespace LB2SPZ
{
    partial class Form1
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
            this.factoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mastersalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workersalaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.masterbenefitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workerbenefitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.factoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.remove_btn = new System.Windows.Forms.Button();
            this.merge_btn = new System.Windows.Forms.Button();
            this.employ_btn = new System.Windows.Forms.Button();
            this.retire_btn = new System.Windows.Forms.Button();
            this.master_cbx = new System.Windows.Forms.CheckBox();
            this.total_btn = new System.Windows.Forms.Button();
            this.compare_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.factoryNameDataGridViewTextBoxColumn,
            this.workersDataGridViewTextBoxColumn,
            this.districtsDataGridViewTextBoxColumn,
            this.mastersDataGridViewTextBoxColumn,
            this.mastersalaryDataGridViewTextBoxColumn,
            this.workersalaryDataGridViewTextBoxColumn,
            this.masterbenefitDataGridViewTextBoxColumn,
            this.workerbenefitDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.factoryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(886, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // factoryNameDataGridViewTextBoxColumn
            // 
            this.factoryNameDataGridViewTextBoxColumn.DataPropertyName = "factoryName";
            this.factoryNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.factoryNameDataGridViewTextBoxColumn.Name = "factoryNameDataGridViewTextBoxColumn";
            // 
            // workersDataGridViewTextBoxColumn
            // 
            this.workersDataGridViewTextBoxColumn.DataPropertyName = "Workers";
            this.workersDataGridViewTextBoxColumn.HeaderText = "Workers";
            this.workersDataGridViewTextBoxColumn.Name = "workersDataGridViewTextBoxColumn";
            // 
            // districtsDataGridViewTextBoxColumn
            // 
            this.districtsDataGridViewTextBoxColumn.DataPropertyName = "Districts";
            this.districtsDataGridViewTextBoxColumn.HeaderText = "Districts";
            this.districtsDataGridViewTextBoxColumn.Name = "districtsDataGridViewTextBoxColumn";
            // 
            // mastersDataGridViewTextBoxColumn
            // 
            this.mastersDataGridViewTextBoxColumn.DataPropertyName = "Masters";
            this.mastersDataGridViewTextBoxColumn.HeaderText = "Masters";
            this.mastersDataGridViewTextBoxColumn.Name = "mastersDataGridViewTextBoxColumn";
            // 
            // mastersalaryDataGridViewTextBoxColumn
            // 
            this.mastersalaryDataGridViewTextBoxColumn.DataPropertyName = "Master_salary";
            this.mastersalaryDataGridViewTextBoxColumn.HeaderText = "Master salary";
            this.mastersalaryDataGridViewTextBoxColumn.Name = "mastersalaryDataGridViewTextBoxColumn";
            // 
            // workersalaryDataGridViewTextBoxColumn
            // 
            this.workersalaryDataGridViewTextBoxColumn.DataPropertyName = "Worker_salary";
            this.workersalaryDataGridViewTextBoxColumn.HeaderText = "Worker salary";
            this.workersalaryDataGridViewTextBoxColumn.Name = "workersalaryDataGridViewTextBoxColumn";
            // 
            // masterbenefitDataGridViewTextBoxColumn
            // 
            this.masterbenefitDataGridViewTextBoxColumn.DataPropertyName = "Master_benefit";
            this.masterbenefitDataGridViewTextBoxColumn.HeaderText = "Master benefit";
            this.masterbenefitDataGridViewTextBoxColumn.Name = "masterbenefitDataGridViewTextBoxColumn";
            // 
            // workerbenefitDataGridViewTextBoxColumn
            // 
            this.workerbenefitDataGridViewTextBoxColumn.DataPropertyName = "Worker_benefit";
            this.workerbenefitDataGridViewTextBoxColumn.HeaderText = "Worker benefit";
            this.workerbenefitDataGridViewTextBoxColumn.Name = "workerbenefitDataGridViewTextBoxColumn";
            // 
            // factoryBindingSource
            // 
            this.factoryBindingSource.DataSource = typeof(LB2SPZ.Factory);
            // 
            // remove_btn
            // 
            this.remove_btn.Location = new System.Drawing.Point(742, 334);
            this.remove_btn.Name = "remove_btn";
            this.remove_btn.Size = new System.Drawing.Size(75, 23);
            this.remove_btn.TabIndex = 1;
            this.remove_btn.Text = "Remove";
            this.remove_btn.UseVisualStyleBackColor = true;
            this.remove_btn.Click += new System.EventHandler(this.remove_btn_click);
            // 
            // merge_btn
            // 
            this.merge_btn.Location = new System.Drawing.Point(823, 334);
            this.merge_btn.Name = "merge_btn";
            this.merge_btn.Size = new System.Drawing.Size(75, 23);
            this.merge_btn.TabIndex = 3;
            this.merge_btn.Text = "Merge";
            this.merge_btn.UseVisualStyleBackColor = true;
            this.merge_btn.Click += new System.EventHandler(this.merge_btn_click);
            // 
            // employ_btn
            // 
            this.employ_btn.Location = new System.Drawing.Point(199, 333);
            this.employ_btn.Name = "employ_btn";
            this.employ_btn.Size = new System.Drawing.Size(75, 23);
            this.employ_btn.TabIndex = 4;
            this.employ_btn.Text = "Employ";
            this.employ_btn.UseVisualStyleBackColor = true;
            this.employ_btn.Click += new System.EventHandler(this.employ_btn_click);
            // 
            // retire_btn
            // 
            this.retire_btn.Location = new System.Drawing.Point(280, 333);
            this.retire_btn.Name = "retire_btn";
            this.retire_btn.Size = new System.Drawing.Size(75, 23);
            this.retire_btn.TabIndex = 5;
            this.retire_btn.Text = "Retire";
            this.retire_btn.UseVisualStyleBackColor = true;
            this.retire_btn.Click += new System.EventHandler(this.retire_btn_click);
            // 
            // master_cbx
            // 
            this.master_cbx.AutoSize = true;
            this.master_cbx.Location = new System.Drawing.Point(127, 336);
            this.master_cbx.Name = "master_cbx";
            this.master_cbx.Size = new System.Drawing.Size(58, 17);
            this.master_cbx.TabIndex = 6;
            this.master_cbx.Text = "Master";
            this.master_cbx.UseVisualStyleBackColor = true;
            // 
            // total_btn
            // 
            this.total_btn.Location = new System.Drawing.Point(661, 334);
            this.total_btn.Name = "total_btn";
            this.total_btn.Size = new System.Drawing.Size(75, 23);
            this.total_btn.TabIndex = 7;
            this.total_btn.Text = "Total salary";
            this.total_btn.UseVisualStyleBackColor = true;
            this.total_btn.Click += new System.EventHandler(this.total_btn_click);
            // 
            // compare_btn
            // 
            this.compare_btn.Location = new System.Drawing.Point(580, 334);
            this.compare_btn.Name = "compare_btn";
            this.compare_btn.Size = new System.Drawing.Size(75, 23);
            this.compare_btn.TabIndex = 8;
            this.compare_btn.Text = "Compare";
            this.compare_btn.UseVisualStyleBackColor = true;
            this.compare_btn.Click += new System.EventHandler(this.compare_btn_click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(910, 379);
            this.Controls.Add(this.compare_btn);
            this.Controls.Add(this.total_btn);
            this.Controls.Add(this.master_cbx);
            this.Controls.Add(this.retire_btn);
            this.Controls.Add(this.employ_btn);
            this.Controls.Add(this.merge_btn);
            this.Controls.Add(this.remove_btn);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button remove_btn;
        private System.Windows.Forms.Button merge_btn;
        private System.Windows.Forms.Button employ_btn;
        private System.Windows.Forms.BindingSource factoryBindingSource;
        private System.Windows.Forms.Button retire_btn;
        private System.Windows.Forms.CheckBox master_cbx;
        private System.Windows.Forms.Button total_btn;
        private System.Windows.Forms.Button compare_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn districtsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mastersalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workersalaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn masterbenefitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workerbenefitDataGridViewTextBoxColumn;
    }
}

