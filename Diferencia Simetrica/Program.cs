namespace Diferencia_Simetrica;
using System;

class Program
{
    static void Main(string[] args)
    {
            // En esta funcion puedo agregar todos los elementos List que quiera
        var result = diferenciaSimetrica(new List<int>{3, 3, 3, 2, 5}, new List<int>{2, 1, 5, 7}, new List<int>{3, 4, 6, 6}, new List<int>{1, 2, 3}, new List<int>{5, 3, 9, 8}, new List<int>{1});
            // El string.Join(caracterSeparador, Lista) funciona asi, pondra una "," entre cada elemento.
        Console.WriteLine(string.Join(", ", result));
    }

            // (params List<int>[] sets) Toma todos los elementos List utilizados como parametros y los
            // asigna a la variable sets
    static List<int> diferenciaSimetrica(params List<int>[] sets){


            // Si no hay elementos en sets o solo hay un elemento en el indice 0, dara una excepcion.
        if(sets == null || sets.Length == 0){
            throw new ArgumentException("Debe ingresar mas de una cadena");
        }

            // Envio los elementos del indice 0 y 1 para extraer la diferencia simetrica entre ambos
        List<int> result = calcularDiferenciaSimetrica(sets[0], sets[1]);

        for(int i = 2; i < sets.Length; i++){
                // Si el indice es menor a la cantidad de elementos, quiere decir que hay que continuar
                // calculando la diferencia simetrica hasta haberlo hecho con todos
            result = calcularDiferenciaSimetrica(result, sets[i]);
        }
            // Se usa Distinct para eliminar los elementos duplicados de la List final
        return result.Distinct().ToList();
    }

    static List<int> calcularDiferenciaSimetrica(List<int> set1, List<int> set2){

            // En el set 1, donde sus elementos no se encuentren en el set 2 y viceverse, luego se concatenan
            // ambos sets
        return set1.Where(e => !set2.Contains(e)).Concat(set2.Where(e => !set1.Contains(e))).ToList();
    }
}
