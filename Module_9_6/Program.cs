//namespace DelegateDemo
//{
//    public class AnonymousMethods
//    {
//        //public delegate string GreetingsDelegate(string name);
//        //public static string Greetings(string name)
//        //{
//        //    return "Привет @" + name + "! Добро пожаловать на SkillFactory!";
//        //}

//        //static void Main(string[] args)
//        //{
//        //    GreetingsDelegate gd = new GreetingsDelegate(Greetings);
//        //    string GreetingsMessage = gd.Invoke("Будущий гуру");
//        //    Console.WriteLine(GreetingsMessage);
//        //    Console.ReadKey();
//        //}

//        public delegate string GreetingsDelegate(string name);

//        static void Main(string[] args)
//        {
//            GreetingsDelegate gd = delegate (string name)
//            {
//                return "Привет @" + name + " и добро пожаловать на SkillFactory!";
//            };
//            string GreetingsMessage = gd.Invoke("Pranaya");
//            Console.WriteLine(GreetingsMessage);
//            Console.ReadKey();
//        }
//    }
//}

//namespace DelegatePractices
//{
//    class Program
//    {
//        delegate void ShowMessageDelegate(string _message);
//        static void Main(string[] args)
//        {
//            ShowMessageDelegate showMessageDelegate = delegate (string _message)
//            {
//                Console.WriteLine(_message);
//            };
//            showMessageDelegate.Invoke("Hello World!");
//            Console.Read();
//        }        
//    }
//}

//namespace DelegatePractices
//{
//    class Program
//    {
//        delegate void ShowMessageDelegate(string _message);
//        static void Main(string[] args)
//        {
//            ShowMessageDelegate showMessageDelegate = (string _message) => Console.WriteLine(_message);

//            showMessageDelegate.Invoke("Hello World!");
//            Console.Read();
//        }
//    }
//}

//namespace DelegatePractices
//{
//    class Program
//    {
//        delegate int RandomNumberDelegate();
//        static void Main(string[] args)
//        {
//            RandomNumberDelegate randomNumberDelegate = delegate
//            {
//                return new Random().Next(0, 100);
//            };
//            int result = randomNumberDelegate.Invoke();
//            Console.WriteLine(result);
//            Console.Read();
//        }
//    }
//}

namespace DelegatePractices
{
    class Program
    {
        delegate int RandomNumberDelegate();
        static void Main(string[] args)
        {
            RandomNumberDelegate randomNumberDelegate = () => new Random().Next(0, 100);
            
            int result = randomNumberDelegate.Invoke();
            Console.WriteLine(result);
            Console.Read();
        }
    }
}

