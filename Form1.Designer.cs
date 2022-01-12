namespace IndividualProject
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
            this.label1 = new System.Windows.Forms.Label();
            this.performanceTaskButton = new System.Windows.Forms.RadioButton();
            this.SummativeAssessmentButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.entrySubject = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.assignmentName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.assignmentDes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.selectDate = new System.Windows.Forms.DateTimePicker();
            this.selectTime = new System.Windows.Forms.DateTimePicker();
            this.createEntryButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.showPendingButton = new System.Windows.Forms.Button();
            this.showCompletedButton = new System.Windows.Forms.Button();
            this.finishAssignmentButton = new System.Windows.Forms.Button();
            this.clearChecklistButton = new System.Windows.Forms.Button();
            this.pendingSubject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFinish = new System.Windows.Forms.TextBox();
            this.lblFinish = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Assignment Type";
            // 
            // performanceTaskButton
            // 
            this.performanceTaskButton.AutoSize = true;
            this.performanceTaskButton.Location = new System.Drawing.Point(35, 67);
            this.performanceTaskButton.Name = "performanceTaskButton";
            this.performanceTaskButton.Size = new System.Drawing.Size(163, 24);
            this.performanceTaskButton.TabIndex = 0;
            this.performanceTaskButton.TabStop = true;
            this.performanceTaskButton.Text = "Performance Task";
            this.performanceTaskButton.UseVisualStyleBackColor = true;
            // 
            // SummativeAssessmentButton
            // 
            this.SummativeAssessmentButton.AutoSize = true;
            this.SummativeAssessmentButton.Location = new System.Drawing.Point(34, 97);
            this.SummativeAssessmentButton.Name = "SummativeAssessmentButton";
            this.SummativeAssessmentButton.Size = new System.Drawing.Size(205, 24);
            this.SummativeAssessmentButton.TabIndex = 1;
            this.SummativeAssessmentButton.TabStop = true;
            this.SummativeAssessmentButton.Text = "Summative Assessment";
            this.SummativeAssessmentButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Subject";
            // 
            // entrySubject
            // 
            this.entrySubject.FormattingEnabled = true;
            this.entrySubject.Items.AddRange(new object[] {
            "Select a Subject",
            "Math",
            "English",
            "Biology",
            "Chemistry",
            "World History",
            "Computer Science",
            "Spanish",
            "Dance"});
            this.entrySubject.Location = new System.Drawing.Point(34, 172);
            this.entrySubject.Name = "entrySubject";
            this.entrySubject.Size = new System.Drawing.Size(188, 28);
            this.entrySubject.TabIndex = 2;
            this.entrySubject.SelectedIndexChanged += new System.EventHandler(this.entrySubject_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Assignment Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // assignmentName
            // 
            this.assignmentName.Location = new System.Drawing.Point(34, 245);
            this.assignmentName.Name = "assignmentName";
            this.assignmentName.Size = new System.Drawing.Size(188, 26);
            this.assignmentName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Assignment Description";
            // 
            // assignmentDes
            // 
            this.assignmentDes.Location = new System.Drawing.Point(34, 316);
            this.assignmentDes.Multiline = true;
            this.assignmentDes.Name = "assignmentDes";
            this.assignmentDes.Size = new System.Drawing.Size(188, 99);
            this.assignmentDes.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Due Date:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // selectDate
            // 
            this.selectDate.CustomFormat = "MM/dd/yyyy";
            this.selectDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.selectDate.Location = new System.Drawing.Point(298, 46);
            this.selectDate.MinDate = new System.DateTime(2021, 5, 10, 0, 0, 0, 0);
            this.selectDate.Name = "selectDate";
            this.selectDate.Size = new System.Drawing.Size(146, 26);
            this.selectDate.TabIndex = 6;
            // 
            // selectTime
            // 
            this.selectTime.CustomFormat = "";
            this.selectTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.selectTime.Location = new System.Drawing.Point(298, 78);
            this.selectTime.Name = "selectTime";
            this.selectTime.ShowUpDown = true;
            this.selectTime.Size = new System.Drawing.Size(146, 26);
            this.selectTime.TabIndex = 7;
            this.selectTime.ValueChanged += new System.EventHandler(this.selectTime_ValueChanged);
            // 
            // createEntryButton
            // 
            this.createEntryButton.Location = new System.Drawing.Point(496, 46);
            this.createEntryButton.Name = "createEntryButton";
            this.createEntryButton.Size = new System.Drawing.Size(175, 58);
            this.createEntryButton.TabIndex = 8;
            this.createEntryButton.Text = "Create Entry";
            this.createEntryButton.UseVisualStyleBackColor = true;
            this.createEntryButton.Click += new System.EventHandler(this.createEntryButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(266, 136);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(335, 279);
            this.outputTextBox.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 14;
            // 
            // showPendingButton
            // 
            this.showPendingButton.Location = new System.Drawing.Point(617, 201);
            this.showPendingButton.Name = "showPendingButton";
            this.showPendingButton.Size = new System.Drawing.Size(180, 49);
            this.showPendingButton.TabIndex = 10;
            this.showPendingButton.Text = "Show Pending";
            this.showPendingButton.UseVisualStyleBackColor = true;
            this.showPendingButton.Click += new System.EventHandler(this.showPendingButton_Click);
            // 
            // showCompletedButton
            // 
            this.showCompletedButton.Location = new System.Drawing.Point(617, 256);
            this.showCompletedButton.Name = "showCompletedButton";
            this.showCompletedButton.Size = new System.Drawing.Size(180, 49);
            this.showCompletedButton.TabIndex = 11;
            this.showCompletedButton.Text = "Show All Completed";
            this.showCompletedButton.UseVisualStyleBackColor = true;
            this.showCompletedButton.Click += new System.EventHandler(this.showCompletedButton_Click);
            // 
            // finishAssignmentButton
            // 
            this.finishAssignmentButton.Location = new System.Drawing.Point(617, 311);
            this.finishAssignmentButton.Name = "finishAssignmentButton";
            this.finishAssignmentButton.Size = new System.Drawing.Size(180, 49);
            this.finishAssignmentButton.TabIndex = 12;
            this.finishAssignmentButton.Text = "Finish Assignment";
            this.finishAssignmentButton.UseVisualStyleBackColor = true;
            this.finishAssignmentButton.Click += new System.EventHandler(this.finishAssignmentButton_Click);
            // 
            // clearChecklistButton
            // 
            this.clearChecklistButton.Location = new System.Drawing.Point(617, 366);
            this.clearChecklistButton.Name = "clearChecklistButton";
            this.clearChecklistButton.Size = new System.Drawing.Size(180, 49);
            this.clearChecklistButton.TabIndex = 13;
            this.clearChecklistButton.Text = "Clear All Checklists";
            this.clearChecklistButton.UseVisualStyleBackColor = true;
            this.clearChecklistButton.Click += new System.EventHandler(this.clearChecklistButton_Click);
            // 
            // pendingSubject
            // 
            this.pendingSubject.FormattingEnabled = true;
            this.pendingSubject.Items.AddRange(new object[] {
            "Math",
            "English",
            "Biology",
            "Chemistry",
            "World History",
            "Computer Science",
            "Spanish",
            "Dance"});
            this.pendingSubject.Location = new System.Drawing.Point(617, 167);
            this.pendingSubject.Name = "pendingSubject";
            this.pendingSubject.Size = new System.Drawing.Size(121, 28);
            this.pendingSubject.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(615, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 21;
            this.label7.Text = "Subject";
            // 
            // txtFinish
            // 
            this.txtFinish.Location = new System.Drawing.Point(528, 433);
            this.txtFinish.Name = "txtFinish";
            this.txtFinish.Size = new System.Drawing.Size(73, 26);
            this.txtFinish.TabIndex = 22;
            // 
            // lblFinish
            // 
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(262, 433);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(260, 20);
            this.lblFinish.TabIndex = 23;
            this.lblFinish.Text = "Enter Assignment Number to Finish";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 481);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.txtFinish);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pendingSubject);
            this.Controls.Add(this.clearChecklistButton);
            this.Controls.Add(this.finishAssignmentButton);
            this.Controls.Add(this.showCompletedButton);
            this.Controls.Add(this.showPendingButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.createEntryButton);
            this.Controls.Add(this.selectTime);
            this.Controls.Add(this.selectDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.assignmentDes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.assignmentName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.entrySubject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SummativeAssessmentButton);
            this.Controls.Add(this.performanceTaskButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Assignment Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton performanceTaskButton;
        private System.Windows.Forms.RadioButton SummativeAssessmentButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox entrySubject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox assignmentName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox assignmentDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker selectDate;
        private System.Windows.Forms.DateTimePicker selectTime;
        private System.Windows.Forms.Button createEntryButton;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button showPendingButton;
        private System.Windows.Forms.Button showCompletedButton;
        private System.Windows.Forms.Button finishAssignmentButton;
        private System.Windows.Forms.Button clearChecklistButton;
        private System.Windows.Forms.ComboBox pendingSubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFinish;
        private System.Windows.Forms.Label lblFinish;
    }
}

