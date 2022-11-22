using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonList
{
    public class Person
    {
        private string firstname;
        private string lastname;
        private int age;

        public Person(string firstname, string lastname, int age)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Age = age;
        }

        public string Firstname
        {
            get
            {
                return this.firstname;
            }

            private set
            {
                if (value != null)
                {
                    this.firstname = value;
                }
            }
        }

        public string Lastname
        {
            get
            {
                return this.lastname;
            }

            private set
            {
                if (value != null)
                {
                    this.lastname = value;
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value > 0 && value < 120)
                {
                    this.age = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Firstname: {Firstname}, lastname: {Lastname}, age: {Age}";
        }
    }
}