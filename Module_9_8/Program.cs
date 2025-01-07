//namespace Module_9_8
//{
//    internal class Program
//    {
//        public delegate Animal HandlerMethod();
//        public delegate void DogInfo(Dog dog);

//        public static Animal AnimalHandler()
//        {
//            return null;
//        }

//        public static Dog DogHandler()
//        {
//            return null;
//        }
//        static void Main(string[] args)
//        {
//            HandlerMethod handlerMethod = AnimalHandler;
//            HandlerMethod handlerMethod1 = DogHandler; // ковариация делегатов 
//            DogInfo dogInfo = GetAnimalInfo;
//            dogInfo.Invoke(new Dog()); // контрвариация делегатов
//        }

//        public static void GetAnimalInfo(Animal p)
//        {
//            Console.WriteLine(p.GetType());
//        }

//    }
//    class Animal
//    {

//    }

//    class Dog : Animal
//    {

//    }
//}


//namespace Module_9_8
//{
//    internal class Program
//    {
//        public delegate Car HandlerMethod();

//        public static Car CarHandler()
//        {
//            return null;
//        }

//        public static Lexus LexusHandler()
//        {
//            return null;
//        }
//        static void Main(string[] args)
//        {
//            HandlerMethod handlerMethod = CarHandler;
//            HandlerMethod handlerMethod1 = LexusHandler; // ковариация делегатов 
//        }

//    }
//    class Car
//    {

//    }

//    class Lexus : Car
//    {

//    }
//}


namespace Module_9_8
{
    internal class Program
    {
        public delegate void ChildInfo(Child child);


        static void Main(string[] args)
        {
 
            ChildInfo childInfo = ParentInfo;
            childInfo.Invoke(new Child()); // контрвариация делегатов
        }

        public static void ParentInfo(Parent p)
        {
            Console.WriteLine(p.GetType());
        }

    }
    class Parent
    {

    }

    class Child : Parent
    {

    }
}