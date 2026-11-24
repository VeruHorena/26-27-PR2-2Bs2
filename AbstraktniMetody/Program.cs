namespace AbstraktniMetody
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KOCKA k = new KOCKA();
            Ryba r = new Ryba();
            Console.WriteLine("Ted mluvi kocka");
            k.vydejZvuk();
            Console.WriteLine("Ted mluvi ryba");
            r.vydejZvuk();
        }
    }
}
