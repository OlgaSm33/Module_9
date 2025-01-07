

namespace HomeWork9._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SecondNamesList asd = new SecondNamesList(new string[] {"klkjl","dad", "dasd"});
            asd.EnterSecondNamesList(3);
            asd.ShowSecondNamesList();

            asd.SortSecondNamesList();
            asd.ShowSecondNamesList();



        }
    }

    class SecondNamesList
    {
        string[] SecondNames;
        public SecondNamesList(string[] secondNames = null)
        {
            SecondNames = secondNames;
        }
        public void EnterSecondNamesList(int count)
        {
            try
            {
                if (SecondNames == null)
                {
                    SecondNames = new string[count];
                    for (int i = 1; i < SecondNames.Length + 1; i++)
                    {
                        while (string.IsNullOrWhiteSpace(SecondNames[i - 1]))
                        {
                            try
                            {
                                Console.WriteLine($"Введите {i} имя");
                                SecondNames[i - 1] = Console.ReadLine();
                                if (string.IsNullOrWhiteSpace(SecondNames[i - 1]))
                                {
                                    throw new StringException("Строка должна содержать символы");
                                }
                            }
                            catch (StringException ex)
                            {
                                Console.WriteLine(ex.Message);

                            }
                        }
                    }
                }
                else
                {
                    throw new SecondNamesEnterException("В данном экземляре уже введён список фамилий");
                }
            }

            catch (SecondNamesEnterException ex)
            {
                Console.WriteLine(ex.Message);
            }
        


        }

        public void ShowSecondNamesList()
        {
            for (int i = 0; i < SecondNames.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {SecondNames[i]}");
            }
        }

        private int EnterSort()
        {
            Console.WriteLine("Введите способ сортировки: 1 - от А до Я, 2 - от Я до А");
            int sort = 0;
            while (sort != 1 && sort != 2)
            {
                try
                {
                    sort = Convert.ToInt32(Console.ReadLine());
                    if (sort != 1 && sort != 2)
                    {
                        throw new FormatException();
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Введено некорректное значение, попробуйте ещё раз");
                }
            }
            return sort;
        }
        public void SortSecondNamesList()
        {
            int sort = EnterSort();
            if (sort == 1)
            {
                Array.Sort(SecondNames);
            }
            else
            {
                Array.Sort(SecondNames);
                Array.Reverse(SecondNames);
            }
        }

    }
    class StringException : Exception
    {
        public StringException(string message) : base(message) { }
    }

    class SecondNamesEnterException : Exception
    {
        public SecondNamesEnterException(string message) : base(message) { }
    }


}

