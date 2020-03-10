using System;
interface Geometry{
   void circle();
}
class A : Geometry {
   float pi = 3.14f;
   int r = 10;
   public void circle(){
       float area = pi*r*r;
       Console.WriteLine("Area of the Circle is "+ area);
   }
}

class Program{
    public static void Main(string []args){
        Geometry g ;
        g = new A();
        g.circle();
    }
}    
        