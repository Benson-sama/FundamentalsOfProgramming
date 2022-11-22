namespace PersonList
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class PersonListEnumerator : IEnumerator<Person>
    {
        public PersonList personList;

        // Enumerators are positioned before the first element
        // until the first MoveNext() call.
        PersonListNode current;

        public PersonListEnumerator(PersonList personList)
        {
            this.personList = personList;
            this.current = null;
        }

        public bool MoveNext()
        {
            if (current == null)
            {
                if(personList.Root == null)
                {
                    return false;
                }

                this.current = personList.Root;
                return true;
            }

            if (current.Next != null)
            {
                this.current = current.Next;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            current = personList.Root;
        }

        public void Dispose()
        {
            
        }
        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }
        Person IEnumerator<Person>.Current
        {
            get
            {
                return current.Person;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return personList.Root.Person;
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
}