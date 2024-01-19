namespace Actualizacion_de_Inventario;
using System;

class Program
{
    static void Main(string[] args)
    {
        List<object> curInv = new List<object>{
            new List<object> {21, "Bowling Ball"},
            new List<object> {2, "Dirty Sock"},
            new List<object> {1, "Hair Pin"},
            new List<object> {5, "Microphone"}
        };

        List<object> newInv = new List<object>{
            new List<object> {2, "Hair Pin"},
            new List<object> {3, "Half-Eaten Apple"},
            new List<object> {67, "Bowling Ball"},
            new List<object> {7, "Toothpaste"}
        };

        for(int i = 0; i < curInv.Count; i++){

            bool ban = false;
            var curItem = (List<object>)curInv[i];


            // Recorre la nueva lista teniendo en cuenta la lista actual.
            for(int ic = 0; ic < newInv.Count; ic++){
                var newItem = (List<object>)newInv[ic];

                // Dara true si en esta posicion, ambos strings son iguales
                if(newItem[1].Equals(curItem[1])){
                    curItem[0] = (int)newItem[0] + (int)curItem[0];

                    ban = true;
                    // Si pasa una vez por aca quiere decir que encontro un mismo objeto, no hace falta agregar nuevo.
                }

                    // Si estoy en el ultimo indice de ambas listas y no encontro un objeto igual, entonces
                    // agrego este elemento a la lista en vez de sumarlo a uno existente.
                if(i == (curInv.Count - 1) && ic == (newInv.Count - 1) && !ban){

                    curInv.Add(new List<object> { newItem[0], newItem[1] });
                }
            }

        }

        // Ordena la lista segun el segundo elemento de la lista [1] en orden alfabetico
        curInv = curInv.OrderBy(item => Convert.ToString(((List<object>)item)[1])).ToList();

        foreach(var item in curInv){


                // Comprueba si es un List<object> para poder realizar la conversion a string luego.
            if (item is List<object> listItem && listItem.Count >= 2)
            {
                int quantity = (int)listItem[0];
                string itemName = (string)listItem[1];
                Console.WriteLine(quantity + " " + itemName);
            }
            else
            {
                Console.WriteLine("Elemento no válido en curInv");
            }
        }
    }
}
