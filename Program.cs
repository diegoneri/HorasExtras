decimal salario, horaBase, horasTrabalhadas, horasExtras;

Console.Clear();
Console.WriteLine("Cálculo de horas extras");

horaBase = SolicitarValor("Informe sua hora base..........:");
horasTrabalhadas = SolicitarValor("Informe suas horas trabalhadas.:");
horasExtras = SolicitarValor("Informe suas horas extras......:");

salario = CalcularSalario(horaBase, horasTrabalhadas, horasExtras);

Console.WriteLine($"Seu salário é: {salario:C2}");

decimal CalcularSalario(decimal horaBase
                      , decimal horasTrabalhadas
                      , decimal horasExtras)
{
    decimal valorHorasTrabalhadas, valorHorasExtras, valorTotal;
    valorHorasTrabalhadas = horaBase * horasTrabalhadas;
    valorHorasExtras = horaBase * horasExtras * 1.4M;
    valorTotal = valorHorasTrabalhadas + valorHorasExtras;

    return valorTotal;
}

decimal SolicitarValor(string mensagem)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.Write($"{mensagem} ");
    Console.ResetColor();
    return Convert.ToDecimal(Console.ReadLine());
}