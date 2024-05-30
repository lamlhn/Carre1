//Role: calcul le carre de l'entier fourni en parametre
//Parametres d'entree:
//nombre: entier dont on calcule le carre (en entree)
//Valeur retour: nombre eleve a la puissance 2
int CalculCarre(int nombre)
{	
	return nombre*nombre;
}

int nombre;
Console.WriteLine("Saisir un entier");
nombre = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(CalculCarre(nombre));
