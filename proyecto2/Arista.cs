using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Arista
    {
        private int Peso;
        private Vertice verticeDestino;


        public void constructor(Vertice vDestino,int aPeso )
        {
            this.Peso = aPeso;
            this.verticeDestino = vDestino;
           

        }

        public int getAristaPeso()
        {
           return this.Peso;      
        }




    }
}
