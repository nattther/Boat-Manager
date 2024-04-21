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
}
