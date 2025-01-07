namespace Module_9_9
{
    public class Program
    {

        static void Main(string[] args)
        {
            NumberReader numberReader = new NumberReader();
            numberReader.NumberEnteredEvent += ShowNumber;
            while (true)
            {
                try
                {
                    numberReader.Read();
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error error");
                }
            }
        }

        static void ShowNumber(int number)
        {
            switch(number)
            {
                case 1: Console.WriteLine("Enter 1"); break;
                case 2: Console.WriteLine("Enter 2"); break;
            }

        }
    }

    class NumberReader
    {
        public delegate void NumberEnterDelegate(int number);
        public event NumberEnterDelegate NumberEnteredEvent;
        public void Read()
        {
            Console.WriteLine();
            Console.WriteLine("Enter number 1 or 2");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number != 1 && number != 2)
            {
                throw new FormatException();
            }
            NumberEnterted(number);

        }

        protected void NumberEnterted(int number)
        {
            NumberEnteredEvent?.Invoke(number);
        }
    }
}
