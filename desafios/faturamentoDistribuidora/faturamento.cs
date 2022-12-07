/*
Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
• O menor valor de faturamento ocorrido em um dia do mês;
• O maior valor de faturamento ocorrido em um dia do mês;
• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
IMPORTANTE:
a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
*/

// using desafios.Models;
// using Newtonsoft.Json;  
// using System.Globalization;

// String conteudoArquivo = File.ReadAllText("Arquivos/dados.json");
// List<Dado> listaVenda = JsonConvert.DeserializeObject<List<Dado>>(conteudoArquivo);

// int menorValorDia = 0;
// int maiorValorDia = 0;
// int quantidadeDiasMaioresFaturamento = 0;
// int quantidadeDiasFaturamento = 0;
// decimal valorTotal = 0;
// decimal maiorValor = 0;
// decimal menorValor = 0;
// decimal mediaMensal = 0;

// foreach (Dado dado in listaVenda)
// {
//     valorTotal += dado.Valor;
//     if (dado.Valor != 0)
//     {  
//         quantidadeDiasFaturamento++;
//     }
//     if (dado.Valor > maiorValor)
//     {
//         maiorValor = dado.Valor;
//         maiorValorDia = dado.Dia;
//     }
//     if (dado.Dia == 1)
//     {
//         menorValor = dado.Valor;
//     }
//     if (dado.Valor <= menorValor && dado.Valor != 0)
//     {
//         menorValor = dado.Valor;
//         menorValorDia = dado.Dia;
//     }
//     // calculando media mensal
//     mediaMensal = valorTotal / quantidadeDiasFaturamento;
//     if (dado.Valor >= mediaMensal)
//     {
//         quantidadeDiasMaioresFaturamento++;
//     }
// }
// Console.WriteLine($"Dia {menorValorDia} ocorreu o menor faturamento do mês, faturamento de: {menorValor.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"Dia {maiorValorDia} ocorreu o maior faturamento do mês, faturamento de: {maiorValor.ToString("C", CultureInfo.CurrentCulture)}");
// Console.WriteLine($"No mês, tiveram {quantidadeDiasMaioresFaturamento} dias, que o faturamento foi maior que a média mensal - Média mensal:{mediaMensal.ToString("C", CultureInfo.CurrentCulture)}");
