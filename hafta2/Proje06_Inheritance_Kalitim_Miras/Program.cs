namespace Proje06_Inheritance_Kalitim_Miras
{
    class Person // bir class istediği kadar classa miras vereiblir. class writer gibi
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual void ıntro()  // nu komut bu metodun miras alınan classlarda override edilmesine izin verir.
        {
            Console.WriteLine($"First Name {FirstName}, LastName {LastName}");
        }

    }
    class Teacher : Person
    {
        public string Branch { get; set; }
    }
    class Writer : Person
    {
        public string BookName { get; set; }
    }
    class Student : Person  // person sınıfından miras alır oradaki publicler burada da kullanılır ve Bir class sadece bir classtan miras alabilir.
    {
        public int StudentNumber { get; set; }
        public override void ıntro() // Bu metodun mras alınan sınıftaki versionu ezip, yoksayıp bu metodu kabuleder
        {
            Console.WriteLine($"First Name {FirstName}, LastName {LastName}, Student Number {StudentNumber}");
        }
    }
    class a
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }

    }
    class b:a
    {
        public int MyProperty3 { get; set; }
        public int MyProperty4 { get; set; }

    }
    class c:b
    {
        public int MyProperty5 { get; set; }
        public int MyProperty6 { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Student student = new Student();
            student.FirstName = "Kemal";
            student.LastName = "Kapucu";
            student.StudentNumber = 125;
            student.ıntro();
            Console.ReadLine();


            Teacher teacher = new Teacher();
            {
                teacher.FirstName = "Alican";
                teacher.LastName = "Kuloğlu";                
                teacher.Branch = "Matematik";

               
            }
            teacher.ıntro();

            Console.ReadLine();
        }

    }
}