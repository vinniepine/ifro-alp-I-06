/* /* Instituto Federal de Educação, Ciência e Tecnologia de Rondônia - IFRO
 * C.S.T. em Análise e Desenvolvimento de Sistemas
 * Disciplina de Algoritmo e Lógica de Programação I
 * Professor Clayton Ferraz Andrade
 * 
 * Acadêmico Vinícius de Oliveira Pinheiro
 * Aula do dia 12-04-2023
 */

// Laços de Repetição - Loops

int number = 0, qtd = 0;
int escolha;
Console.WriteLine("Digite o índice da tabuada");
number = int.Parse(Console.ReadLine());
Console.WriteLine("Digite a quantidade da tabuada");
qtd = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha se a tabuada será crescente ou decrescente." +
    "\nPara escolher 'crescente', pressione 1.\nPara escolher 'decrescente', pressione 2.");
escolha = int.Parse(Console.ReadLine());
switch (escolha)
{
    case 1:
        for (int i = 0; i <= qtd; i++)
        { /* para a forma crescente, i <= qti, e deve fazer 
                                         incrementação de adição; por isso, ele deve começar
                                         em 0. */
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
        break;
    case 2:
        for (int i = qtd; i >= 0; i--)
        { /* aqui, invertemos a ordem do case 1*/
            Console.WriteLine(number + " x " + i + " = " + (number * i));
        }
        break;
    default:
        Console.WriteLine("Escolha inválida.Encerrando o programa.");
        break;
}

// Correção do Profº. - Exercício para escolher a contagem crescente ou decrescente.
int op = 0, cont = 0;
Console.WriteLine("\nInforme até quanto deseja contar: ");
cont = int.Parse(Console.ReadLine());
Console.WriteLine("Escolha uma opção.\n1 - Para contar de forma crescente.\n2 - Para" +
    " contar de forma decrescente.");
op = int.Parse(Console.ReadLine());
if (op == 1)
{
    for (int i = 0; i <= cont; i++)
    { /* "i <= cont" indica que o limite de i é aquele indicado
                                    pelo usuário de até onde ele deseja que vá a contagem.
                                    Se "cont" for = a 100, a contagem será feita 100x*/
        Console.WriteLine((i));
    }
}
else
{
    for (int i = cont; i >= 0; i--)
    {
        Console.WriteLine((i));
    }
}