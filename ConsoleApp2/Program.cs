using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //fiebre,dolor de caveza,hipoglusemia=covid
            //fiebre, dolor de caveza = infeccion
            //fiebre= resfriado
            Console.WriteLine("tienes fiebre (si/no): ");
            string respuesta = Console.ReadLine();
            if (respuesta == "si")
            {
                Console.WriteLine("tienes dolor de aveza? (si /no): ");
                string respuesta2 = Console.ReadLine();
                if (respuesta2 == "si")

                {
                    Console.WriteLine("tienes hipoglusemia?(si /no): ");
                    string respuesta3 = Console.ReadLine();
                    
                        if (respuesta3 == "si")
                    {
                        Console.WriteLine("usted tiene covid");
                       
                        

                    }


                    else 
                    {
                        Console.WriteLine("usted tiene una infeccion");
                    }






                }
                else { Console.WriteLine("usted solo tiene una infeccion"); }


            }
            else { Console.WriteLine("usted solo tiene una infeccion"); }
        }
    }
}
                   
                    
    

