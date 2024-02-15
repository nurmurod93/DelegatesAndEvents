using DelegatesAndEvents;

public class Program
{

    public static void Tugma_Click()
    {
        Console.WriteLine("Tugma bosildi.");
    }
    public static void Button_Click()
    {
        Console.WriteLine("Button clicked.");
    }

    public static void Main(string[] args)
    {
        Tugma tugma = new Tugma();
        tugma.Click += Tugma_Click;
        tugma.Click += Button_Click;

        tugma.Simulation();

        tugma.Click -= Tugma_Click;
        tugma.Click -= Button_Click;

        Console.ReadLine();
    }
}
