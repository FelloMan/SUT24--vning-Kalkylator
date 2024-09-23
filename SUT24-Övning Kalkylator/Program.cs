namespace SUT24_Övning_Kalkylator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }




        public static int  Divison(int userDivison, int userDivison2)
        {
            int userAnswear = userDivison / userDivison2;
            return userAnswear;
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
