using System;
using System.Text;

{
    class Program
    {
        static void Main()
        {
            string firstName = "Grant ";
            string lastName = "Parkis ";
            string expression = "kills it with Angular Apps";\
            string concatenation = firstName + lastName + expression;
            Console.WriteLine(concatenation);

            Console.WriteLine(concatenation.ToUpper());

            StringBuilder sb = new StringBuilder();

            Console.Read();
        }
    }

    
}
