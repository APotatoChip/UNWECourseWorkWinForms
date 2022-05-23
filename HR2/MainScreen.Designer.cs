namespace HR2
{
    partial class hr2
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
            this.AED = new System.Windows.Forms.Button();
            this.SMP = new System.Windows.Forms.Button();
            this.SOP = new System.Windows.Forms.Button();
            this.jobsFormBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.mdBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
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
            // AED
            // 
            this.AED.BackColor = System.Drawing.Color.White;
            this.AED.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AED.Location = new System.Drawing.Point(632, 225);
            this.AED.Margin = new System.Windows.Forms.Padding(4);
            this.AED.Name = "AED";
            this.AED.Size = new System.Drawing.Size(288, 58);
            this.AED.TabIndex = 1;
            this.AED.Text = "Candidates Form";
            this.AED.UseVisualStyleBackColor = false;
            this.AED.Click += new System.EventHandler(this.AED_Click);
            // 
            // SMP
            // 
            this.SMP.BackColor = System.Drawing.Color.White;
            this.SMP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SMP.Location = new System.Drawing.Point(632, 448);
            this.SMP.Margin = new System.Windows.Forms.Padding(4);
            this.SMP.Name = "SMP";
            this.SMP.Size = new System.Drawing.Size(288, 58);
            this.SMP.TabIndex = 2;
            this.SMP.Text = "By Multiple Params";
            this.SMP.UseVisualStyleBackColor = false;
            this.SMP.Click += new System.EventHandler(this.SMP_Click);
            // 
            // SOP
            // 
            this.SOP.BackColor = System.Drawing.Color.White;
            this.SOP.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SOP.Location = new System.Drawing.Point(632, 531);
            this.SOP.Margin = new System.Windows.Forms.Padding(4);
            this.SOP.Name = "SOP";
            this.SOP.Size = new System.Drawing.Size(288, 58);
            this.SOP.TabIndex = 4;
            this.SOP.Text = "By One Param";
            this.SOP.UseVisualStyleBackColor = false;
            this.SOP.Click += new System.EventHandler(this.SOP_Click);
            // 
            // jobsFormBtn
            // 
            this.jobsFormBtn.BackColor = System.Drawing.Color.White;
            this.jobsFormBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jobsFormBtn.Location = new System.Drawing.Point(632, 294);
            this.jobsFormBtn.Margin = new System.Windows.Forms.Padding(4);
            this.jobsFormBtn.Name = "jobsFormBtn";
            this.jobsFormBtn.Size = new System.Drawing.Size(288, 58);
            this.jobsFormBtn.TabIndex = 7;
            this.jobsFormBtn.Text = "Jobs Form";
            this.jobsFormBtn.UseVisualStyleBackColor = false;
            this.jobsFormBtn.Click += new System.EventHandler(this.jobsAED_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(165)))), ((int)(((byte)(82)))));
            this.label3.Location = new System.Drawing.Point(641, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 58);
            this.label3.TabIndex = 8;
            this.label3.Text = "Main Menu";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // mdBtn
            // 
            this.mdBtn.BackColor = System.Drawing.Color.White;
            this.mdBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdBtn.Location = new System.Drawing.Point(632, 370);
            this.mdBtn.Name = "mdBtn";
            this.mdBtn.Size = new System.Drawing.Size(288, 58);
            this.mdBtn.TabIndex = 10;
            this.mdBtn.Text = "mdBtn";
            this.mdBtn.UseVisualStyleBackColor = false;
            this.mdBtn.Click += new System.EventHandler(this.mdBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.ForeColor = System.Drawing.Color.White;
            this.exitBtn.Location = new System.Drawing.Point(1457, 2);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(73, 55);
            this.exitBtn.TabIndex = 12;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // hr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1641, 647);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.mdBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.jobsFormBtn);
            this.Controls.Add(this.SOP);
            this.Controls.Add(this.SMP);
            this.Controls.Add(this.AED);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "hr2";
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
        private System.Windows.Forms.Button AED;
        private System.Windows.Forms.Button SMP;
        private System.Windows.Forms.Button SOP;
        private System.Windows.Forms.Button jobsFormBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button mdBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}

