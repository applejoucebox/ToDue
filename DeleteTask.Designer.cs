
namespace ToDue
{
    partial class DeleteTask
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
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblDeleteConfirmation = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTaskName = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.lblExtendedDetails = new System.Windows.Forms.Label();
            this.lblXDetails = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDelete
            // 
            this.lblDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(309, 86);
            this.lblDelete.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(249, 58);
            this.lblDelete.TabIndex = 2;
            this.lblDelete.Text = "Delete Task";
            // 
            // lblDeleteConfirmation
            // 
            this.lblDeleteConfirmation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDeleteConfirmation.AutoSize = true;
            this.lblDeleteConfirmation.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteConfirmation.Location = new System.Drawing.Point(33, 190);
            this.lblDeleteConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteConfirmation.MinimumSize = new System.Drawing.Size(800, 0);
            this.lblDeleteConfirmation.Name = "lblDeleteConfirmation";
            this.lblDeleteConfirmation.Size = new System.Drawing.Size(800, 41);
            this.lblDeleteConfirmation.TabIndex = 3;
            this.lblDeleteConfirmation.Text = "delete";
            this.lblDeleteConfirmation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(215)))), ((int)(((byte)(214)))));
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(481, 313);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(164, 34);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(199)))));
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(665, 313);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 34);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Confirm Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(133, 369);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 23);
            this.label2.TabIndex = 24;
            this.label2.Text = "Task Name:";
            // 
            // lblTaskName
            // 
            this.lblTaskName.AutoSize = true;
            this.lblTaskName.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskName.Location = new System.Drawing.Point(300, 369);
            this.lblTaskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTaskName.Name = "lblTaskName";
            this.lblTaskName.Size = new System.Drawing.Size(100, 23);
            this.lblTaskName.TabIndex = 26;
            this.lblTaskName.Text = "placeholder";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDueDate.Location = new System.Drawing.Point(300, 431);
            this.lblDueDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(100, 23);
            this.lblDueDate.TabIndex = 28;
            this.lblDueDate.Text = "placeholder";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(133, 431);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 23);
            this.label4.TabIndex = 27;
            this.label4.Text = "Due Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(133, 492);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Priority:";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPriority.Location = new System.Drawing.Point(300, 492);
            this.lblPriority.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(100, 23);
            this.lblPriority.TabIndex = 30;
            this.lblPriority.Text = "placeholder";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(133, 553);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 23);
            this.label5.TabIndex = 31;
            this.label5.Text = "Subject:";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubject.Location = new System.Drawing.Point(300, 553);
            this.lblSubject.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(100, 23);
            this.lblSubject.TabIndex = 32;
            this.lblSubject.Text = "placeholder";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(133, 615);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 33;
            this.label6.Text = "Summary";
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(300, 615);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(100, 23);
            this.lblSummary.TabIndex = 34;
            this.lblSummary.Text = "placeholder";
            // 
            // lblExtendedDetails
            // 
            this.lblExtendedDetails.AutoSize = true;
            this.lblExtendedDetails.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExtendedDetails.Location = new System.Drawing.Point(133, 677);
            this.lblExtendedDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExtendedDetails.Name = "lblExtendedDetails";
            this.lblExtendedDetails.Size = new System.Drawing.Size(142, 23);
            this.lblExtendedDetails.TabIndex = 35;
            this.lblExtendedDetails.Text = "Extended Details:";
            // 
            // lblXDetails
            // 
            this.lblXDetails.AutoSize = true;
            this.lblXDetails.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblXDetails.Location = new System.Drawing.Point(300, 677);
            this.lblXDetails.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXDetails.Name = "lblXDetails";
            this.lblXDetails.Size = new System.Drawing.Size(100, 23);
            this.lblXDetails.TabIndex = 36;
            this.lblXDetails.Text = "placeholder";
            // 
            // DeleteTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(247)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(912, 875);
            this.Controls.Add(this.lblXDetails);
            this.Controls.Add(this.lblExtendedDetails);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSubject);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTaskName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDeleteConfirmation);
            this.Controls.Add(this.lblDelete);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeleteTask";
            this.Text = "DeleteTask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Label lblDeleteConfirmation;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lblTaskName;
        public System.Windows.Forms.Label lblDueDate;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblPriority;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label lblSubject;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lblSummary;
        public System.Windows.Forms.Label lblExtendedDetails;
        public System.Windows.Forms.Label lblXDetails;
    }
}