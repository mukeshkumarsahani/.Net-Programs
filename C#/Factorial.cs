using System;
namespace fact1{
    class factorial{
        public static void Main(string []args){
        int i,fact = 1;
        Console.WriteLine("Enter any Number to find the factorial");
        int n = Convert.ToInt32(Console.ReadLine());
        if(n<0){
            Console.WriteLine("Factorial is not possible");
        }
        else if(n == 1){
            Console.WriteLine("Factorial is :"+ 1);
        }
        else if(n == 0){
            Console.WriteLine("Factorial is :"+ 1);}
        else{
            for(i=1; i<=n; i++){
                fact = fact * i ;
            }
            Console.WriteLine("Factorial is :"+ fact);
        }
        }

    }
}