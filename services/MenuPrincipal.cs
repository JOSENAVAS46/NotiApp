
using nettest.intefaces;

namespace nettest.services {

    class MenuPrincipal : Menu {
        
        private Menu[] _SubMenus;

        public MenuPrincipal() {

            this._SubMenus = new Menu[] {
                new MenuCategoria(),
                new MenuTarea()
            };

        }

        public void CargarMenu() {

            // Console.WriteLine("Bienvenido a notiapp\n")

        }

    }

}
