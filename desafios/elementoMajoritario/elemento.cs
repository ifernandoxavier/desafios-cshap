/*
Desafio
Dado um array nums de tamanho n, retorne o elemento majoritário, isto é, o elemento que aparece o maior número de vezes no seu array.

Entrada
A primeira linha da entrada deverá ser o número referente ao tamanho do seu array. As demais linhas nums serão os valores da sua array.

Saída
A saída deverá retornar o número que aparece o maior número de vezes na sua array, ou seja, o elemento majoritário.
*/

// using System;
// using System.Text.RegularExpressions;

// public class Program
// {
//     public static void Main(String[] args)
//     {
//       int n = int.Parse(Console.ReadLine()); int[] num = new int[n]; 
//       for (int i = 0; i < n; i++) 
//       {
//         num[i] = int.Parse(Console.ReadLine()); 
        
//       } 
//       Console.WriteLine(MajorityElement(num)); 
      
//     } 
//     public static int MajorityElement(int[] nums) 
//     { 
//       int major = nums[0];
//       int count = 1;
//       for (int i = 0; i < nums.Length; i++) 
//       {
//         if (major != nums[i]) 
//         {
//           major = nums[i];
//           count = 1;
//         }
//           else 
//           { 
//             if (major == nums[i]) 
//             { 
//               count++; 
              
//             } 
//             else
//             { 
//               count--; 
              
//             } 
//           } 
//       } 
//       return major;
//     }
// }