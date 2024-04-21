public class Inventaire
{
    public string[] Items { get; protected set; }

    public Inventaire()
    {
        Items = new string[] { };
    }

    public Inventaire(string[] items)
    {
        Items = items;
    }

    public virtual void Afficher()
    {
        Console.WriteLine("Inventaire :");
        foreach (var item in Items)
        {
            Console.WriteLine(item);
        }
    }

    public void VerifierInventaire()
    {
        Console.WriteLine("Vérification de l'inventaire :");

        foreach (var item in Items)
        {
            Console.WriteLine($"Vérifiez l'élément : {item} (oui/non)");
            string reponse = Console.ReadLine();

            if (reponse.ToLower() == "oui" || reponse.ToLower() == "o")
            {
                Console.WriteLine($"[OK] {item}");
            }
            else
            {
                Console.WriteLine($"[Manquant] {item}");
            }
        }
    }
}
