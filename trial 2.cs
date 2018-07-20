using System;

namespace ConsoleApp4
{
    public Program()
    {
        static void Main()
        {
            
            Console.Write("sheila");
            string stringOne = Console.ReadLine();

            Console.Write("Wambui");
            string stringtwo = Console.ReadLine();

            Console.Write("Hello");
            String stringthree = Console.ReadLine();

            string result = "sheila" + "Wambui" + "Hello";
            Console.Write(result);
            Console.ReadLine();





           
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
