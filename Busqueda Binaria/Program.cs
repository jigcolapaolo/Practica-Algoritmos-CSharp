namespace Busqueda_Binaria;
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = new int[]{1,6,5,4};
        Array.Sort(array);
        // El array a utilizar en la funcion debe estar ordenado
        List<int> arrayPath = new List<int>();
        // Lista para agregar los numeros que se tienen en  cuenta al dividir el array y el value 
        // si se encuentra
        int value = 1;

        // Paso el arrayPath por referencia para que en cada recursion siempre tenga en cuenta la
        // misma lista y vaya agregando los numeros.
        int[] resultado = busquedaBinaria(array, ref arrayPath, value);


        // Si el value se encuentra, estara al final de la lista convertida en array, si esta ahi,
        // muestro la lista. Si no, muestro que no se encontro.
        if(resultado[resultado.Length - 1] == value){
            Console.Write(string.Join(", ", resultado));
        }else{
            Console.WriteLine("Value Not Found");
        }

        static int[] busquedaBinaria(int[] array, ref List<int> arrayPath, int value){

            // Busco el indice del numero a la mitad del array y luego lo agrego a la lista.
            int iMedio = (array.Length - 1) / 2;

            arrayPath.Add(array[iMedio]);

            // Si ese numero es el value, devuelvo la lista convertida en array
            if(array[iMedio] == value){
                return arrayPath.ToArray();
            // Si no lo es y es mayor, compruebo si estoy posicionado en el primer numero del array,
            // en ese caso no se puede dividir mas el array. Si no estoy posicionado ahi, divido el
            // array solo tomando los numeros a la izquierda del elemento actual.
            }else if(array[iMedio] > value){
                if(iMedio == 0){
                    return arrayPath.ToArray();
                }else{
                    return busquedaBinaria(array.AsSpan(0, iMedio).ToArray(),
                    ref arrayPath, value);
                }
            // Si no, tomo los de la derecha
            }else{
                return busquedaBinaria(array.AsSpan(iMedio + 1).ToArray(),
                ref arrayPath, value);
            }

            // Una vez realizadas todas las recursiones hasta encontrar el value o que el array no 
            // se pueda dividir mas, retornara el arrayPath convertido en array.
        }
    }
}
