double consumo, horas, custo, custoMes;

Console.WriteLine("--- Custo de Energia ---");

Console.Write($"Consumo do aparelho (em kWh/mês): ");
consumo = Convert.ToDouble(Console.ReadLine());


Console.Write("Horas de uso por dia...............: ");
horas = Convert.ToDouble(Console.ReadLine());


Console.Write("Custo da energia (em R$/kWh).......: ");
custo = Convert.ToDouble(Console.ReadLine());

custoMes = consumo * horas * custo;

Console.Write($"\nCusto estimado do mês: R${custoMes:F2}");




