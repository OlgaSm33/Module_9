namespace Module_9_5
{
    internal class Program
    {
        delegate void ShowMessageDelegate();
        delegate int SumDelegate(int a, int b, int c);
        delegate bool CheckLengthDelegate(string _row);
        static void Main(string[] args)
        {
            //ShowMessageDelegate showMessageDelegate = ShowMessage;
            //showMessageDelegate.Invoke();

            //SumDelegate sumDelegate = Sum;
            //int result = sumDelegate.Invoke(1, 30, 120);
            //Console.WriteLine(result);

            //CheckLengthDelegate checkLengthDelegate = CheckLength;
            //bool status = checkLengthDelegate.Invoke("skill_factory");
            //Console.WriteLine(status);

            Action< string > showMessageDelegate = ShowMessage;
            showMessageDelegate("Hello world");

            Func< int,int,int,int > sumDelegate = Sum;
            Console.WriteLine(sumDelegate(2, 1, 20));

            Predicate< string > checkLenghtDelegate = CheckLength;
            Console.WriteLine(checkLenghtDelegate("skill_factory"));

        }
        static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }

        static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        static bool CheckLength(string _row)
        {
            if (_row.Length > 3) return true;
            return false;
        }
    }
}
