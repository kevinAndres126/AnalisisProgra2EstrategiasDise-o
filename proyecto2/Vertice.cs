using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class Vertice
    {
        private int nombre;
        private bool vistado = false;
        private List<Arista> adyacentes;
        


        public void constructor(int nombre)
        {
            this.nombre = nombre;      
        }
        public void agregarAdyacente(Arista adyacente){
            this.adyacentes.Add(adyacente);
        }

        public void cambiarEstado()
        {
            this.vistado = true;
        }

        public String getNombre()
        {
            return this.nombre.ToString();
        }
        public List<Arista> getAdyacentes()
        {
            return this.adyacentes;
        }
        
            
    }
    
    
}
