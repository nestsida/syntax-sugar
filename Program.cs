using System;

namespace Syntax_Sugar
{
    class Program
    {
        static void Main()
        {
            

            int answer = 4;
            string response;

            if (answer < 9)
            {
                response = answer + " is less than nine";
            }
            else
            {
                response = answer + "greater than or equal to nine";
            }
            Console.WriteLine(response);


            //String interpolation
            if (int.Parse(response) <= 9) { Console.WriteLine("is less than nine"); }
            if (int.Parse(response) >= 9) { Console.WriteLine("greater than or equal to nine"); }



            //// inferred typing
            //var answer = 4;
            //var response = string();

            //if (answer < 9)
            //{
            //    response = string(answer)+ "is less than nine";
            //}
            //else
            //{
            //    response = string(answer) + "greater than or equal to nine";
            //}

            //Console.WriteLine();

        }
     
          
    }
}
