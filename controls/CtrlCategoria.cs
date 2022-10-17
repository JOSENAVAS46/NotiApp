using nettest.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace notiapp.controls
{
    class CtrlCategoria
    {
        private List<Categoria> lstCategorias = new List<Categoria>();
        private Categoria cat = null;
        ValidacionDatos val = new ValidacionDatos();
        string sl = "\n";

        public CtrlCategoria() 
        {
            lstCategorias.Add(new Categoria(lstCategorias.Count + 1, "General"));
            lstCategorias.Add(new Categoria(lstCategorias.Count + 1, "Desarrollo"));
            lstCategorias.Add(new Categoria(lstCategorias.Count + 1, "UX / UI"));
            lstCategorias.Add(new Categoria(lstCategorias.Count + 1, "Investigacion"));
        }

        public void registrarCategoria()
        {
            Console.WriteLine("----Agregar Categoria----");
            string nombre = val.leerCadena("Nombre de la Categoria:");
            cat = new Categoria(lstCategorias.Count + 1, nombre);
            lstCategorias.Add(cat);
            Console.Clear();

        }

        public void listarCategorias()
        {
            Console.Clear();
            Console.WriteLine(sl + "----Listar Categorias----");
            foreach (Categoria c in lstCategorias)
            {
                Console.WriteLine(c.ToString());
            }
        }

        public void eliminarCategoriaById()
        {
            Console.WriteLine(sl + "----Eliminar Categoria por ID----");

        }


        public List<Categoria> GetLstCategorias()
        {
            return lstCategorias;
        }
        public void SetLstCategorias(List<Categoria> value)
        {
            lstCategorias = value;
        }

       
    }
}