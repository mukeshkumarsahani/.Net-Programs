using System;
namespace BoxingUnboxing
{
    class Box{
        void boxing(){
            int a = 10;
            object obj = a;
            Console.WriteLine("Converted into Object"+ obj);
        }
        void unboxing(){
            object obj = 10;
            int i = (int) obj;
            Console.WriteLine("Converted into value"+ i);
        }

        public static void Main(string []args){
         Box b1 = new Box();
         b1.boxing();
         b1.unboxing();  

        }
    }
}