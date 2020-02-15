using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;

namespace Sistema_de_Evacuacion.DB
{
    class MyDB : DataContext
    {
        private const String cadenaConexion = "CADENA_DE_CONEXION";        
        public Table<Tabla_Usuario> Usuarios;
        public MyDB() : base(cadenaConexion) { }
    }
}