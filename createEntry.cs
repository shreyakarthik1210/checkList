using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The createEntry class creates a template that allows the computer to use the given information by the user in 
//the windows form and condense that into a linked list
namespace IndividualProject
{
    class createEntry
    {
        public char assignmentType;
        public string subjectName;
        public string assignmentName;
        public string assignmentDes;
        public string dueDate;
        public string time;

        public createEntry(char assignmentType ,string subjectName, string assignmentName, string assignmentDes, string dueDate, string time)
        {
            this.assignmentType = assignmentType;
            this.subjectName = subjectName;
            this.assignmentName = assignmentName;
            this.assignmentDes = assignmentDes;
            this.dueDate = dueDate;
            this.time = time;
        }        
    }
}
