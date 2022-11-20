namespace MailCourier
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
            this.lbMessage = new System.Windows.Forms.ListBox();
            this.btnListMailTasks = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NextRunning = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRunTask = new System.Windows.Forms.Button();
            this.btnStartTask = new System.Windows.Forms.Button();
            this.btnStopTask = new System.Windows.Forms.Button();
            this.ısRunningDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ısStartedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.secondDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailTaskBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMessage
            // 
            this.lbMessage.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lbMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbMessage.FormattingEnabled = true;
            this.lbMessage.ItemHeight = 20;
            this.lbMessage.Location = new System.Drawing.Point(0, 306);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(800, 144);
            this.lbMessage.TabIndex = 0;
            // 
            // btnListMailTasks
            // 
            this.btnListMailTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListMailTasks.Location = new System.Drawing.Point(0, 0);
            this.btnListMailTasks.Name = "btnListMailTasks";
            this.btnListMailTasks.Size = new System.Drawing.Size(800, 36);
            this.btnListMailTasks.TabIndex = 1;
            this.btnListMailTasks.Text = "List Mail Tasks";
            this.btnListMailTasks.UseVisualStyleBackColor = true;
            this.btnListMailTasks.Click += new System.EventHandler(this.btnListMailTasks_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ısRunningDataGridViewCheckBoxColumn,
            this.ısStartedDataGridViewCheckBoxColumn,
            this.secondDataGridViewTextBoxColumn,
            this.NextRunning});
            this.dataGridView1.DataSource = this.mailTaskBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 202);
            this.dataGridView1.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 125;
            // 
            // NextRunning
            // 
            this.NextRunning.DataPropertyName = "NextRunning";
            this.NextRunning.HeaderText = "NextRunning";
            this.NextRunning.MinimumWidth = 6;
            this.NextRunning.Name = "NextRunning";
            this.NextRunning.ReadOnly = true;
            this.NextRunning.Width = 125;
            // 
            // btnRunTask
            // 
            this.btnRunTask.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRunTask.Enabled = false;
            this.btnRunTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRunTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRunTask.Location = new System.Drawing.Point(0, 61);
            this.btnRunTask.Name = "btnRunTask";
            this.btnRunTask.Size = new System.Drawing.Size(99, 37);
            this.btnRunTask.TabIndex = 3;
            this.btnRunTask.Text = "Run";
            this.btnRunTask.UseVisualStyleBackColor = false;
            this.btnRunTask.Click += new System.EventHandler(this.btnRunTask_Click);
            // 
            // btnStartTask
            // 
            this.btnStartTask.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStartTask.Enabled = false;
            this.btnStartTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStartTask.Location = new System.Drawing.Point(105, 61);
            this.btnStartTask.Name = "btnStartTask";
            this.btnStartTask.Size = new System.Drawing.Size(99, 37);
            this.btnStartTask.TabIndex = 3;
            this.btnStartTask.Text = "Start";
            this.btnStartTask.UseVisualStyleBackColor = false;
            this.btnStartTask.Click += new System.EventHandler(this.btnStartTask_Click);
            // 
            // btnStopTask
            // 
            this.btnStopTask.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnStopTask.Enabled = false;
            this.btnStopTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopTask.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStopTask.Location = new System.Drawing.Point(210, 61);
            this.btnStopTask.Name = "btnStopTask";
            this.btnStopTask.Size = new System.Drawing.Size(99, 37);
            this.btnStopTask.TabIndex = 3;
            this.btnStopTask.Text = "Stop";
            this.btnStopTask.UseVisualStyleBackColor = false;
            this.btnStopTask.Click += new System.EventHandler(this.btnStopTask_Click);
            // 
            // ısRunningDataGridViewCheckBoxColumn
            // 
            this.ısRunningDataGridViewCheckBoxColumn.DataPropertyName = "IsRunning";
            this.ısRunningDataGridViewCheckBoxColumn.HeaderText = "IsRunning";
            this.ısRunningDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ısRunningDataGridViewCheckBoxColumn.Name = "ısRunningDataGridViewCheckBoxColumn";
            this.ısRunningDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ısRunningDataGridViewCheckBoxColumn.Width = 125;
            // 
            // ısStartedDataGridViewCheckBoxColumn
            // 
            this.ısStartedDataGridViewCheckBoxColumn.DataPropertyName = "IsStarted";
            this.ısStartedDataGridViewCheckBoxColumn.HeaderText = "IsStarted";
            this.ısStartedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.ısStartedDataGridViewCheckBoxColumn.Name = "ısStartedDataGridViewCheckBoxColumn";
            this.ısStartedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.ısStartedDataGridViewCheckBoxColumn.Width = 125;
            // 
            // secondDataGridViewTextBoxColumn
            // 
            this.secondDataGridViewTextBoxColumn.DataPropertyName = "Second";
            this.secondDataGridViewTextBoxColumn.HeaderText = "Second";
            this.secondDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.secondDataGridViewTextBoxColumn.Name = "secondDataGridViewTextBoxColumn";
            this.secondDataGridViewTextBoxColumn.ReadOnly = true;
            this.secondDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailTaskBindingSource
            // 
            this.mailTaskBindingSource.AllowNew = false;
            this.mailTaskBindingSource.DataSource = typeof(MailCourier.MailTask);
            this.mailTaskBindingSource.CurrentItemChanged += new System.EventHandler(this.mailTaskBindingSource_CurrentItemChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnStopTask);
            this.Controls.Add(this.btnStartTask);
            this.Controls.Add(this.btnRunTask);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnListMailTasks);
            this.Controls.Add(this.lbMessage);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mailTaskBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbMessage;
        private System.Windows.Forms.Button btnListMailTasks;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource mailTaskBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısRunningDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ısStartedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NextRunning;
        private System.Windows.Forms.Button btnRunTask;
        private System.Windows.Forms.Button btnStartTask;
        private System.Windows.Forms.Button btnStopTask;
    }
}

