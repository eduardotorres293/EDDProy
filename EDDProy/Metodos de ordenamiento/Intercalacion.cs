using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDDemo.Metodos_de_ordenamiento
{
    public class Intercalacion
    {
        public List<int> IntercalarListas(List<int> lista1, List<int> lista2)
        {
            List<int> listaIntercalada = new List<int>();
            int i = 0, j = 0;
            while (i < lista1.Count && j < lista2.Count)
            {
                if (lista1[i] < lista2[j])
                {
                    listaIntercalada.Add(lista1[i]);
                    i++;
                }
                else
                {
                    listaIntercalada.Add(lista2[j]);
                    j++;
                }
            }
            while (i < lista1.Count)
            {
                listaIntercalada.Add(lista1[i]);
                i++;
            }
            while (j < lista2.Count)
            {
                listaIntercalada.Add(lista2[j]);
                j++;
            }

            return listaIntercalada;
        }
    }
}
