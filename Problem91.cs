using System;
namespace Application
{
    class Problem91
    {
        public static void solution()
        {
            Dog dog=new Dog();
            dog.makesound();
            Cat cat=new Cat();
            cat.makesound();
            


        }
        class Animals
        {
            public void makesound()
            {
                Console.WriteLine("some animal sound");
            }
        }
        class Dog:Animals
        {
            public new void makesound()
            {
                Console.WriteLine("Bark");
            }

        }
        class Cat:Animals
        {
            public new void makesound()
            {
                Console.WriteLine("Meow");
            }

        }
    }
}