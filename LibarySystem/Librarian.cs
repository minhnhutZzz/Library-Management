using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibarySystem
{
    public class Librarian : Person
    {
        public Librarian(int IDValue, string firstNameValue, string lastNameValue, Date birthDateValue, int contactNumberValue, string addressValue) : base(IDValue, firstNameValue, lastNameValue, birthDateValue, contactNumberValue, addressValue)
        {

        }

        public void issues()
        {
            throw new System.NotImplementedException();
        }

        public void returnBook()
        {
            throw new System.NotImplementedException();
        }
        public override void PrintDetails()
        {
            base.PrintDetails();
        }

        public void viewMemberDetails()
        {
            throw new System.NotImplementedException();
        }

        public void generateBook()
        {
            throw new System.NotImplementedException();
        }

        public override void searchBook()
        {
            throw new System.NotImplementedException();
        }

        public void addMemberDetails()
        {
            throw new System.NotImplementedException();
        }
    }
}