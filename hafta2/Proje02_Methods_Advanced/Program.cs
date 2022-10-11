namespace Proje02_Methods_Advanced
{
    internal class Program
    {
        public int Year { get; private set; }

        class Person
        {
            public string Name { get; set; }
            public int Year { get; set; }

            public string Intro()
            {
                return $"Merhaba {this.Name}, yaş: {this.CalculateAge()}";
            }

            private int CalculateAge()
            {
                return DateTime.Now.Year - this.Year;
            }
        }


        static void Main(string[] args)
        {
            Person person1 = new Person() { Name = "Engin", Year = 1999 };
            Person person2 = new Person() { Name = "Dilek", Year = 1987 };
            Person person3 = new Person() { Name = "Merve", Year = 1985 };
            Person person4 = new Person() { Name = "Umay", Year = 1989 };
            Person person5 = new Person() { Name = "Defne", Year = 1990 };

            Person[] persons = { person2, person1, person3, person4, person5 };
            foreach (var person in persons)
            {
                Console.WriteLine(person.Intro());
            }

            Console.ReadLine();
            // cw# da herşey bir Nesnedir.

        }
    }
}