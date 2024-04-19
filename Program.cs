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
                Console.WriteLine("Choix invalide. Veuillez choisir 1 ou 2.");
                return;
        }


        bateau.AfficherInventaire();
    }

}