namespace TaskManger
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
            this.Titlelabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FinishedList = new System.Windows.Forms.ListBox();
            this.ProgressList = new System.Windows.Forms.ListBox();
            this.PendingList = new System.Windows.Forms.ListBox();
            this.FinishedLbl = new System.Windows.Forms.Label();
            this.Taskcombo = new System.Windows.Forms.ComboBox();
            this.TaskInput = new System.Windows.Forms.TextBox();
            this.Progresslbl = new System.Windows.Forms.Label();
            this.Pendinglbl = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Titlelabel
            // 
            this.Titlelabel.AutoSize = true;
            this.Titlelabel.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titlelabel.Location = new System.Drawing.Point(276, 29);
            this.Titlelabel.Name = "Titlelabel";
            this.Titlelabel.Size = new System.Drawing.Size(235, 44);
            this.Titlelabel.TabIndex = 0;
            this.Titlelabel.Text = "Task Manager";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F);
            this.label1.Location = new System.Drawing.Point(60, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 18F);
            this.label2.Location = new System.Drawing.Point(60, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 44);
            this.label2.TabIndex = 2;
            this.label2.Text = "Task Type";
            // 
            // FinishedList
            // 
            this.FinishedList.FormattingEnabled = true;
            this.FinishedList.ItemHeight = 19;
            this.FinishedList.Location = new System.Drawing.Point(46, 383);
            this.FinishedList.Name = "FinishedList";
            this.FinishedList.Size = new System.Drawing.Size(227, 251);
            this.FinishedList.TabIndex = 3;
            // 
            // ProgressList
            // 
            this.ProgressList.FormattingEnabled = true;
            this.ProgressList.ItemHeight = 19;
            this.ProgressList.Location = new System.Drawing.Point(302, 383);
            this.ProgressList.Name = "ProgressList";
            this.ProgressList.Size = new System.Drawing.Size(227, 251);
            this.ProgressList.TabIndex = 4;
            // 
            // PendingList
            // 
            this.PendingList.FormattingEnabled = true;
            this.PendingList.ItemHeight = 19;
            this.PendingList.Location = new System.Drawing.Point(559, 383);
            this.PendingList.Name = "PendingList";
            this.PendingList.Size = new System.Drawing.Size(227, 251);
            this.PendingList.TabIndex = 5;
            // 
            // FinishedLbl
            // 
            this.FinishedLbl.AutoSize = true;
            this.FinishedLbl.Font = new System.Drawing.Font("Candara", 14F);
            this.FinishedLbl.Location = new System.Drawing.Point(40, 345);
            this.FinishedLbl.Name = "FinishedLbl";
            this.FinishedLbl.Size = new System.Drawing.Size(141, 35);
            this.FinishedLbl.TabIndex = 6;
            this.FinishedLbl.Text = "In Finished";
            // 
            // Taskcombo
            // 
            this.Taskcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Taskcombo.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Taskcombo.FormattingEnabled = true;
            this.Taskcombo.Items.AddRange(new object[] {
            "Finished",
            "Progress",
            "Pending"});
            this.Taskcombo.Location = new System.Drawing.Point(284, 170);
            this.Taskcombo.Name = "Taskcombo";
            this.Taskcombo.Size = new System.Drawing.Size(248, 37);
            this.Taskcombo.TabIndex = 9;
            // 
            // TaskInput
            // 
            this.TaskInput.Font = new System.Drawing.Font("Tahoma", 12F);
            this.TaskInput.Location = new System.Drawing.Point(284, 102);
            this.TaskInput.Name = "TaskInput";
            this.TaskInput.Size = new System.Drawing.Size(248, 36);
            this.TaskInput.TabIndex = 10;
            // 
            // Progresslbl
            // 
            this.Progresslbl.AutoSize = true;
            this.Progresslbl.Font = new System.Drawing.Font("Candara", 14F);
            this.Progresslbl.Location = new System.Drawing.Point(296, 345);
            this.Progresslbl.Name = "Progresslbl";
            this.Progresslbl.Size = new System.Drawing.Size(148, 35);
            this.Progresslbl.TabIndex = 11;
            this.Progresslbl.Text = "In Progress";
            // 
            // Pendinglbl
            // 
            this.Pendinglbl.AutoSize = true;
            this.Pendinglbl.Font = new System.Drawing.Font("Candara", 14F);
            this.Pendinglbl.Location = new System.Drawing.Point(564, 345);
            this.Pendinglbl.Name = "Pendinglbl";
            this.Pendinglbl.Size = new System.Drawing.Size(139, 35);
            this.Pendinglbl.TabIndex = 12;
            this.Pendinglbl.Text = "In Pending";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Tahoma", 14F);
            this.SaveBtn.Location = new System.Drawing.Point(325, 249);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(148, 53);
            this.SaveBtn.TabIndex = 13;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 673);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.Pendinglbl);
            this.Controls.Add(this.Progresslbl);
            this.Controls.Add(this.TaskInput);
            this.Controls.Add(this.Taskcombo);
            this.Controls.Add(this.FinishedLbl);
            this.Controls.Add(this.PendingList);
            this.Controls.Add(this.ProgressList);
            this.Controls.Add(this.FinishedList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Titlelabel);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titlelabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox FinishedList;
        private System.Windows.Forms.ListBox ProgressList;
        private System.Windows.Forms.ListBox PendingList;
        private System.Windows.Forms.Label FinishedLbl;
        private System.Windows.Forms.ComboBox Taskcombo;
        private System.Windows.Forms.TextBox TaskInput;
        private System.Windows.Forms.Label Progresslbl;
        private System.Windows.Forms.Label Pendinglbl;
        private System.Windows.Forms.Button SaveBtn;
    }
}

