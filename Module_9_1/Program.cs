namespace Module_9_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exception exception = new Exception("Произошло исключение в БД");
            exception.Data.Add("Дата создания исключения: ", DateTime.Now);
            exception.HelpLink = "www.google.com";

        }
    }
}
