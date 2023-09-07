using System.Diagnostics;

namespace Expections_Thompson_Lillian
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloat = 65.4f;
            float myOtherFloat = 0.0f;
            float result = 0f;

            Random rand = new Random();
            int myInt = rand.Next(2, 30);

            try
            {
                result = Divide(myFloat, myOtherFloat);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Please enter a number other than zero.");
                myOtherFloat = (float)Convert.ToDouble(Console.ReadLine());

                try
                {
                    result = Divide(myFloat, myOtherFloat);
                }
                catch (Exception e2)
                {
                    Console.WriteLine(e2.Message);
                }
            }

            finally
            {
                Console.WriteLine("Calcutation completed with a result of" + result);
            }

            try
            {
                CheckAge(myInt);
            }
            catch
            {
                Console.WriteLine("Your not old enough!!!!!!!!!! >:( ");

            }


        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        /// <exception cref="DivideByZeroException"></exception>
        static float Divide (float x, float y)
        {
            if(y == 0)
            {
                throw new DivideByZeroException();
            }
            else
            {
                return x / y;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="age"></param>
        /// <exception cref="ArgumentException"></exception>
        static void CheckAge(int age)
        {
            if (age >= 17)
            {
                Console.WriteLine($"You are {age}, you can play mature games!");
            }
            else
            {
                throw new ArgumentException();
            }
        }
       

        
    }
}