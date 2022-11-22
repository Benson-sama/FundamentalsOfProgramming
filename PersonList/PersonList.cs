namespace PersonList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class PersonList : IEnumerable<Person>
    {
        private PersonListNode root;

        public PersonListNode Root
        {
            get
            {
                return this.root;
            }

            private set
            {
                this.root = value;
            }
        }

        public void Add(Person person)
        {
            if (this.root == null)
            {
                this.root = new PersonListNode(person);
                return;
            }

            PersonListNode current = this.Root;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new PersonListNode(person);
        }

        public IEnumerator<Person> GetEnumerator()
        {
            return new PersonListEnumerator(this);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new PersonListEnumerator(this);
        }
    }
}