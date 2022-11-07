
namespace ToDue
{
    partial class homePage
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblTaskHeader = new System.Windows.Forms.Label();
            this.btnAddNewTask = new System.Windows.Forms.Button();
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cboxSortBy = new System.Windows.Forms.ComboBox();
            this.btnTask1 = new System.Windows.Forms.Button();
            this.btnTask2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(287, 70);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(125, 45);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "To Due";
            // 
            // lblTaskHeader
            // 
            this.lblTaskHeader.AutoSize = true;
            this.lblTaskHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaskHeader.Location = new System.Drawing.Point(75, 154);
            this.lblTaskHeader.Name = "lblTaskHeader";
            this.lblTaskHeader.Size = new System.Drawing.Size(67, 19);
            this.lblTaskHeader.TabIndex = 1;
            this.lblTaskHeader.Text = "Task List:";
            // 
            // btnAddNewTask
            // 
            this.btnAddNewTask.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(188)))), ((int)(((byte)(148)))));
            this.btnAddNewTask.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(198)))), ((int)(((byte)(214)))));
            this.btnAddNewTask.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddNewTask.Location = new System.Drawing.Point(422, 154);
            this.btnAddNewTask.Name = "btnAddNewTask";
            this.btnAddNewTask.Size = new System.Drawing.Size(200, 37);
            this.btnAddNewTask.TabIndex = 2;
            this.btnAddNewTask.Text = "Add New Task";
            this.btnAddNewTask.UseVisualStyleBackColor = false;
            this.btnAddNewTask.Click += new System.EventHandler(this.btnAddNewTask_Click);
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSortBy.Location = new System.Drawing.Point(419, 219);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(48, 15);
            this.lblSortBy.TabIndex = 3;
            this.lblSortBy.Text = "Sort By:";
            // 
            // cboxSortBy
            // 
            this.cboxSortBy.BackColor = System.Drawing.Color.White;
            this.cboxSortBy.FormattingEnabled = true;
            this.cboxSortBy.Location = new System.Drawing.Point(473, 217);
            this.cboxSortBy.Name = "cboxSortBy";
            this.cboxSortBy.Size = new System.Drawing.Size(149, 21);
            this.cboxSortBy.TabIndex = 4;
            this.cboxSortBy.SelectedIndexChanged += new System.EventHandler(this.cboxSortBy_SelectedIndexChanged);
            // 
            // btnTask1
            // 
            this.btnTask1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(167)))));
            this.btnTask1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask1.Location = new System.Drawing.Point(79, 197);
            this.btnTask1.Name = "btnTask1";
            this.btnTask1.Size = new System.Drawing.Size(204, 37);
            this.btnTask1.TabIndex = 5;
            this.btnTask1.Text = "Study @ Summermoon";
            this.btnTask1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask1.UseVisualStyleBackColor = false;
            // 
            // btnTask2
            // 
            this.btnTask2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(199)))), ((int)(((byte)(167)))));
            this.btnTask2.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTask2.Location = new System.Drawing.Point(79, 240);
            this.btnTask2.Name = "btnTask2";
            this.btnTask2.Size = new System.Drawing.Size(204, 37);
            this.btnTask2.TabIndex = 6;
            this.btnTask2.Text = "Deca Club Meeting";
            this.btnTask2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTask2.UseVisualStyleBackColor = false;
            // 
            // homePage
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(233)))), ((int)(((byte)(210)))));
            this.ClientSize = new System.Drawing.Size(684, 711);
            this.Controls.Add(this.btnTask2);
            this.Controls.Add(this.btnTask1);
            this.Controls.Add(this.cboxSortBy);
            this.Controls.Add(this.lblSortBy);
            this.Controls.Add(this.btnAddNewTask);
            this.Controls.Add(this.lblTaskHeader);
            this.Controls.Add(this.lblTitle);
            this.Name = "homePage";
            this.Text = "homePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblTaskHeader;
        private System.Windows.Forms.Button btnAddNewTask;
        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cboxSortBy;
        private System.Windows.Forms.Button btnTask1;
        private System.Windows.Forms.Button btnTask2;
    }
}