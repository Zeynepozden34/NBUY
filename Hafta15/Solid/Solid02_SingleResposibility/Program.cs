using Solid02_SingleResposibility.Before;

namespace Solid02_SingleResposibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Actions.Sum(5, 15);
            Console.WriteLine(Actions.Sum(5,15));
        }
    }
}