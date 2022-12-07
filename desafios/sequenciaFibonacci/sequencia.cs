/*
Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma mensagem avisando se o número informado pertence ou não a sequência.
IMPORTANTE:
Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;
*/

// using desafios.Models;
// using Newtonsoft.Json;  
// using System.Globalization;

// Console.Write("Digite um número para a sequência: ");
// int numeroSequencia = Convert.ToInt32(Console.ReadLine());

// int termo1 = 0;
// int termo2 = 1;
// Console.Write($"{termo1}, {termo2}");

// int count = 3;
// bool pertence = false;

// while (count <= numeroSequencia)
// {
//     int termo3 = termo1 + termo2;
//     Console.Write($", {termo3}");
//     termo1 = termo2;
//     termo2 = termo3;
//     count += 1;
//     if (termo3 == numeroSequencia)
//     {
//         pertence = true;
//     }
// }
// Console.WriteLine("");
// Console.WriteLine($"O número informado para verificar se pertence ou não é {numeroSequencia}");
// Console.WriteLine(pertence ? "O número PERTENCE á sequência" : "O número NÃO PERTENCE á sequência");
