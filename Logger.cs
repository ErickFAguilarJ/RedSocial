using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocial
{
    public sealed class Logger
    {

        //se crea una instancia llamada Log que se puede usar sin instanciar al objeto Logger
        private static readonly Logger Log= new Logger();

        // Evita instanciar nuevas instancias al ser privado el constructor
        private Logger() { 
        }

        //Se le asigna el alias de LogSystem al get de la instancia Log 
        public static Logger LogSystem
        {
            get {
                return Log;
            }
        }


        // Todas las funciones referentes a los archivos 

        public void RegistroUsuarios(string id_usuario_,string usuario_, string hashpassword_, string correo, string descripcion, bool active_, string path_)
        {
        }

        public string GetUserIdByName(string name_, string path_)
        {
            return "";
        }

        public void SuspenderUsuario(string id_usuario_, string descripcion_baja_, string path_) 
        { 

        }

        public void SubirImagen(string id_usuario, string id_image, string description, string image_path, string path_)
        {

        }












    }
}
