
using System;
using System.Collections.Generic;
using nettest.models;
using notiapp.controls;

namespace nettest
{

    class Program
    {

        CtrlCategoria ctrlCat = new CtrlCategoria();
        ValidacionDatos val = new ValidacionDatos();

        static void Main(string[] args)
        {
            Program p = new Program();
            string sl = "\n";
            string msg =  sl + "----CATEGORÍAS----"
                        + sl + "[1] Mostrar categorías."
                        + sl + "[2] Agregar categoría."
                        + sl + "[3] Editar categoría."
                        + sl + "[4] Eliminar categoría."
                        + sl + "[0] Salir." 
                        + sl + "Elija su Opcion." 
                        + sl;
            int opc = 0;
            do
            {
                opc = p.val.leerEntero(msg);
                switch (opc)
                {
                    case 1:
                        p.ctrlCat.listarCategorias();
                        break;
                    case 2:
                        p.ctrlCat.registrarCategoria();
                        break;
                    case 3:
                        break;
                    case 4:
                        p.ctrlCat.eliminarCategoriaById();
                        break;
                }
            } while (opc != 0);

        }

        
    }

}
