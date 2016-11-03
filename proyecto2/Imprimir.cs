using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Imprimir
    {
        public void imprimirGrafo(List<Vertice> grafo)
        {
            foreach (Vertice vertice  in grafo){
                Console.WriteLine(vertice.getNombre());
                foreach (Arista arista in vertice.getAdyacentes())
                {
                    
                }
            }
        }
    }
}
