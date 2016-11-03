using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proyecto2
{
    class Program
    {
       
        /*static void imprimirGrafo(int[,] Grafo)
        {
            for (int x = 0; x < Grafo.GetLength(0); x++)
            {
                for (int y = 0; y < Grafo.GetLength(0); y++)
                {
                    Console.Write(String.Format("{0,5:0}", Grafo[x, y]));
                }
                Console.WriteLine();
            }
            Console.WriteLine();

        }
        */

        static void Main(string[] args)
        {
            
            CrearGrafos Grafo1 = new CrearGrafos();
            Globals.grafo1 = Grafo1.crearVerticesYGrafo(5,Globals.grafo1);

            Imprimir imprimirGrafo1 = new Imprimir();
            imprimirGrafo1.imprimirGrafo(Globals.grafo1);


            BackTracking primerGrafo = new BackTracking();


            //vinivio,vfinal,grafo,saltos,saltosacumulados
           // primerGrafo.backTracking(4,1,Globals.grafo1,2,0);
            //Console.WriteLine(Globals.solucionBackTracking+"     "+Globals.MinimoBackTracking);
            Console.ReadKey();
        }
    }


}
