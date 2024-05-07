int[] nots = new int[5];

string[] estudent = new string[] {"Juan","Carlos","Pablo"};

int[] prom = new int[estudent.Length];

for (int i = 0; i < estudent.Length; i++)
{
	Console.WriteLine($"{estudent[i]} ingrese sus 5 notas");
	for (int a = 0; a < nots.Length; a++)
	{
		nots[a] = Convert.ToInt16(Console.ReadLine());
		prom[i] = prom[i] + nots[a];
	}
}
for (int i = 0; i < estudent.Length; i++)
{
	Console.WriteLine($"{estudent[i]}, su promedio es de {prom[i]/5}");
}
