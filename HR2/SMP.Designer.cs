namespace HR2
{
    partial class SMP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMP));
            this.cbJobtitle = new System.Windows.Forms.ComboBox();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courseDatabaseDataSet = new HR2.CourseDatabaseDataSet();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.statusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.courseDatabaseDataSet1 = new HR2.CourseDatabaseDataSet();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatesTableAdapter = new HR2.CourseDatabaseDataSetTableAdapters.CandidatesTableAdapter();
            this.tableAdapterManager = new HR2.CourseDatabaseDataSetTableAdapters.TableAdapterManager();
            this.jobTableAdapter = new HR2.CourseDatabaseDataSetTableAdapters.JobTableAdapter();
            this.candidatesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.candidatesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.candidatesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_Excel = new System.Windows.Forms.Button();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Search = new System.Windows.Forms.Button();
            this.statusTableAdapter1 = new HR2.CourseDatabaseDataSetTableAdapters.StatusTableAdapter();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingNavigator)).BeginInit();
            this.candidatesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbJobtitle
            // 
            this.cbJobtitle.DataSource = this.jobBindingSource;
            this.cbJobtitle.DisplayMember = "Title";
            this.cbJobtitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbJobtitle.FormattingEnabled = true;
            this.cbJobtitle.Location = new System.Drawing.Point(158, 55);
            this.cbJobtitle.Name = "cbJobtitle";
            this.cbJobtitle.Size = new System.Drawing.Size(121, 24);
            this.cbJobtitle.TabIndex = 0;
            this.cbJobtitle.ValueMember = "JobID";
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.courseDatabaseDataSet;
            // 
            // courseDatabaseDataSet
            // 
            this.courseDatabaseDataSet.DataSetName = "CourseDatabaseDataSet";
            this.courseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cbStatus
            // 
            this.cbStatus.DataSource = this.statusBindingSource1;
            this.cbStatus.DisplayMember = "Status";
            this.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Location = new System.Drawing.Point(158, 109);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 24);
            this.cbStatus.TabIndex = 1;
            this.cbStatus.ValueMember = "Status";
            this.cbStatus.SelectedIndexChanged += new System.EventHandler(this.cbStatus_SelectedIndexChanged);
            // 
            // statusBindingSource1
            // 
            this.statusBindingSource1.DataMember = "Status";
            this.statusBindingSource1.DataSource = this.courseDatabaseDataSet1;
            // 
            // courseDatabaseDataSet1
            // 
            this.courseDatabaseDataSet1.DataSetName = "CourseDatabaseDataSet";
            this.courseDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "Status";
            this.statusBindingSource.DataSource = this.courseDatabaseDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Job Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Status";
            // 
            // candidatesBindingSource
            // 
            this.candidatesBindingSource.DataMember = "Candidates";
            this.candidatesBindingSource.DataSource = this.courseDatabaseDataSet;
            // 
            // candidatesTableAdapter
            // 
            this.candidatesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CandidatesTableAdapter = this.candidatesTableAdapter;
            this.tableAdapterManager.DeadlinesTableAdapter = null;
            this.tableAdapterManager.InterviewTableAdapter = null;
            this.tableAdapterManager.JobTableAdapter = this.jobTableAdapter;
            this.tableAdapterManager.UpdateOrder = HR2.CourseDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // candidatesBindingNavigator
            // 
            this.candidatesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.candidatesBindingNavigator.BindingSource = this.candidatesBindingSource;
            this.candidatesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.candidatesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.candidatesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.candidatesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.candidatesBindingNavigatorSaveItem});
            this.candidatesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.candidatesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.candidatesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.candidatesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.candidatesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.candidatesBindingNavigator.Name = "candidatesBindingNavigator";
            this.candidatesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.candidatesBindingNavigator.Size = new System.Drawing.Size(1048, 27);
            this.candidatesBindingNavigator.TabIndex = 4;
            this.candidatesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // candidatesBindingNavigatorSaveItem
            // 
            this.candidatesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.candidatesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("candidatesBindingNavigatorSaveItem.Image")));
            this.candidatesBindingNavigatorSaveItem.Name = "candidatesBindingNavigatorSaveItem";
            this.candidatesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.candidatesBindingNavigatorSaveItem.Text = "Save Data";
            this.candidatesBindingNavigatorSaveItem.Click += new System.EventHandler(this.candidatesBindingNavigatorSaveItem_Click);
            // 
            // candidatesDataGridView
            // 
            this.candidatesDataGridView.AutoGenerateColumns = false;
            this.candidatesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.candidatesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.candidatesDataGridView.DataSource = this.candidatesBindingSource;
            this.candidatesDataGridView.Location = new System.Drawing.Point(31, 174);
            this.candidatesDataGridView.Name = "candidatesDataGridView";
            this.candidatesDataGridView.RowHeadersWidth = 51;
            this.candidatesDataGridView.RowTemplate.Height = 24;
            this.candidatesDataGridView.Size = new System.Drawing.Size(935, 283);
            this.candidatesDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CandidateID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CandidateID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn4.HeaderText = "Address";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Country";
            this.dataGridViewTextBoxColumn5.HeaderText = "Country";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "JobID";
            this.dataGridViewTextBoxColumn6.HeaderText = "JobID";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // button_Excel
            // 
            this.button_Excel.Location = new System.Drawing.Point(741, 63);
            this.button_Excel.Name = "button_Excel";
            this.button_Excel.Size = new System.Drawing.Size(75, 23);
            this.button_Excel.TabIndex = 6;
            this.button_Excel.Text = "Excel";
            this.button_Excel.UseVisualStyleBackColor = true;
            this.button_Excel.Click += new System.EventHandler(this.button_Excel_Click);
            // 
            // button_Clear
            // 
            this.button_Clear.Location = new System.Drawing.Point(323, 83);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(75, 23);
            this.button_Clear.TabIndex = 7;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(323, 112);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 8;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // statusTableAdapter1
            // 
            this.statusTableAdapter1.ClearBeforeFill = true;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(851, 482);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(115, 31);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // SMP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 525);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.button_Clear);
            this.Controls.Add(this.button_Excel);
            this.Controls.Add(this.candidatesDataGridView);
            this.Controls.Add(this.candidatesBindingNavigator);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.cbJobtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SMP";
            this.Text = "SMP";
            this.Load += new System.EventHandler(this.SMP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingNavigator)).EndInit();
            this.candidatesBindingNavigator.ResumeLayout(false);
            this.candidatesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbJobtitle;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CourseDatabaseDataSet courseDatabaseDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private CourseDatabaseDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private CourseDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator candidatesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton candidatesBindingNavigatorSaveItem;
        private CourseDatabaseDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private System.Windows.Forms.DataGridView candidatesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.Button button_Excel;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Search;
        private CourseDatabaseDataSetTableAdapters.StatusTableAdapter statusTableAdapter1;
        private CourseDatabaseDataSet courseDatabaseDataSet1;
        private System.Windows.Forms.BindingSource statusBindingSource1;
        private System.Windows.Forms.Button btnBack;
    }
}