namespace SUT24_Övning_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu
            Console.WriteLine("Välj ett av alternativen");

            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplíkation");
            Console.WriteLine("4. Division");

            string menuChoice = Console.ReadLine();

            switch (menuChoice)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Fel inmatning vid menyval");
                    break;
            }
        }




        public static int  Divison(int userDivison, int userDivison2)
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
        //m
    }
}
