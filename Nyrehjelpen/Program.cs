using System.Runtime.CompilerServices;

namespace Nyrehjelpen
{
    internal class Program
    {

        static void Main(string[] args)

        {            
            var oldKidney = new Kidneys("old kidney", 2);
            var newKidney1 = new Kidneys("new kidney", 60);
            var newKidney2 = new Kidneys("new kidney", 100);

            Console.WriteLine($"Bernt has been in an accident! His {oldKidney.KidneyName} is at a health level of {oldKidney.KidneyHealth}");
            Console.WriteLine($"Luckily his cousin Kåre has a healthy pair that he can donate. One of them is at a health level of {newKidney1.KidneyHealth} and the other {newKidney2.KidneyHealth}");
            Console.WriteLine($"Which one should he donate? Press '1' or '2' and see what happens");

            newKidney1.addKidney();
            newKidney2.addKidney();
        }
        
    }
}


