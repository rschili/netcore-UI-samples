namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = _Library.NetCoreClass.DoSomething();
            System.Console.WriteLine(message);
            System.Console.ReadLine();
        }
    }
}
