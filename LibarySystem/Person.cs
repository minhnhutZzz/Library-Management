using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibarySystem
{
    public abstract class Person
    {
        private int ID;
        private string firstName;
        private string lastName;
        private Date birthDate;
        private int contactNumber;
        private string Address;


        public Person(int IDValue, string firstNameValue, string lastNameValue, Date birthDateValue, int contactNumberValue, string addressValue)
        {
            id=IDValue;
            FirstName=firstNameValue;
            LastName=lastNameValue;
            BirthDate=birthDateValue;
            ContactNumber=contactNumberValue;
            address=addressValue;

        }
        public int id
        {
            get { return ID; }
            set { ID = value ; }
        }
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public Date BirthDate
        {
            get { return birthDate;}
            set { birthDate = value; }
        }
        public int ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        public string address
        {
            get { return Address; }
            set { Address = value; }
        }
        public virtual void PrintDetails()
        {
            throw new System.NotImplementedException();
        }

        public virtual void searchBook()
        {
            throw new System.NotImplementedException();
        }
    }
}