namespace PersonList
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            PersonList personList = new PersonList();
            PersonFactory personFactory = new PersonFactory();

            personList.Add(new Person("a", "a", 25));
            personList.Add(new Person("b", "b", 36));
            personList.Add(new Person("c", "c", 40));
            personList.Add(new Person("d", "d", 14));
            for (int i = 0; i < 10; i++)
            {
                personList.Add(personFactory.GetRandomPerson());
            }

            foreach(Person person in personList)
            {
                Console.WriteLine(person);
            }

            Console.ReadKey();
        }
    }
}
