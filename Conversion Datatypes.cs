using System;
/*
namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var number = "1234";
                byte b = Convert.ToByte(number);
                Console.WriteLine(number);
            }
            catch (Exception)
            {
                Console.WriteLine("The number could not be converted to byte");
            }
          

        }
    }
}

*/

namespace DataConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string str = "True";
                bool b = Convert.ToBoolean(str);
               Console.WriteLine(b);
            }
            catch (Exception)
            {
                Console.WriteLine("The string could not be converted");
            }


        }
    }
}




