using System;  
public class ExceptionHandling
{  
    public static void Main(string[] args)  
    {  
        try  
        {  
            int a = 10;  
            int b = 0;  
            int x = a / b;  
        }  
        catch (DivideByZeroException e){
        Console.WriteLine("Exception Caught"+e); 
        }  
        finally { 
        Console.WriteLine("Finally block is executed at any condition");
        }  
        Console.WriteLine("Check the code");  
    }  
} 