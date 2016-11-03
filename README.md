# AnalisisProgra2EstrategiasDise-o
Aplicación de estrategias de diseño de algoritmos
Objetivos Desarrollar un programa en el lenguaje c# utilizado las ventajas de OO. Implementar algoritmos NP para determinar rutas cortas.
Implementar diferentes estrategias de diseño de algoritmos y realizar evaluaciones (empíricas y analíticas).

Definición  Hacer un programa para determinar rutas cortas con restricción de saltos usando distintas estrategias de diseño además de medir empíricamente y analíticamente los algoritmos implementados. Las estrategias de diseño deben cumplir con las características de cada estrategia según corresponda. 
Las rutas cortas se calcularán sobre una red: grafo, el cual será fuertemente conexo, los vértices enumerados de 0 a N. Se debe indicar un vértice inicial y n vértice final.
Estrategias:
Backtracking con poda: realizar todas las posibles combinaciones (fuerza bruta), condición de parada cuando haya realizado todas las combinaciones posibles. Debe podar las posibilidades que no cumplan con la restricción de saltos y las rutas que superen el mínimo encontrado. 

Genético: Debe seleccionar la población inicial (mínimo 8 rutas), cruzarla para crear generaciones que convergen a la solución cada vez más óptima, realizar la función de adaptabilidad, para poder decidir cuales rutas sobreviven (eliminar los ciclos si existieran). La mutación debe ser razonada no aleatoria. Se limitará la cantidad de generaciones a realizar.
 

Probabilístico: Debe ir calculando la mejor ruta por cada paso a partir del vértice inicial, una de las variables que debe tomar en cuenta será la cantidad de saltos, para no pasarse del límite establecido. Recuerde que el avance por el grafo debe actualizar las variables de decisión.

Mediciones sobre los algoritmos
Debe realizar pruebas para medir las diferentes estrategias de diseño, probando con diferentes tamaños de grafo 10 vértices, 100 vértices, 500 vértices y 1000 vértices. El límite de saltos será entre el 30% y 50% de la cantidad de vértices (3-5, 30-50, 150-250, 300-500). Con el mismo grafo se deben aplicar las 3 estrategias diseño. Para determinar el factor de talla debe realizar cuatro comparaciones entre los diferentes tamaños. 
Realizar conteos de exploración de arcos y cantidad de memoria consumida en cada estrategia, determinar el factor de crecimiento, clasificar el algoritmos en notación O.
Realizar la medición analítica para cada uno de los algoritmos de las estrategias de diseño.
Usar tablas similares a las que se usaron para el primer proyecto programado.

Operaciones
El programa debe generar los grafos fuertemente conexos, con pesos distintos. 
Realizar la programación de las 3 estrategias de diseño.
            


Consultas
1.	Imprima todas las variables de medición para cada una de las estrategias de diseño.
2.	Imprimir las rutas cortas encontradas, con sus respectivos pesos. 
3.	Imprimir la cantidad de podas realizadas y cantidad de rutas exploradas en la estrategia de backtracking. 
4.	Imprimir todos los cruces realizados para la estrategia genética y su mutación. 
5.	Imprimir la actualización de los valores para los vértices y arcos en la estrategia probabilística.
