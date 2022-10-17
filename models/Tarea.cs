
namespace nettest.models {
    
    class Tarea {
        
        public long IdTarea {get; set;}
        
        public string Titulo {get; set;}

        public string Descripcion {get; set;}

        public Categoria Categoria {get; set;}

        public Tarea(long idTarea, string titulo,  string descripcion, Categoria categoria)
            => (IdTarea, Titulo, Descripcion, Categoria) = (
                idTarea, titulo, descripcion, categoria );

    }

}
