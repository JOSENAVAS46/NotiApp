
namespace nettest.models {

    public class Categoria {
        
        public long IdCategoria { get; set; }
        
        public string Nombre {get; set;}

        public Categoria(long idCategoria, string nombre) 
            => (IdCategoria, Nombre) = (idCategoria, nombre);

        public override string ToString() {
            return "["+ this.IdCategoria +"]" + this.Nombre + ".";
        }

    }

}
