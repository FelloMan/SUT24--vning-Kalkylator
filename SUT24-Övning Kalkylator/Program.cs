using System.Reflection.PortableExecutable;

namespace SUT24_Övning_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            int result = 0;

            bool programOn = true;


            while (programOn)
            {
                //Menu
                Console.WriteLine("Välj ett av alternativen");

                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraktion");
                Console.WriteLine("3. Multiplíkation");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Avsluta program");

                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("Välj två nummer");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());

                        result = Add(num1, num2);

                        Console.WriteLine($"Resultatet blev: {result}");
                        break;
                    case "2":
                        Console.WriteLine("Välj två nummer");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());

                        result = Subtract(num1, num2);

                        Console.WriteLine($"Resultatet blev: {result}");
                        break;
                    case "3":
                        Console.WriteLine("Välj två nummer");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());

                        result = Multiply(num1, num2);

                        Console.WriteLine($"Resultatet blev: {result}");
                        break;
                    case "4":
                        Console.WriteLine("Välj två nummer");
                        num1 = Convert.ToInt32(Console.ReadLine());
                        num2 = Convert.ToInt32(Console.ReadLine());

                        result = Divison(num1, num2);

                        Console.WriteLine($"Resultatet blev: {result}");
                        break;
                    case "5":
                        programOn = false;
                        break;
                    default:
                        Console.WriteLine("Fel inmatning vid menyval, försök igen");
                        break;
                }
            }
        }




        public static int Divison(int userDivison, int userDivison2)
        {
            int userAnswear = userDivison / userDivison2;
            return userAnswear;
        }





        public static int Add(int addFirstNumb, int addSecondNumb)
        {
            int sumAdd = addFirstNumb + addSecondNumb;
            return sumAdd;


        }

        public static int Subtract(int subFirstNumb, int subSecondNumb)
        {
            int sumSubtract = subFirstNumb - subSecondNumb;
            return sumSubtract;

        }

        public static int Multiply(int multiFirstNumb, int multiSecondNumb)
        {
            int multiplySum = multiFirstNumb * multiSecondNumb;
            return multiplySum;


        }
        public static double Elevated(double doubleToRaised, double doubleToBeRaised) 
        { 
            double sumElevated = Math.Pow(doubleToRaised, doubleToBeRaised);
            return sumElevated;
        
        }
    }
}
