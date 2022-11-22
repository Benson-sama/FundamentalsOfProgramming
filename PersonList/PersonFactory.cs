namespace PersonList
{
    using System;

    public class PersonFactory
    {
        private Random random;

        public PersonFactory()
        {
            this.random = new Random();
        }

        public string GetRandomString()
        {
            // Der Algorithmus ist aus dem Internet, aufgrund von Zeitmangel in der Übung.
            // https://www.delftstack.com/de/howto/csharp/generate-random-alphanumeric-strings-in-csharp/
            // Zugriffszeit: 01.Dez.2021
            // Mit mehr Zeit hätt ich mir etwas selbst überlegen können,
            // daher diesen Code bitte nicht als mein Eigentum betrachten.

            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] charArray = new char[10];

            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = characters[this.random.Next(characters.Length)];
            }

            string resultString = new String(charArray);
            return resultString;
        }

        public Person GetRandomPerson()
        {
            string randomFirstname = GetRandomString();
            string randomLastname = GetRandomString();
            int randomAge = random.Next(1, 121);

            Person person = new Person(randomFirstname, randomLastname, randomAge);
            return person;
        }
    }
}