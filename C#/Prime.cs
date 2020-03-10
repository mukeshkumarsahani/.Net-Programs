using System;
namespace primenumber{
    class prime{
        public static void Main(string []args){
        int n,i;
        int count = 0;
        Console.WriteLine("Enter a number to check number is prime or not : ");
        n = Convert.ToInt32(Console.ReadLine());
        for(i=1; i<=n;i++) {

            if(n%i == 0){
                count++;
            }
        }
        if(count == 2){
            Console.WriteLine(n +" is Prime Number.");
        } 
        else{Console.WriteLine( n+" is not a prime number.");}
        
        }
    }
}