using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class CrearGrafos
    {
        public List<Vertice> crearVerticesYGrafo(int tamaño,List<Vertice> grafo)
        {
            for (int i = 0; i < tamaño; i++)
            {
                Vertice newVertice = new Vertice();
                newVertice.constructor(i);
                grafo.Add(newVertice);

            }
            return grafo;
        }

        public void agregarAristaGrafo1(int vInicio,int vDestino)
        {
            Arista newArista = new Arista();
            newArista.constructor(Globals.grafo1[vDestino],5);
            Globals.grafo1[vInicio].agregarAdyacente(newArista);


        }
    }
}
