int CalculCarre(int nombre)
{	
	return nombre*nombre;
}

int nombre;
Console.WriteLine("Saisir un entier");
nombre = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalculCarre(nombre));
