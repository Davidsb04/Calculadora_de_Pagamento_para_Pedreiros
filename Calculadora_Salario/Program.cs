Console.Write("Insira o número de pedreiros que prestaram o serviço: ");
int numPedreiros = int.Parse(Console.ReadLine());

for (int i = 1; i <= numPedreiros; i++)
{
    Console.Write("\nInsira o valor do vale alimentação: R$");
    double alimentacao = double.Parse(Console.ReadLine());

    Console.Write("Insira o valor do vale transporte: R$");
    double transporte = double.Parse(Console.ReadLine());

    Console.Write("Insira a quantidade de metros quadrados produzidos: ");
    double metros = double.Parse(Console.ReadLine());

    double valorTotal;

    if (metros < 10)
    {
        valorTotal = alimentacao + (transporte * 2) + 10;
    }
    else if (metros < 20)
    {
        valorTotal = alimentacao + (transporte * 2) + 11.50;
    }
    else
    {
        valorTotal = alimentacao + (transporte * 2) + 13;
    }

    Console.WriteLine("\nO valor a ser pago para o {0}º pedreiro é: R${1}", i, valorTotal);
}
Console.ReadKey();
