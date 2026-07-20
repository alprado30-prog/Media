Console.WriteLine("Bem vindo ao comando de cálculo de média:");

double nota1 = LerNota("Digite a primeira nota: ");
double nota2 = LerNota("Digite a segunda nota: ");
double nota3 = LerNota("Digite a terceira nota: ");

double media = (nota1 + nota2 + nota3) / 3;

Console.WriteLine($"A média do aluno é: {media:F2}");

if (media >= 7)
{
    Console.WriteLine($"O aluno está aprovado! com média de {media:F2}");
}
else if (media >= 5)
{
    Console.WriteLine($"O aluno está de recuperação! com média de {media:F2}");
}
else
{
    Console.WriteLine($"O aluno está reprovado! com média de {media:F2}");
}

static double LerNota(string mensagem)
{
    while (true)
    {
        Console.Write(mensagem);

        if (double.TryParse(Console.ReadLine(), out double nota))
        {
            return nota;
        }

        Console.WriteLine("Valor inválido. Digite uma nota válida.");
    }
}
