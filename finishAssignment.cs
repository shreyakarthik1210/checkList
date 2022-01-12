using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{

    //The finishAssignment class takes in the assignment number inputted by the user and sets it to its subject
    class finishAssignment
    {
        public int entryNumber;
        public string subjectName;

        //Constructor for the class
        public finishAssignment(int entryNumber, string subjectName)
        {
            this.entryNumber = entryNumber;
            this.subjectName = subjectName;
        }

        //This method gives the correct index given the assignment number entered by the user
        public int indexNumber(int entryNumber)
        {
            int index = entryNumber - 1;
            return index;
        }
    }
}
