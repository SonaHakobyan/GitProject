namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = "local change";
            new Class1().LocalPrint(str);
            new Class1().LocalPrint("Local Change");
        }
    }
}
