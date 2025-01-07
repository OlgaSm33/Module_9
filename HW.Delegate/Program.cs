namespace HomeWork9._1
{
    internal class Program // класс - подписчик
    {
        static void Main(string[] args)
        {
            SecondNamesList sn = new SecondNamesList(new string[] { "klkjl", "dad", "dasd" });
            sn.ChoiceSortDelegateEvent += SortNames; // подписка на событие ChoiceSortDelegateEvent - когда это событие происходит, вызывается SortNames
            sn.EnterSecondNamesList(3);
            sn.ShowSecondNamesList();
            sn.ChoiceSort();
            sn.ShowSecondNamesList();
        }

        static void SortNames(int sort, SecondNamesList secondNames)
        {
            switch (sort)
            {
                case 1:
                    {
                        secondNames.SortSecondNamesList();
                        break;
                    }
                case 2:
                    {
                        secondNames.SortSecondNamesList();
                        secondNames.ReverseSecondNamesList();
                        break;
                    }
            }
        }
    }

    class SecondNamesList // класс - издатель
    {
        string[] SecondNames;
        public delegate void ChoiceSortDelegate(int sort, SecondNamesList secondNames); //объявляем делегат
        public event ChoiceSortDelegate ChoiceSortDelegateEvent; // объявляем событие (если пользователь выберет вариант сортировки, будет выполнен делегат)
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

        public void ChoiceSort()
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
            ChoiceSortDelegateEvent?.Invoke(sort, this); // если на событие есть подписчики, то вызываем все методы делегата, передавая число sort и текущий экземпляр класса
            
        }
        public void SortSecondNamesList()
        {
            Array.Sort(SecondNames);
        }

        public void ReverseSecondNamesList()
        {
            Array.Reverse(SecondNames);
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

