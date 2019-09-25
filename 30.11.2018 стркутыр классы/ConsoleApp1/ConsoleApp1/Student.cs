using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        private int _id; // = 0
        private string _firstName = "John";
        private string _lastName = "Doe";
        private string _groupName;
        private DateTime _birthDate;

        public Student()
        {

        }
        public Student(DateTime dateTime)
        {
            _birthDate = dateTime;
        }

        public void Show()
        {
            Console.WriteLine($"Last name: {_lastName} Date: {_birthDate} Group: {_groupName}");
        }
    }
}
