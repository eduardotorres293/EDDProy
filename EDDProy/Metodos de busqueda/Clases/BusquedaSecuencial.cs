using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EDDemo.Estructuras_Lineales.Clases;

namespace EDDemo.Metodos_de_busqueda.Clases
{
    public class BusquedaSecuencial
    {
        // Aquí si puede ser usada la clase lista anteriormente realizada, debido a que la funcion
        // Buscar de la propia lista realiza una busqueda secuencial
        public static string FuncionSecuencial(Listas lista, string elemento)
        {
            string resultado = lista.Search(elemento);

            if (!string.IsNullOrEmpty(resultado))
            {
                return "Elemento encontrado en las posiciones: " + resultado;
            }
            else
            {
                return "Elemento no encontrado";
            }
        }
    }
}
