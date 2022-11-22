namespace PersonList
{
    using System;

    public class PersonListNode
    {
        private PersonListNode pln;
        private Person person;

        public PersonListNode(Person person)
        {
            this.Person = person;
        }

        public PersonListNode Next
        {
            get
            {
                return this.pln;
            }

            set
            {
                this.pln = value;
            }
        }

        public Person Person
        {
            get
            {
                return this.person;
            }

            set
            {
                this.person = value;
            }
        }
    }
}