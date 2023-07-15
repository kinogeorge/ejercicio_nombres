using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversacion1
{
    internal class Program
    {

        static void Main(string[] args)
        {
            List<string> listanombres = new List<string>();

            bool otronombre = true;

            //Console.WriteLine("Agrega nombre: ");
            //listanombres.Add(Console.ReadLine());
            //Console.WriteLine("Deseas agregar otro nombre? (y/n)");
            //string input = Console.ReadLine();
            //if (string.Equals(input, "y", StringComparison.OrdinalIgnoreCase))
            //{
            //    otronombre = true;
            //} else 
            //{
            //    otronombre = false; 
            //}
            //if (input.ToUpper() != "Y")
            //{
            //    Console.WriteLine("no entiendo tu respuestra");
            //}
            while (otronombre)
            {
                Console.WriteLine("Agrega nombre: ");
                listanombres.Add(Console.ReadLine());

                Console.WriteLine("Deseas agregar otro nombre? (y/n)");
                string input = Console.ReadLine();
                if (input.ToUpper() == "Y")
                {
                    otronombre = true;
                } else
                {
                    if (input.ToUpper() == "N")
                    {
                        otronombre = false;
                        listanombres.Sort();
                        foreach (string palabra in listanombres)
                        {
                            Console.WriteLine(palabra);
                        }
                        Console.ReadKey();
                    } else
                    {
                        Console.WriteLine("No entendi tu respuesta???");
                        Console.WriteLine("Deseas agregar otro nombre? (y/n)");
                        string pregunta2 = Console.ReadLine();
                        if (pregunta2.ToUpper() == "Y")
                        {
                            otronombre = true;
                        }
                        else
                        {
                            if (pregunta2.ToUpper() == "N")
                            {
                                otronombre = false;
                                listanombres.Sort();
                                foreach (string palabra in listanombres)
                                {
                                    Console.WriteLine(palabra);
                                }
                                Console.ReadKey();
                            }
                            else
                            {
                                Console.WriteLine("No entendi tu respuesta. Se termina proceso");
                                otronombre = false;

                            } if (otronombre == false)
                            {
                                Console.ReadKey();
                            }
                            else
                            {
                                otronombre = true;
                            }
                        }
                    }
                }
            }
        }
 
    }
}