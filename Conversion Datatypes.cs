using System;


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




