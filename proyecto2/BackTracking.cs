using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto2
{
    class BackTracking
    {
        public  void backTracking(int vInicio, int vFinal, int[,] grafo, int saltos, int saltosAcumulados)
        {
            String Recorrido = "";
            Recorrido += vInicio.ToString();

            if ((saltos == saltosAcumulados) && (vInicio != vFinal))
            {
                Recorrido = "";
                return;
            } if (saltosAcumulados > Globals.MinimoBackTracking)
            {
                Recorrido = "";
                return;
            }
            if ((vInicio == vFinal) &&(Globals.MinimoBackTracking > Recorrido.Length))
            {
                Globals.solucionBackTracking = Recorrido;
                Globals.MinimoBackTracking = Recorrido.Length;
            }
            else
            {
                
                for (int z = vInicio; z < grafo.GetLength(0); z++)
                    {
                    for (int i = 0; i < grafo.GetLength(0); i++)
			            {
			                while(z == vInicio){
                                if ((grafo[z,i]!=0)&&(grafo[z,i]!=2))
                                {
                                    backTracking(i, vFinal, grafo, saltos, saltos + 1);
                                }
                            }
			            }
                       
                        
                    }
                
            }
           

        }
    }
}
