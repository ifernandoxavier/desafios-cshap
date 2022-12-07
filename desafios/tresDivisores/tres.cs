/*
Desafio
Dado um inteiro n, retorne true se n tiver exatamente três divisores positivos. Caso contrário, retorne false. O inteiro m é um divisor de n, se existe um inteiro k tal que n = k * m. 
Entrada
O arquivo de entrada consiste em um inteiro n que será validada caso esteja sob as condições do desafio.
Saída
A saída consistirá em um tipo booleano: true ou false.
*/
// using System;
 
// class Solution {
//     public static void Main(string[] args) {
//         int valor = int.Parse(Console.ReadLine());
//         int count = 0;
//         for (int divisor = 1; divisor <= valor; divisor++) 
//         {
//           if (valor % divisor == 0) 
//           {
//             count++;
//           }
//         }
//         if (count >= 3) 
//         {
//           Console.WriteLine(true);
//         }
//         else
//         {
//           Console.WriteLine(false);
//         }
//          //Console.WriteLine(count == 3);
//     }
// }