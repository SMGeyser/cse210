namespace Costume;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Costume World!");


        List<Costume> myCostumes = new List<Costume>();
        Costume detective = new Costume();
        Costume snorkler = new Costume();

        detective._headwear = "Fedora";
        detective._upperGarment = "Trench Coat";
        detective._lowerGarment = "Slacks";
        detective._footwear = "Dress Shoes";
        detective._accessories = "Magnifying Glass";

        snorkler._headwear = "Scuba Mask";
        snorkler._upperGarment = "Wet Suit";
        snorkler._lowerGarment = "Wet Suit";
        snorkler._footwear = "Flippers";
        snorkler._accessories = "Snorkel";

        myCostumes.Add(detective);
        myCostumes.Add(snorkler);

        foreach (Costume c in myCostumes)
        {
            c.Output();
        }
    }
}
