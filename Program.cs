double carne, acompanhamentos, refrigerante, cerveja, agua;
int adultos0alcool, adultosalcool, adultos, convidados, crianca;

Console.WriteLine ("==Churras==");

Console.Write("Adultos que não ingerem Alcool..........");
adultos0alcool = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Adultos que ingerem Alcool..............");
adultosalcool = Convert.ToInt32(Console.ReadLine()!);

Console.Write("Crianças.................................");
crianca = Convert.ToInt32(Console.ReadLine()!);

adultos = adultos0alcool + adultosalcool;
convidados = adultos + crianca;

carne = 0.4 * adultos + 0.2 * crianca;
acompanhamentos = 0.2 * convidados;
cerveja = 2 * adultosalcool;
refrigerante = 0.5 * adultos0alcool + crianca;
agua = 0.4 * convidados;

Console.WriteLine($"Carne.............:{carne:N1}Kg");
Console.WriteLine($"Acompanhamentos...:{acompanhamentos:N1}Kg");
Console.WriteLine($"Cerveja...........:{cerveja:N1}L");
Console.WriteLine($"Refrigerante......:{refrigerante:N1}L");
Console.WriteLine($"agua..............:{agua:N1}L");
