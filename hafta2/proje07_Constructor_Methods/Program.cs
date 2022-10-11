namespace proje07_Constructor_Methods
{
    class Person
    {
        public Person() // Method, Constructor Metot-tipi olmaz.
        {
            // Her classın default olarak boş bir constructor metodu vardır ama implicittir, yani örtülü, gizlidir.Şu anda biz kendimiz bir constructor metot yazdık
            // constructor metot ilgili classtannew keywordü ile yeni bir nesne yaratıldığı esnada çalışacak kodları barındırır.
            // Yani bu classdan bir  nesne üretildiği anda buradaki kodlar çalışır. 
            Console.WriteLine("Merhaba ben Person şu an yaratıldım.");
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Student:Person 
    {
        public Student(string firstName, string lastName, int studentNumber):base(firstName, lastName)
        {
               // bir classın miras aldığı kısma base denir. Persondaki firstName ve lastNameyi Persondan alıyoruz. 
            StudentNumber=studentNumber;    
        }
        public int StudentNumber { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Person person1 = new Person(); // açıklama yapan kısma gidip çalışır parantez içi boş olan
            //Person person2 = new Person("Zeynep" , "Özden"); // Parantez içinde iki değer olan public'e gider ve çalıştırır.
            //Console.WriteLine($"{person2.FirstName} {person2.LastName}");

            Student student1 = new Student("Zeynep", "Özden", 345);
            Console.WriteLine($"{student1.FirstName} { student1.LastName} { student1.StudentNumber}");
            Console.ReadLine();


        }
    }
}