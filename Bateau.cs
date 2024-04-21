public class Bateau
{
    public Inventaire InventaireBateau { get; protected set; }
    public List<Passager> Passagers { get; private set; }
    public Bateau()
    {
        Passagers = new List<Passager>();
        InventaireBateau = new Inventaire();
    }

    public virtual void Partir()
    {
        Console.WriteLine("Le bateau démarre... Tchoutchou !");
        Thread.Sleep(2000); 
    }
    
    public virtual void EmbarquerPassagers(int nombrePassagers)
    {
        Console.WriteLine($"Embarquement de {nombrePassagers} passagers...");
    }


  public virtual void Retour()
{
    Console.WriteLine("Arrivée à destination. Vérification de l'inventaire :");

}

}
public class BateauVoile : Bateau
{
    public BateauVoile()
    {

        InventaireBateau = new Inventaire(new string[] { "Boisson", "Voile", "Gilet" });
    }


    public override void Partir()
    {
        Console.WriteLine("Le bateau à voile largue les amarres... fiouuu !");
        Thread.Sleep(2000); 
    }


    public override void Retour()
    {
        Console.WriteLine("Arrivée à destination pour le bateau à voile.");

    Console.WriteLine("Passagers à bord :");
    
    foreach (var passager in Passagers)
    {
        Console.WriteLine($"{passager.Nom} a profité du voyage");
    }
                    Thread.Sleep(2000); 
    InventaireBateau.VerifierInventaire();
    }
}

public class BateauMoteur : Bateau
{
    public BateauMoteur()
    {

        InventaireBateau = new Inventaire(new string[] { "Moteur", "Réservoir d'essence", "boisson" });
    }


    public override void Partir()
    {
        Console.WriteLine("Le bateau à moteur démarre son moteur... Tchoutchou !");
        Thread.Sleep(2000); 
    }


    public override void Retour()
    {
        Console.WriteLine("Arrivée à destination pour le bateau à moteur.");

    Console.WriteLine("Passagers à bord :");
    
    foreach (var passager in Passagers)
    {
        Console.WriteLine($"{passager.Nom} a profité du voyage");
    }
                    Thread.Sleep(2000); 
    InventaireBateau.VerifierInventaire();
    }
}
