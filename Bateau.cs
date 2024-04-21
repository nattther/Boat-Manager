public class Bateau
{
    public Inventaire InventaireBateau { get; protected set; }


    public void AfficherInventaire()
    {
        InventaireBateau.Afficher();
    }
}

public class BateauVoile : Bateau
{

    public BateauVoile()
    {
        InventaireBateau = new Inventaire(new string[] { "Voile", "Mât", "Gouvernail", "Tangon" });
    }
}

public class BateauMoteur : Bateau
{

    public BateauMoteur()
    {
        InventaireBateau = new Inventaire(new string[] { "Moteur", "Réservoir d'essence", "Hélice", "Bouée de traction" });
    }
}
