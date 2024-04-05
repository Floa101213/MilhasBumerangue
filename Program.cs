double PercentualDeBonus, PercentualDeretorno;
double pontosATransfrerir, pontosAReduzir, pontosAAcrescentar;

Console.Clear();
Console.WriteLine("--milhas bumerangue---\n");

Console.Write("Percentual de bonus.....: ");
PercentualDeBonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Percentual de retorno.....: ");
PercentualDeretorno = Convert.ToDouble(Console.ReadLine());

Console.Write("pontosATransferir.....: ");
pontosATransfrerir = Convert.ToDouble(Console.ReadLine());

 pontosAReduzir= pontosATransfrerir - (pontosATransfrerir * PercentualDeretorno) / 100;
 pontosAAcrescentar = pontosATransfrerir + (pontosATransfrerir * PercentualDeretorno) / 100;

Console.WriteLine();
Console.WriteLine($"Pontos a reduzir na origem........: {pontosAReduzir}");
Console.WriteLine($"pontos a acrescentar no destino...: {pontosAAcrescentar}");