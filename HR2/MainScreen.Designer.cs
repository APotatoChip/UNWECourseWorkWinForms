namespace HR2
{
    partial class mainScreen
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
            this.courseDatabaseDataSet = new HR2.CourseDatabaseDataSet();
            this.candidatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.candidatesTableAdapter = new HR2.CourseDatabaseDataSetTableAdapters.CandidatesTableAdapter();
            this.tableAdapterManager = new HR2.CourseDatabaseDataSetTableAdapters.TableAdapterManager();
            this.candidatesFormBtn = new System.Windows.Forms.Button();
            this.SMP = new System.Windows.Forms.Button();
            this.SOP = new System.Windows.Forms.Button();
            this.jobsFormBtn = new System.Windows.Forms.Button();
            this.menuLabel = new System.Windows.Forms.Label();
            this.jobCandidatesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.jobInterviewsbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // courseDatabaseDataSet
            // 
            this.courseDatabaseDataSet.DataSetName = "CourseDatabaseDataSet";
            this.courseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.tableAdapterManager.JobTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HR2.CourseDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // candidatesFormBtn
            // 
            this.candidatesFormBtn.BackColor = System.Drawing.Color.White;
            this.candidatesFormBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatesFormBtn.Location = new System.Drawing.Point(416, 144);
            this.candidatesFormBtn.Margin = new System.Windows.Forms.Padding(4);
            this.candidatesFormBtn.Name = "candidatesFormBtn";
            this.candidatesFormBtn.Size = new System.Drawing.Size(288, 58);
            this.candidatesFormBtn.TabIndex = 1;
            this.candidatesFormBtn.Text = "Candidates Form";
            this.candidatesFormBtn.UseVisualStyleBackColor = false;
            this.candidatesFormBtn.Click += new System.EventHandler(this.candidatesFormBtn_Click);
            // 
            // SMP
            // 
            this.SMP.BackColor = System.Drawing.Color.White;
            this.SMP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMP.Location = new System.Drawing.Point(416, 405);
            this.SMP.Margin = new System.Windows.Forms.Padding(4);
            this.SMP.Name = "SMP";
            this.SMP.Size = new System.Drawing.Size(288, 58);
            this.SMP.TabIndex = 2;
            this.SMP.Text = "Search by Multiple Params";
            this.SMP.UseVisualStyleBackColor = false;
            this.SMP.Click += new System.EventHandler(this.SMP_Click);
            // 
            // SOP
            // 
            this.SOP.BackColor = System.Drawing.Color.White;
            this.SOP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOP.Location = new System.Drawing.Point(416, 471);
            this.SOP.Margin = new System.Windows.Forms.Padding(4);
            this.SOP.Name = "SOP";
            this.SOP.Size = new System.Drawing.Size(288, 58);
            this.SOP.TabIndex = 4;
            this.SOP.Text = "Search by One Param";
            this.SOP.UseVisualStyleBackColor = false;
            this.SOP.Click += new System.EventHandler(this.SOP_Click);
            // 
            // jobsFormBtn
            // 
            this.jobsFormBtn.BackColor = System.Drawing.Color.White;
            this.jobsFormBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsFormBtn.Location = new System.Drawing.Point(416, 210);
            this.jobsFormBtn.Margin = new System.Windows.Forms.Padding(4);
            this.jobsFormBtn.Name = "jobsFormBtn";
            this.jobsFormBtn.Size = new System.Drawing.Size(288, 58);
            this.jobsFormBtn.TabIndex = 7;
            this.jobsFormBtn.Text = "Jobs Form";
            this.jobsFormBtn.UseVisualStyleBackColor = false;
            this.jobsFormBtn.Click += new System.EventHandler(this.jobsFormBtn_Click);
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.menuLabel.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(82)))));
            this.menuLabel.Location = new System.Drawing.Point(416, 47);
            this.menuLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(288, 58);
            this.menuLabel.TabIndex = 8;
            this.menuLabel.Text = "Main Menu";
            // 
            // jobCandidatesBtn
            // 
            this.jobCandidatesBtn.BackColor = System.Drawing.Color.White;
            this.jobCandidatesBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobCandidatesBtn.Location = new System.Drawing.Point(416, 276);
            this.jobCandidatesBtn.Name = "jobCandidatesBtn";
            this.jobCandidatesBtn.Size = new System.Drawing.Size(288, 58);
            this.jobCandidatesBtn.TabIndex = 10;
            this.jobCandidatesBtn.Text = "Job Candidates MD";
            this.jobCandidatesBtn.UseVisualStyleBackColor = false;
            this.jobCandidatesBtn.Click += new System.EventHandler(this.jobCandidatesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1082, 1);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(73, 55);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // jobInterviewsbtn
            // 
            this.jobInterviewsbtn.BackColor = System.Drawing.Color.White;
            this.jobInterviewsbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobInterviewsbtn.Location = new System.Drawing.Point(416, 340);
            this.jobInterviewsbtn.Name = "jobInterviewsbtn";
            this.jobInterviewsbtn.Size = new System.Drawing.Size(288, 58);
            this.jobInterviewsbtn.TabIndex = 14;
            this.jobInterviewsbtn.Text = "Job Interviews MD";
            this.jobInterviewsbtn.UseVisualStyleBackColor = false;
            this.jobInterviewsbtn.Click += new System.EventHandler(this.jobInterviewsbtn_Click);
            // 
            // mainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 586);
            this.Controls.Add(this.jobInterviewsbtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.jobCandidatesBtn);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.jobsFormBtn);
            this.Controls.Add(this.SOP);
            this.Controls.Add(this.SMP);
            this.Controls.Add(this.candidatesFormBtn);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "mainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Screen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.candidatesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CourseDatabaseDataSet courseDatabaseDataSet;
        private System.Windows.Forms.BindingSource candidatesBindingSource;
        private CourseDatabaseDataSetTableAdapters.CandidatesTableAdapter candidatesTableAdapter;
        private CourseDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button candidatesFormBtn;
        private System.Windows.Forms.Button SMP;
        private System.Windows.Forms.Button SOP;
        private System.Windows.Forms.Button jobsFormBtn;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button jobCandidatesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button jobInterviewsbtn;
    }
}

