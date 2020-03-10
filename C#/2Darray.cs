using System;  
public class TwoDArray
{  
    public static void Main(string[] args)  
    {  
        int[,] arr=new int[3,3];
        arr[0,1]=5;
        arr[1,2]=10;  
        arr[2,0]=15;  
  
        //traversal  
        for(int i=0;i<3;i++){  
            for(int j=0;j<3;j++){  
                Console.Write(arr[i,j]+" ");  
            }  
            Console.WriteLine();
        }  
    }  
} 