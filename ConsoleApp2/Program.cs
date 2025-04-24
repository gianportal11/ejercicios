using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 3; i >=1; i--) { 
                Console.Clear();
           
            
                Console.WriteLine("el sistema inicia en "+i);
                Console.Beep(800,500);
                Thread.Sleep(1000);
            }
            Console.Beep(1300, 1200);
            Console.Clear() ;
            
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
              
                    
    

