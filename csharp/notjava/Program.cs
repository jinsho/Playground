using System; // Basic lib

namespace notjava
{
    class Program // Primitive class
    {
        static void novice(int n, string phrase)
        {
            if(n > 10){
                Console.WriteLine("I'll only count from 0 to 10.");
                return;
            }

            for(int i = 0; i < n; i++){
                Console.Write($"Now {i}\n");
            }
            Console.WriteLine(phrase);

            String name = Console.ReadLine(); //This one has methods
            int age = Convert.ToInt32(Console.ReadLine());
            
        }

        static void Main(string[] args) // Main method
        {
            Console.WriteLine("Hm. This is quite familiar.");
            Console.Write("Think you can guess which language is that?\n");

            novice(5, "I guess it's C#");
            Console.ReadKey();
        }
    }
}
