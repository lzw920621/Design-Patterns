using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 工厂模式
{
    enum AnimalType
    {
        Dog,
        Cat,
        Bird
    }

    class AnimalFactory
    {
        
        public static Animal CreatAnimal(AnimalType type)
        {            
            switch(type)
            {
                case AnimalType.Cat:return new Cat();
                    
                case AnimalType.Dog:return new Dog();
                    
                case AnimalType.Bird:return new Bird();

                default:return new Animal();
            }
        }
    }

    class Animal
    {

    }

    class Cat:Animal
    {

    }

    class Dog:Animal
    {

    }

    class Bird:Animal
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Animal cat = AnimalFactory.CreatAnimal(AnimalType.Cat);

        }
    }
}
