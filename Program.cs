internal class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("Bienvenue chez le loueur de bateaux !");
    Console.WriteLine("Choisissez le type de bateau :");
    Console.WriteLine("1. Bateau à voile");
    Console.WriteLine("2. Bateau à moteur");
    Console.Write("Votre choix : ");

    int choixBateau = int.Parse(Console.ReadLine());

    Bateau bateau;
    switch (choixBateau)
    {
        case 1:
            bateau = new BateauVoile();
            break;
        case 2:
            bateau = new BateauMoteur();
            break;
        default:
            Console.WriteLine("Veuillez choisir 1 ou 2.");
            return;
    }

    Console.Write("Entrez le nombre de passagers : ");
    int nombrePassagers = int.Parse(Console.ReadLine());

    if (nombrePassagers <= 0)
    {
        Console.WriteLine("Nombre de passagers invalide");
        return;
    }

    if (bateau is BateauVoile && nombrePassagers > 4)
    {
        Console.WriteLine("Embarquement impossible, nombre de passagers trop élevé pour un bateau à voile");
        return;
    }
    else if (bateau is BateauMoteur && nombrePassagers > 8)
    {
        Console.WriteLine("Embarquement impossible, nombre de passagers trop élevé pour un bateau à moteur");
        return;
    }

    Console.WriteLine($"Enregistrement de {nombrePassagers} passagers à bord.");


    for (int i = 0; i < nombrePassagers; i++)
    {
        Console.Write($"Nom du passager {i + 1} : ");
        string nomPassager = Console.ReadLine();
        bateau.Passagers.Add(new Passager(nomPassager));
    }

    bateau.Partir();


    bateau.Retour();
}

}
