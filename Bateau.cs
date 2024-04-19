using System;


public class Bateau
{

    public string[] Inventaire { get; protected set; }


    public Bateau()
    {

        Inventaire = new string[] { "Coffre de sécurité", "Gilets de sauvetage", "Carte marine" };
    }


    public void AfficherInventaire()
    {
        Console.WriteLine("Inventaire du bateau :");
        foreach (var item in Inventaire)
        {
            Console.WriteLine(item);
        }
    }
}

public class BateauVoile : Bateau
{

    public BateauVoile()
    {

        Inventaire = new string[] { "Voile", "Mât", "Gouvernail", "Tangon" };
    }
}

public class BateauMoteur : Bateau
{

    public BateauMoteur()
    {

        Inventaire = new string[] { "Moteur", "Réservoir d'essence", "Hélice", "Bouée de traction" };
    }
}

