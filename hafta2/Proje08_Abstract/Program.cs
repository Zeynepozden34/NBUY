using System;

namespace Proje08_Abstract
{
    abstract class Person // Bir class abstract ise yeni bir nesne yaratılamaz yani o new kullanılmaz.
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Console.WriteLine("Person is created");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public void Greeting()
        {
            Console.WriteLine("I'am a person");
        }
        public abstract void Intro(); //Soyut Metot. abstract kullanılacaksa classta abstract olmak zorunda.
    }
   
    class Student : Person
    {
        public Student(string firstName, string lastName, int studentNumber) : base(firstName, lastName)
        {
            StudentNumber = studentNumber;
            Console.WriteLine("Student is created");
        }

        public int StudentNumber { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name:  {LastName} Student Number: {StudentNumber}");
        }
    }

    class Teacher : Person
    {
        public Teacher(string firstName, string lastName, string branch) : base(firstName, lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            Branch = branch;
            Console.WriteLine("Teacher is created");
        }
        public string Branch { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"{FirstName} {LastName} {Branch}");
        }

        public void Teach()
        {
            Console.WriteLine("Hi I'am a teach");
        }
    }
    class Writer:Person
    {
        public Writer(string firstName, string lastName, string bookName): base(firstName, lastName)
        {
            string FirstName;
            string LastName;
            BookName = bookName;
            Console.WriteLine("Writer is created");
        }
        public string BookName { get; set; }

        public override void Intro()
        {
            Console.WriteLine($"First Name: {FirstName} Last Name:  {LastName} Book Name: {BookName}");
        }

       
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ayşen", "Umay", 105);
            student1.Greeting();
            student1.Intro();  //NOT:İstemediğimiz halde Persondaki Intro çalışıyor.


            Teacher teacher1 = new Teacher("Ayşen", "Umay", "matemaetik");
            teacher1.Greeting();
            teacher1.Teach();
            teacher1.Intro();  //NOT:İstemediğimiz halde Persondaki Intro çalışıyor.

            Writer writer1 = new Writer("Math", "Haig","Gece Yarısı Kütüphanesi");
            writer1.Greeting();
            writer1.Intro();

            Console.ReadLine();
        }
    }
}