namespace Module_9_4
{
    internal class Program
    {
        public delegate void MinusDelegate(int x, int y);
        static void Main(string[] args)
        {
            MinusDelegate minus = Minus;
            minus += Plus;
            minus(5,7);
            minus -= Plus;
            //var result = minus.Invoke(5, 7);


        }

        static void Minus(int x, int y) 
        {
            Console.WriteLine(x - y);

        }

        static void Plus(int x, int y)
        {
            Console.WriteLine(x + y);  
        }
    }
}
