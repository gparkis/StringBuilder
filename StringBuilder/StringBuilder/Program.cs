using System;
using System.Text;


    class Program
    {
        static void Main()
        {
            string firstName = "Grant ";
            string lastName = "Parkis ";
            string expression = "kills it with Angular Apps";
            string concatenation = firstName + lastName + expression;
            Console.WriteLine(concatenation);

            Console.WriteLine(concatenation.ToUpper());

            StringBuilder sb = new StringBuilder();
        sb.Append("There once was a fat man");
        sb.Append("\nAnd he wore a red and white suit, a white that matched his beard");
        sb.Append("\nThis fat man also road a sleigh that flew through the sky");
        Console.WriteLine(sb);

            Console.Read();
        }
    }

    

