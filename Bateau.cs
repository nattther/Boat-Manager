public class Bateau
{
    public Inventaire InventaireBateau { get; protected set; }

    public Bateau()
    {

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
        InventaireBateau.VerifierInventaire();
    }
}
public class BateauVoile : Bateau
{
    public BateauVoile()
    {

        InventaireBateau = new Inventaire(new string[] { "Voile", "Mât", "Gouvernail", "Tangon" });
    }


    public override void Partir()
    {
        Console.WriteLine("Le bateau à voile largue les amarres... fiouuu !");
        Thread.Sleep(2000); 
    }


    public override void Retour()
    {
        Console.WriteLine("Arrivée à destination pour le bateau à voile. Vérification de l'inventaire :");
        InventaireBateau.VerifierInventaire();
    }
}

public class BateauMoteur : Bateau
{
    public BateauMoteur()
    {

        InventaireBateau = new Inventaire(new string[] { "Moteur", "Réservoir d'essence", "Hélice", "Bouée de traction" });
    }


    public override void Partir()
    {
        Console.WriteLine("Le bateau à moteur démarre son moteur... Tchoutchou !");
        Thread.Sleep(2000); 
    }


    public override void Retour()
    {
        Console.WriteLine("Arrivée à destination pour le bateau à moteur. Vérification de l'inventaire :");
        InventaireBateau.VerifierInventaire();
    }
}
