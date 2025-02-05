using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibarySystem
{
    public class Member : Person
    {
        public Member(int IDValue, string firstNameValue, string lastNameValue, Date birthDateValue, int contactNumberValue, string addressValue) : base(IDValue, firstNameValue, lastNameValue, birthDateValue, contactNumberValue, addressValue)
        {

        }

        public void Borrows()
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

        public override void searchBook()
        {
            throw new System.NotImplementedException();
        }

        public void addBook()
        {
            throw new System.NotImplementedException();
        }
    }
}