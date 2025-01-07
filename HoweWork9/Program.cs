using System.Diagnostics;

namespace HoweWork9
{
    public class Program
    {
        static void Main(string[] args)
        {

            Exception[] exceptions = new Exception[] { new StringException("Строка не должна быть пустой"), new TimeoutException(), new NotSupportedException(), new IndexOutOfRangeException(), new DivideByZeroException() };
            foreach (Exception exception in exceptions)
            {
                try
                {
                    throw exception;
                }

                catch (StringException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (TimeoutException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }


                //try
                //{
                //    Customer customer = new Customer { Name = "" };
                //}
                //catch (StringException ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
            }


    }
    
    class StringException : Exception
    {
        public StringException(string message) : base(message) { }
    }
    class Customer //клиенты
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    name = value;
                }
                else
                {
                    throw new StringException("Строка не должна быть пустой");
                }
            }
        }
    }

   
}
