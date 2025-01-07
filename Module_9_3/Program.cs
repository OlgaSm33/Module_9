namespace Module_9_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //try 
            //{
            //    throw new ArgumentOutOfRangeException();
            //}
            //catch (Exception ex) when (ex is ArgumentOutOfRangeException)
            //{
            //    Console.WriteLine("ex.Message");
            //}

            try
            {
                throw new RankException();
            }
            catch (RankException ex)
            {
                Console.WriteLine(ex.GetType());
            }



        }
    }
}
