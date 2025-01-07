namespace Module_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Блок try сработал");
                Method2();
            }
          
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace.ToString());
            }
            finally
            {
                Console.WriteLine("Блок finally сработал");
            }
        }

        static void Method1()
        {
            try
            {
                throw new Exception("Внутреннее исключение");
            }

            catch (Exception)
            {
                throw;
            }
        }

        static void Method2()
        {
            try
            {
                Method1();
            }

            //catch (Exception)
            //{
            //    throw;
            //}
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
