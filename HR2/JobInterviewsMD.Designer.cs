namespace HR2
{
    partial class JobInterviewsMD
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
            System.Windows.Forms.Label jobIDLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label numberOfCandidatesLabel;
            System.Windows.Forms.Label salaryLabel;
            System.Windows.Forms.Label interviewIDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobInterviewsMD));
            this.courseDatabaseDataSet = new HR2.CourseDatabaseDataSet();
            this.jobBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jobTableAdapter = new HR2.CourseDatabaseDataSetTableAdapters.JobTableAdapter();
            this.tableAdapterManager = new HR2.CourseDatabaseDataSetTableAdapters.TableAdapterManager();
            this.interviewTableAdapter = new HR2.CourseDatabaseDataSetTableAdapters.InterviewTableAdapter();
            this.jobBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.jobBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.jobIDTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.numberOfCandidatesTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.interviewIDTextBox = new System.Windows.Forms.TextBox();
            this.interviewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interviewDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            jobIDLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            numberOfCandidatesLabel = new System.Windows.Forms.Label();
            salaryLabel = new System.Windows.Forms.Label();
            interviewIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingNavigator)).BeginInit();
            this.jobBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interviewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // jobIDLabel
            // 
            jobIDLabel.AutoSize = true;
            jobIDLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            jobIDLabel.ForeColor = System.Drawing.Color.White;
            jobIDLabel.Location = new System.Drawing.Point(27, 62);
            jobIDLabel.Name = "jobIDLabel";
            jobIDLabel.Size = new System.Drawing.Size(56, 19);
            jobIDLabel.TabIndex = 1;
            jobIDLabel.Text = "Job ID:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titleLabel.ForeColor = System.Drawing.Color.White;
            titleLabel.Location = new System.Drawing.Point(27, 90);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(38, 19);
            titleLabel.TabIndex = 3;
            titleLabel.Text = "Title:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descriptionLabel.ForeColor = System.Drawing.Color.White;
            descriptionLabel.Location = new System.Drawing.Point(27, 118);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(89, 19);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "Description:";
            // 
            // numberOfCandidatesLabel
            // 
            numberOfCandidatesLabel.AutoSize = true;
            numberOfCandidatesLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            numberOfCandidatesLabel.ForeColor = System.Drawing.Color.White;
            numberOfCandidatesLabel.Location = new System.Drawing.Point(27, 146);
            numberOfCandidatesLabel.Name = "numberOfCandidatesLabel";
            numberOfCandidatesLabel.Size = new System.Drawing.Size(174, 19);
            numberOfCandidatesLabel.TabIndex = 7;
            numberOfCandidatesLabel.Text = "Number Of Candidates:";
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            salaryLabel.ForeColor = System.Drawing.Color.White;
            salaryLabel.Location = new System.Drawing.Point(27, 174);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new System.Drawing.Size(55, 19);
            salaryLabel.TabIndex = 9;
            salaryLabel.Text = "Salary:";
            // 
            // interviewIDLabel
            // 
            interviewIDLabel.AutoSize = true;
            interviewIDLabel.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            interviewIDLabel.ForeColor = System.Drawing.Color.White;
            interviewIDLabel.Location = new System.Drawing.Point(27, 202);
            interviewIDLabel.Name = "interviewIDLabel";
            interviewIDLabel.Size = new System.Drawing.Size(92, 19);
            interviewIDLabel.TabIndex = 11;
            interviewIDLabel.Text = "Interview ID:";
            // 
            // courseDatabaseDataSet
            // 
            this.courseDatabaseDataSet.DataSetName = "CourseDatabaseDataSet";
            this.courseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jobBindingSource
            // 
            this.jobBindingSource.DataMember = "Job";
            this.jobBindingSource.DataSource = this.courseDatabaseDataSet;
            // 
            // jobTableAdapter
            // 
            this.jobTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CandidatesTableAdapter = null;
            this.tableAdapterManager.DeadlinesTableAdapter = null;
            this.tableAdapterManager.InterviewTableAdapter = this.interviewTableAdapter;
            this.tableAdapterManager.JobTableAdapter = this.jobTableAdapter;
            this.tableAdapterManager.UpdateOrder = HR2.CourseDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // interviewTableAdapter
            // 
            this.interviewTableAdapter.ClearBeforeFill = true;
            // 
            // jobBindingNavigator
            // 
            this.jobBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.jobBindingNavigator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(82)))));
            this.jobBindingNavigator.BindingSource = this.jobBindingSource;
            this.jobBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.jobBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.jobBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.jobBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.jobBindingNavigatorSaveItem});
            this.jobBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.jobBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.jobBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.jobBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.jobBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.jobBindingNavigator.Name = "jobBindingNavigator";
            this.jobBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.jobBindingNavigator.Size = new System.Drawing.Size(949, 27);
            this.jobBindingNavigator.TabIndex = 0;
            this.jobBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(82)))));
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
            // jobBindingNavigatorSaveItem
            // 
            this.jobBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.jobBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("jobBindingNavigatorSaveItem.Image")));
            this.jobBindingNavigatorSaveItem.Name = "jobBindingNavigatorSaveItem";
            this.jobBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.jobBindingNavigatorSaveItem.Text = "Save Data";
            this.jobBindingNavigatorSaveItem.Click += new System.EventHandler(this.jobBindingNavigatorSaveItem_Click);
            // 
            // jobIDTextBox
            // 
            this.jobIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "JobID", true));
            this.jobIDTextBox.Location = new System.Drawing.Point(223, 59);
            this.jobIDTextBox.Name = "jobIDTextBox";
            this.jobIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.jobIDTextBox.TabIndex = 2;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(223, 87);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(100, 22);
            this.titleTextBox.TabIndex = 4;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(223, 115);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // numberOfCandidatesTextBox
            // 
            this.numberOfCandidatesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "NumberOfCandidates", true));
            this.numberOfCandidatesTextBox.Location = new System.Drawing.Point(223, 143);
            this.numberOfCandidatesTextBox.Name = "numberOfCandidatesTextBox";
            this.numberOfCandidatesTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberOfCandidatesTextBox.TabIndex = 8;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "Salary", true));
            this.salaryTextBox.Location = new System.Drawing.Point(223, 171);
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(100, 22);
            this.salaryTextBox.TabIndex = 10;
            // 
            // interviewIDTextBox
            // 
            this.interviewIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.jobBindingSource, "InterviewID", true));
            this.interviewIDTextBox.Location = new System.Drawing.Point(223, 199);
            this.interviewIDTextBox.Name = "interviewIDTextBox";
            this.interviewIDTextBox.Size = new System.Drawing.Size(100, 22);
            this.interviewIDTextBox.TabIndex = 12;
            // 
            // interviewBindingSource
            // 
            this.interviewBindingSource.DataMember = "FK_Interview_Job";
            this.interviewBindingSource.DataSource = this.jobBindingSource;
            // 
            // interviewDataGridView
            // 
            this.interviewDataGridView.AutoGenerateColumns = false;
            this.interviewDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.interviewDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interviewDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.interviewDataGridView.DataSource = this.interviewBindingSource;
            this.interviewDataGridView.Location = new System.Drawing.Point(371, 48);
            this.interviewDataGridView.Name = "interviewDataGridView";
            this.interviewDataGridView.RowHeadersWidth = 51;
            this.interviewDataGridView.RowTemplate.Height = 24;
            this.interviewDataGridView.Size = new System.Drawing.Size(548, 220);
            this.interviewDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "InterviewID";
            this.dataGridViewTextBoxColumn1.HeaderText = "InterviewID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "JobID";
            this.dataGridViewTextBoxColumn2.HeaderText = "JobID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Slot";
            this.dataGridViewTextBoxColumn3.HeaderText = "Slot";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ApprovedCandidates_till_now";
            this.dataGridViewTextBoxColumn4.HeaderText = "ApprovedCandidates_till_now";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PendingCandidates_till_now";
            this.dataGridViewTextBoxColumn5.HeaderText = "PendingCandidates_till_now";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(82)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBack.Location = new System.Drawing.Point(592, 108);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(130, 57);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back to Menu";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // JobInterviewsMD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.interviewDataGridView);
            this.Controls.Add(jobIDLabel);
            this.Controls.Add(this.jobIDTextBox);
            this.Controls.Add(titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(numberOfCandidatesLabel);
            this.Controls.Add(this.numberOfCandidatesTextBox);
            this.Controls.Add(salaryLabel);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(interviewIDLabel);
            this.Controls.Add(this.interviewIDTextBox);
            this.Controls.Add(this.jobBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "JobInterviewsMD";
            this.Text = "JobInterviewsMD";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.JobInterviewsMD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobBindingNavigator)).EndInit();
            this.jobBindingNavigator.ResumeLayout(false);
            this.jobBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interviewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interviewDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CourseDatabaseDataSet courseDatabaseDataSet;
        private System.Windows.Forms.BindingSource jobBindingSource;
        private CourseDatabaseDataSetTableAdapters.JobTableAdapter jobTableAdapter;
        private CourseDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator jobBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton jobBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox jobIDTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox numberOfCandidatesTextBox;
        private System.Windows.Forms.TextBox salaryTextBox;
        private System.Windows.Forms.TextBox interviewIDTextBox;
        private CourseDatabaseDataSetTableAdapters.InterviewTableAdapter interviewTableAdapter;
        private System.Windows.Forms.BindingSource interviewBindingSource;
        private System.Windows.Forms.DataGridView interviewDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btnBack;
    }
}