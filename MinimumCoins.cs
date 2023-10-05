using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class MinimumCoins
    {
        public static int minumum_coins(int num, int[] coins)
        {
            int resultado = 0; //Almaceno el número de monedas
            int[] ordered_coins = coins.OrderByDescending(x => x).ToArray(); //Lo primero es ordenar los números, ya que se debe contar desde la moneda de mayor denominación

            foreach(int coin in ordered_coins) //Iteración según el número de monedas O(n)
            {                
                while (num >= coin ) //Siempre que el monto restante sea mayor o igual a la moneda, se acumulará la misma
                {
                int temp_result = (int)((float.Parse(num.ToString()) / float.Parse(coin.ToString()))); //Hago una división para determinar cuántas veces cabe esta moneda en el resultado
                resultado = resultado + temp_result; //Acumulo el número de monedas que caben a la suma total
                    num = num - (coin * temp_result); //Disminuyo el saldo para continuar con el ciclo while
                }
            }

        return resultado;
        }
    }

