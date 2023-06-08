namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                float firstOperant = 0; float secondOperant = 0;


                Console.WriteLine("Input firstOperant");
                firstOperant = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Input secondOperant");
                secondOperant = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Choose your operation");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");

                {

                    switch (Console.ReadLine())
                    {
                        case "a":
                            Console.WriteLine($"Your resutl: {firstOperant} + {secondOperant} = " + (firstOperant + secondOperant));
                            break;
                        case "s":
                            Console.WriteLine($"Your resutl: {firstOperant} - {secondOperant} = " + (firstOperant - secondOperant));
                            break;
                        case "m":
                            Console.WriteLine($"Your resutl: {firstOperant} * {secondOperant} = " + (firstOperant * secondOperant));
                            break;
                        case "d":
                            Console.WriteLine($"Your resutl: {firstOperant} / {secondOperant} = " + (firstOperant / secondOperant));
                            break;
                    }

                }

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error");
            }
        }

    
    }
    
}