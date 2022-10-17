using System;
using System.Collections.Generic;
using System.Text;

namespace notiapp.controls
{
    class ValidacionDatos
    {
        public string leerCadena(string msg)
        {
            string cadena = "";
            bool bnd = false;
            do
            {
                try
                {
                    Console.WriteLine(msg);
                    cadena = Console.ReadLine();
                    if (cadena != "")
                    {
                        bnd = true;
                    }
                    else if (cadena == "")
                    {
                        Console.WriteLine("Ingrese almenos un caracter.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (bnd == false);
            return cadena;
        }



        public int leerEntero(string msg)
        {
            int entero = 0;
            bool bnd = false;
            do
            {
                try
                {
                    Console.WriteLine(msg);
                    entero = int.Parse(Console.ReadLine());
                    if (entero >= 0)
                    {
                        bnd = true;
                    }
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Formato Invalido, Se esperaba un Numero Entero.");
                }
                catch (OverflowException oe)
                {
                    Console.WriteLine("El numero Ingresado es demasiado Largo.");

                }
            } while (bnd == false);
            return entero;
        }

    }

}
