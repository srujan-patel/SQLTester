namespace SQLTester
{
    partial class testerForm
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
            this.recordGridView = new System.Windows.Forms.DataGridView();
            this.executeButton = new System.Windows.Forms.Button();
            this.commandText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.allRecordsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recordGridView
            // 
            this.recordGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordGridView.Location = new System.Drawing.Point(63, 30);
            this.recordGridView.Name = "recordGridView";
            this.recordGridView.RowHeadersWidth = 51;
            this.recordGridView.RowTemplate.Height = 24;
            this.recordGridView.Size = new System.Drawing.Size(1045, 444);
            this.recordGridView.TabIndex = 0;
            // 
            // executeButton
            // 
            this.executeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executeButton.Location = new System.Drawing.Point(726, 520);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(210, 30);
            this.executeButton.TabIndex = 2;
            this.executeButton.Text = "Execute SQL Starement";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // commandText
            // 
            this.commandText.Location = new System.Drawing.Point(63, 499);
            this.commandText.Multiline = true;
            this.commandText.Name = "commandText";
            this.commandText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commandText.Size = new System.Drawing.Size(612, 129);
            this.commandText.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(732, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Record Count";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.Location = new System.Drawing.Point(909, 584);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(17, 18);
            this.countLabel.TabIndex = 5;
            this.countLabel.Text = "0";
            this.countLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // allRecordsButton
            // 
            this.allRecordsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allRecordsButton.Location = new System.Drawing.Point(942, 519);
            this.allRecordsButton.Name = "allRecordsButton";
            this.allRecordsButton.Size = new System.Drawing.Size(200, 31);
            this.allRecordsButton.TabIndex = 6;
            this.allRecordsButton.Text = "ShowRecords";
            this.allRecordsButton.UseVisualStyleBackColor = true;
            this.allRecordsButton.Click += new System.EventHandler(this.btnSqlClick);
            // 
            // testerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 776);
            this.Controls.Add(this.allRecordsButton);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.commandText);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.recordGridView);
            this.Name = "testerForm";
            this.Text = "SQL Command Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recordGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView recordGridView;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.TextBox commandText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Button allRecordsButton;
    }
}

