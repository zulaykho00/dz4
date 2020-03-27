using System;

namespace dz4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ZADANIE#2");
            double k,s;
            Console.Write("сумма покупки:");
            k=Convert.ToDouble(Console.ReadLine());
            if(k>=500 && k<1000)
            {
                s=97*k/100;
                Console.WriteLine($"сумма покупки с учетом скидки:{s}");
            } 
            if(k>=1000)
            {
                s=95*k/100;
                Console.WriteLine($"сумма покупки с учетом скидки:{s}");
            } 
            if(k<500)
            {
                Console.WriteLine($"сумма покупки :{k}");
            }

            Console.WriteLine("ZADANIE#3");
            double x,y,z,t;
            Console.WriteLine("введите 4 числа");
            x=Convert.ToDouble(Console.ReadLine());
            y=Convert.ToDouble(Console.ReadLine());
            z=Convert.ToDouble(Console.ReadLine());
            t=Convert.ToDouble(Console.ReadLine());
               if(x==y && z==t && y==z)
               {
                 Console.WriteLine($"произведение:{Math.Pow(x,4)}");  
               }
               else
               {
                   if(x<=y && y<=z && z<=t)
                   {
                       Console.WriteLine("числа расположены по возрастанию");
                   }
                   else
                   {
                       if(x<y && x<z && x<t)
                       Console.WriteLine($"минимальное:{x}");
                       if(y<x && y<z && y<t)
                       Console.WriteLine($"минимальное:{y}");
                       if(z<x && z<y && z<t)
                       Console.WriteLine($"минимальное:{z}");
                       if(t<x && t<y && t<z)
                       Console.WriteLine($"минимальное:{t}");
                   }    
                

                   
               }
             Console.WriteLine("ZADANIE#4");
             double a,b,c,m;
             Console.Write("a=");
             a=Convert.ToDouble(Console.ReadLine());
             Console.Write("b=");
             b=Convert.ToDouble(Console.ReadLine());
             Console.Write("c=");
             c=Convert.ToDouble(Console.ReadLine());
             if(a>=b && b>=c)
             {
             Console.WriteLine($"a={a} b={b} c={c}");
             }
             else
             {
                 if(a<=b && b<=c && a<=c) 
                 {
                    m=a;
                    a=c;
                    c=m;
                    Console.WriteLine($"a={a}  b={b}  c={c}") ;

                 }
                 if(a>=b && b<=c && c>=a)
                 {
                     m=c;
                     c=b;
                     b=a;
                     a=m;
                     Console.WriteLine($"a={a}  b={b}  c={c}") ;
                 }
                 if(a>=c && b<=c && a>=b)
                 {
                     m=b;
                    b=c; 
                    c=m;
                    Console.WriteLine($"a={a}  b={b}  c={c}") ;
                 }
                 if(b>=a && a>=c)
                 {
                     m=a;
                     a=b;
                     b=m;
                     Console.WriteLine($"a={a}  b={b}  c={c}") ;
                 }
                 if(b>=c && c>=a)
                 {
                    m=a;
                    a=b;
                    b=c;
                    c=m;
                    Console.WriteLine($"a={a}  b={b}  c={c}") ;

                 }
             }
        }

        
    }
}
