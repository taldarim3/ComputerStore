using System.ServiceModel;

class Program
{
    public static void Main(string[] args)
    {
        using (var host = new ServiceHost(typeof(ComputerStoreService.StoreService)))
        {
            host.Open();

            Console.WriteLine("Host started");
            Console.ReadLine();
        }
    }
}