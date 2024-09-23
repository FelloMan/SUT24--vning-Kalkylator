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
                Console.WriteLine("5. Upphöj");
                Console.WriteLine("6. Kvadratrot");
                Console.WriteLine("7. Arean av triangel");
                Console.WriteLine("8. Arean av kvadrat");
                Console.WriteLine("9. Arean av cirkel");
                Console.WriteLine("10. Avsluta program");

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
                        Console.WriteLine("Välj basen");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Välj hur mycket du vill upphöja med");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        double sumElevated = Elevated(num1, num2);

                        Console.WriteLine($"Resultatet blev: {sumElevated}");
                        break;
                    case "6":
                        Console.WriteLine("Välj ett nummer");

                        num1 = Convert.ToInt32(Console.ReadLine());

                        double sqaureRoot = SqaureRoot(num1);

                        Console.WriteLine($"Resultatet blev: {sqaureRoot}");
                        break;
                    case "7":
                        Console.WriteLine("Välj basen");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Välj höjden");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        result = AreaTriangel(num1, num2);

                        Console.WriteLine($"Resultatet blev: {result}");
                        break;
                    case "8":
                        Console.WriteLine("Välj basen");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Välj höjden");
                        num2 = Convert.ToInt32(Console.ReadLine());

                        result = AreaOfSquare(num1, num2);

                        Console.WriteLine($"Resultatet blev: {result}");
                        break;
                    case "9":
                        Console.WriteLine("Välj radien");
                        num1 = Convert.ToInt32(Console.ReadLine());

                        double areaOfCircle = AreaCircle(num1);

                        Console.WriteLine($"Resultatet blev: {areaOfCircle}");
                        break;
                    case "10":
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

        public static int AreaTriangel(int firstTriangel, int secondTriangel)
        {
            int areaSum = firstTriangel * secondTriangel / 2;
            return areaSum;
        }


        public static int AreaOfSquare(int firstAreaSquare, int secondAreaSquare)
        {
            int areaOfSquare = firstAreaSquare * secondAreaSquare;
            return areaOfSquare;
        }


        public static double AreaCircle (double circleRadius) //Cirkel
        {

            double sumAreaCircle = Math.PI * circleRadius * circleRadius ;
            return sumAreaCircle;
        }

        public static double SqaureRoot(double root)
        {
            double squareRoot = Math.Sqrt(root);
            return squareRoot;
        }
        


    }
}
