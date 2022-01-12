using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndividualProject
{
    public partial class Form1 : Form
    {
        //This section of code creates linked lists each with the subject name that will be used to store and move entries made by the user
        LinkedList<createEntry> pendingItems = new LinkedList<createEntry>();
        LinkedList<createEntry> mathInternal = new LinkedList<createEntry>();
        LinkedList<createEntry> englishInternal = new LinkedList<createEntry>();
        LinkedList<createEntry> chemistryInternal = new LinkedList<createEntry>();
        LinkedList<createEntry> biologyInternal = new LinkedList<createEntry>();
        LinkedList<createEntry> danceInternal = new LinkedList<createEntry>();
        LinkedList<createEntry> computerscienceInternal = new LinkedList<createEntry>();
        LinkedList<createEntry> historyInternal = new LinkedList<createEntry>();
        LinkedList<createEntry> spanishInternal = new LinkedList<createEntry>();
        List<string> completedItems=new List<string>();
        public Form1()
        {
            InitializeComponent();
          
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void createEntryButton_Click(object sender, EventArgs e)
        {
            txtFinish.Visible = false;
            lblFinish.Visible = false;
            //Input validation to ensure all fields are filled out correctly
            if (SummativeAssessmentButton.Checked == false && performanceTaskButton.Checked == false)
            {
                MessageBox.Show("Please select assignment type to continue.");
                return;
            }
            if (entrySubject.SelectedIndex == 0)
            { 
                MessageBox.Show("Please select a subject for the entry to continue.");
                return;
            }
            if (assignmentName.Text.Trim() == "")
            {
                MessageBox.Show("Please type in an assignment name to continue.");
                return;
            }
            if(assignmentDes.Text.Trim() == "")
            {
                MessageBox.Show("Please type in an assignment description to continue.");
                return;
            }
            if(selectDate.Value == null)
            {
                MessageBox.Show("Please select a date to continue.");
                return;
            }
            
            //Assigning variables to enter into createEntry class after ensuring all entries as filled

            char assignmentType;
            string Subject = entrySubject.SelectedItem.ToString();
            string assignmentN = assignmentName.Text;
            string description = assignmentDes.Text;
            string date = selectDate.Text;
            string time = selectTime.Text;
            
            if (SummativeAssessmentButton.Checked == false)
            {
                assignmentType = 'P';
            }
            else
            {
                assignmentType = 'S';
            }

            // creates an instance of the createEntry class with the information filled in.
            createEntry current = new createEntry(assignmentType, Subject, assignmentN, description, date, time);

            //Adds the information to linked list that matches the assignment's subject
            pendingItems.Append(current);
            if (current.subjectName == "Math")
            {
                mathInternal.AddLast(current);
            }
            else if (current.subjectName == "English")
            {
                englishInternal.AddLast(current);
            }
            else if (current.subjectName == "Chemistry")
            {
                chemistryInternal.AddLast(current);
            }
            else if (current.subjectName == "Biology")
            {
                biologyInternal.AddLast(current);
            }
            else if (current.subjectName == "World History")
            {
                historyInternal.AddLast(current);
            }
            else if (current.subjectName == "Computer Science")
            {
                computerscienceInternal.AddLast(current);
            }
            else if (current.subjectName == "Dance")
            {
                danceInternal.AddLast(current);
            }
            else if (current.subjectName == "Spanish")
            {
                spanishInternal.AddLast(current);
            }

            MessageBox.Show("You have created an entry with the subject: " + Subject + " and assignment name: " + assignmentN);
            clearControls();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            performanceTaskButton.Checked = false;
            SummativeAssessmentButton.Checked = false;
            entrySubject.SelectedIndex = 0;
            entrySubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            selectDate.MinDate = DateTime.Now;
            if(selectDate.MinDate <= DateTime.Now)
               selectTime.MinDate = DateTime.Now;
            pendingSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            lblFinish.Visible = false;
            txtFinish.Visible = false;

        }

        private void entrySubject_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void showPendingButton_Click(object sender, EventArgs e)
        {
            if(pendingSubject.SelectedItem == null)
            {
                MessageBox.Show("Please select the subject of the pending checklist to continue.");
                return;
            }
            //iterates through the foreach loop to display each node with the assignment name, description, 
            //due date, and the other information inputted by the user
            if (pendingSubject.SelectedItem.ToString() == "Math")
            {
                outputTextBox.Text = "";
                int i = 1;
                string aType;
                foreach (createEntry entry in mathInternal)
                {
                    if (entry.assignmentType.ToString() == "P")
                        aType = "Performance";
                    else
                        aType = "Summative";
                    outputTextBox.Text = outputTextBox.Text + "Assignment Number:" + i + Environment.NewLine +
                        "Assignment Type:" + aType + Environment.NewLine +
                        "Assignment Name:" + entry.assignmentName.ToString() + Environment.NewLine +
                        "Assignment Desc:" + entry.assignmentDes + Environment.NewLine + Environment.NewLine;
                    i++;
                }
            }
            if (pendingSubject.SelectedItem.ToString() == "English")
            {
                outputTextBox.Text = "";
                int i = 1;
                string aType;
                foreach (createEntry entry in englishInternal)
                {
                    if (entry.assignmentType.ToString() == "P")
                        aType = "Performance";
                    else
                        aType = "Summative";
                    outputTextBox.Text = outputTextBox.Text + "Assignment Number:" + i + Environment.NewLine +
                        "Assignment Type:" + aType + Environment.NewLine +
                        "Assignment Name:" + entry.assignmentName.ToString() + Environment.NewLine +
                        "Assignment Desc:" + entry.assignmentDes + Environment.NewLine + Environment.NewLine;
                    i++;
                }
            }
            if (pendingSubject.SelectedItem.ToString() == "Computer Science")
            {
                outputTextBox.Text = "";
                int i = 1;
                string aType;
                foreach (createEntry entry in computerscienceInternal)
                {
                    if (entry.assignmentType.ToString() == "P")
                        aType = "Performance";
                    else
                        aType = "Summative";
                    outputTextBox.Text = outputTextBox.Text + "Assignment Number:" + i + Environment.NewLine +
                        "Assignment Type:" + aType + Environment.NewLine +
                        "Assignment Name:" + entry.assignmentName.ToString() + Environment.NewLine +
                        "Assignment Desc:" + entry.assignmentDes + Environment.NewLine + Environment.NewLine;
                    i++;
                }
            }
            if (pendingSubject.SelectedItem.ToString() == "Biology")
            {
                outputTextBox.Text = "";
                int i = 1;
                string aType;
                foreach (createEntry entry in biologyInternal)
                {
                    if (entry.assignmentType.ToString() == "P")
                        aType = "Performance";
                    else
                        aType = "Summative";
                    outputTextBox.Text = outputTextBox.Text + "Assignment Number:" + i + Environment.NewLine +
                        "Assignment Type:" + aType + Environment.NewLine +
                        "Assignment Name:" + entry.assignmentName.ToString() + Environment.NewLine +
                        "Assignment Desc:" + entry.assignmentDes + Environment.NewLine + Environment.NewLine;
                    i++;
                }
            }
            if (pendingSubject.SelectedItem.ToString() == "Chemistry")
            {
                outputTextBox.Text = "";
                int i = 1;
                string aType;
                foreach (createEntry entry in chemistryInternal)
                {
                    if (entry.assignmentType.ToString() == "P")
                        aType = "Performance";
                    else
                        aType = "Summative";
                    outputTextBox.Text = outputTextBox.Text + "Assignment Number:" + i + Environment.NewLine +
                        "Assignment Type:" + aType + Environment.NewLine +
                        "Assignment Name:" + entry.assignmentName.ToString() + Environment.NewLine +
                        "Assignment Desc:" + entry.assignmentDes + Environment.NewLine + Environment.NewLine;
                    i++;
                }
            }
            if (pendingSubject.SelectedItem.ToString() == "Spanish")
            {
                outputTextBox.Text = "";
                int i = 1;
                string aType;
                foreach (createEntry entry in spanishInternal)
                {
                    if (entry.assignmentType.ToString() == "P")
                        aType = "Performance";
                    else
                        aType = "Summative";
                    outputTextBox.Text = outputTextBox.Text + "Assignment Number:" + i + Environment.NewLine +
                        "Assignment Type:" + aType + Environment.NewLine +
                        "Assignment Name:" + entry.assignmentName.ToString() + Environment.NewLine +
                        "Assignment Desc:" + entry.assignmentDes + Environment.NewLine + Environment.NewLine;
                    i++;
                }
            }
            if (pendingSubject.SelectedItem.ToString() == "World History")
            {
                outputTextBox.Text = "";
                int i = 1;
                string aType;
                foreach (createEntry entry in historyInternal)
                {
                    if (entry.assignmentType.ToString() == "P")
                        aType = "Performance";
                    else
                        aType = "Summative";
                    outputTextBox.Text = outputTextBox.Text + "Assignment Number:" + i + Environment.NewLine +
                        "Assignment Type:" + aType + Environment.NewLine +
                        "Assignment Name:" + entry.assignmentName.ToString() + Environment.NewLine +
                        "Assignment Desc:" + entry.assignmentDes + Environment.NewLine + Environment.NewLine;
                    i++;
                }
            }
            if (pendingSubject.SelectedItem.ToString() == "Dance")
            {
                outputTextBox.Text = "";
                int i = 1;
                string aType;
                foreach (createEntry entry in danceInternal)
                {
                    if (entry.assignmentType.ToString() == "P")
                        aType = "Performance";
                    else
                        aType = "Summative";
                    outputTextBox.Text = outputTextBox.Text +"Assignment Number:"+i+Environment.NewLine+
                        "Assignment Type:" + aType+Environment.NewLine+
                        "Assignment Name:" + entry.assignmentName.ToString() + Environment.NewLine +
                        "Assignment Desc:" + entry.assignmentDes + Environment.NewLine + Environment.NewLine;
                    i++;
                }
            }

            clearControls();
            //Hide the label and text box that help finish an assignment so that the user only uses them when they are supposed to be used
            lblFinish.Visible = true;
            txtFinish.Visible = true;
           
            
        } 

        private void finishAssignmentButton_Click(object sender, EventArgs e)
        {

            //Input validation to ensure the user inputs the correct information, in the correct format
            if (outputTextBox.Text.Trim() == "") {
                MessageBox.Show("Please create an entry to finish an assignment.");
            }
            if(txtFinish.Text == "")
            {
                MessageBox.Show("Please enter the assignment number to finish an assignment.");
            }

            try
            {
                if (Convert.ToInt32(txtFinish.Text.ToString()) <= 0)
                {
                    MessageBox.Show("Please enter a valid assignment number");
                }
            }
            catch
            {
                MessageBox.Show("Please enter an integer as a number");
            }
            finishAssignment assignment = new finishAssignment(Convert.ToInt32(txtFinish.Text.ToString()), pendingSubject.SelectedItem.ToString());
            int index = assignment.indexNumber(Convert.ToInt32(txtFinish.Text.ToString()));
            outputTextBox.Text = "";

            //The assignment name of the completed assignment is added to the compltedItems list and the assignment is deleted from the linked list
            //corrosponding to the subject of the assignment selected. This is accomplished through iterating through all the nodes in the linked list
            if (assignment.subjectName == "Math")
            {
                int i = 0;
                foreach(createEntry entries in mathInternal)
                {
                    if (i == index)
                    {
                        completedItems.Add(entries.assignmentName);
                        mathInternal.Remove(entries);
                        i = i + 1;
                        MessageBox.Show("The assignment at " + i + " is finished");
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (assignment.subjectName == "English")
            {
                int i = 0;
                foreach (createEntry entries in englishInternal)
                {
                    if (i == index)
                    {
                        completedItems.Add(entries.assignmentName);
                        englishInternal.Remove(entries);
                        i = i + 1;
                        MessageBox.Show("The assignment at " + i + " is finished");
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (assignment.subjectName == "Chemistry")
            {
                int i = 0;
                foreach (createEntry entries in chemistryInternal)
                {
                    if (i == index)
                    {
                        completedItems.Add(entries.assignmentName);
                        chemistryInternal.Remove(entries);
                        i = i + 1;
                        MessageBox.Show("The assignment at " + i + " is finished");
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (assignment.subjectName == "Dance")
            {
                int i = 0;
                foreach (createEntry entries in danceInternal)
                {
                    if (i == index)
                    {
                        completedItems.Add(entries.assignmentName);
                        danceInternal.Remove(entries);
                        i = i + 1;
                        MessageBox.Show("The assignment at " + i + " is finished");
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (assignment.subjectName == "Biology")
            {
                int i = 0;
                foreach (createEntry entries in biologyInternal)
                {
                    if (i == index)
                    {
                        completedItems.Add(entries.assignmentName);
                        biologyInternal.Remove(entries);
                        i = i + 1;
                        MessageBox.Show("The assignment at " + i + " is finished");
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (assignment.subjectName == "Spanish")
            {

                int i = 0;
                foreach (createEntry entries in spanishInternal)
                {
                    if (i == index)
                    {
                        completedItems.Add(entries.assignmentName);
                        spanishInternal.Remove(entries);
                        i = i + 1;
                        MessageBox.Show("The assignment at " + i + " is finished");
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (assignment.subjectName == "World History")
            {
   
                int i = 0;
                foreach (createEntry entries in historyInternal)
                {
                    if (i == index)
                    {
                        completedItems.Add(entries.assignmentName);
                        historyInternal.Remove(entries);
                        i = i + 1;
                        MessageBox.Show("The assignment at " + i + " is finished");
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            if (assignment.subjectName == "Computer Science")
            {
              
                int i = 0;
                foreach (createEntry entries in computerscienceInternal)
                {
                    if (i == index)
                    {
                        completedItems.Add(entries.assignmentName);
                        computerscienceInternal.Remove(entries);
                        i = i + 1;
                        MessageBox.Show("The assignment at " + i + " is finished");
                        return;
                    }
                    else
                    {
                        i++;
                    }
                }
            }
            //Hide the label and text box that help finish an assignment so that the user only uses them when they are supposed to be used
            txtFinish.Text = "";
            txtFinish.Visible = false;
            lblFinish.Visible = false;
        }

        private void showCompletedButton_Click(object sender, EventArgs e)
        {
            clearControls();
            //Resets the bigh output text box
            outputTextBox.Text = "";
            //Iterates through the completedItems list and prints out each index or assignment name
            for(int i = 0;i < completedItems.Count; i++)
            {
                outputTextBox.Text = outputTextBox.Text + "Assignment Name: "+ completedItems[i]+Environment.NewLine;
            }
        }

        private void clearChecklistButton_Click(object sender, EventArgs e)
        {
            //The clear button sets all the linked lists and control to either null or an empty string, depending on what is being cleared.

            clearControls();
            pendingSubject.SelectedItem = null;
            mathInternal.Clear();
            chemistryInternal.Clear();
            englishInternal.Clear();
            danceInternal.Clear();
            historyInternal.Clear();
            computerscienceInternal.Clear();
            biologyInternal.Clear();
            spanishInternal.Clear();
            pendingItems.Clear();
            lblFinish.Visible = false;
            txtFinish.Visible = false;
            outputTextBox.Text = "";
        }

        //Clears all the textboxes, radioboxes, and the comboboxes in the form.
        private void clearControls()
        {
            SummativeAssessmentButton.Checked = false;
            performanceTaskButton.Checked = false;
            entrySubject.SelectedIndex = 0;
            assignmentName.Text = string.Empty;
            assignmentDes.Text = string.Empty;
            selectDate.MinDate = DateTime.Now;
            selectTime.MinDate = DateTime.Now;
            lblFinish.Visible = false;
            txtFinish.Visible = false;
        }

        private void selectTime_ValueChanged(object sender, EventArgs e)
        {
            //To ensure the user cannot set a date that is in the past, the date time picker is set to the current time
            if (selectDate.MinDate == DateTime.Now)
                selectTime.MinDate = DateTime.Now;
        }
    }

   
    
}
