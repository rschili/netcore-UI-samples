namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = NetCoreLibrary.NetCoreClass.DoSomething();
            System.Console.WriteLine(message);
            System.Console.ReadLine();
        }
    }
}
