using System;

namespace task2_animals
{
    public abstract class Animals
    {
        public abstract void Description();
        public class ZooAnimal : Animals
        {
            public ZooAnimal(int age, string name, string species)
            {
                this.age = age;
                this.name = name;
                this.species = species;
            }
            public int age;
            public string name;
            public string species;

            public override void Description()
            {
                System.Console.WriteLine($"Имя животного: {name}\n Вид: {species}\n Возраст: {age}");
            }
        }
        public class WildAnimal : Animals
        {
            public WildAnimal(int age, string species)
            {
                this.age = age;
                this.species = species;
            }
            public string species;
            public int age;

            public override void Description()
            {
                System.Console.WriteLine($"Вид животного: {species}\n Возраст: {age}");
            }
        }
    }
}
