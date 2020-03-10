using System;
class Base1 {
public int a = 5;
public int b = 10;  
}
class Addition : Base1{
    public void sum(){
        int sum = 0;
        sum = a + b ;
        Console.WriteLine("sum:" + sum);
    }
}
class multiply: Addition{
    public void mult(){
        int ml = 0;
        ml = a * b ;
        Console.WriteLine("Multiplication:"+ ml);
    }
}
class Program{
   public static void Main(string [] args){
       multiply obj = new multiply();
       obj.sum();
       obj.mult();
   } 
}