namespace SUT24_Övning_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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

    }
}
