using System;

namespace InterfaceSegregation
{
    interface IAnimal
    {
        void Fly();
        void Swim();
        void Run();
        void Talk();
        void Listen();
        void Sound();
    }
    public class Bird : IAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Bird Flying.");
        }

        public void Swim()
        {
            Console.WriteLine("Bird Swimming.");
        }

        public void Run()
        {
            Console.WriteLine("Bird Running.");
        }

        public void Talk()
        {
            Console.WriteLine("Bird Talking.");
        }

        public void Listen()
        {
            Console.WriteLine("Bird Listening.");
        }

        public void Sound()
        {
            Console.WriteLine("Bird Making Sound");
        }
    }
    public class Fish : IAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Fish can't fly.");
        }

        public void Swim()
        {
            Console.WriteLine("Fish Swimming.");
        }

        public void Run()
        {
            Console.WriteLine("Fish can't run.");
        }

        public void Talk()
        {
            Console.WriteLine("Fish can't talk.");
        }

        public void Listen()
        {
            Console.WriteLine("Fish can't listen.");
        }

        public void Sound()
        {
            Console.WriteLine("Fish can't make sound.");
        }
    }
    public class Human : IAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Human can't fly.");
        }

        public void Swim()
        {
            Console.WriteLine("Human Swimming.");
        }

        public void Run()
        {
            Console.WriteLine("Human Running.");
        }

        public void Talk()
        {
            Console.WriteLine("Human Talking.");
        }

        public void Listen()
        {
            Console.WriteLine("Human Listening.");
        }

        public void Sound()
        {
            Console.WriteLine("Human Making Sound.");
        }
    }
    public class Cheetah : IAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Cheetah can't fly.");
        }

        public void Swim()
        {
            Console.WriteLine("Cheetah can't swim.");
        }

        public void Run()
        {
            Console.WriteLine("Cheetah Running.");
        }

        public void Talk()
        {
            Console.WriteLine("Cheetah can't talk.");
        }

        public void Listen()
        {
            Console.WriteLine("Cheetah can't listen.");
        }

        public void Sound()
        {
            Console.WriteLine("Cheetah Making Sound.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Bird bird = new Bird();
            bird.Fly();
            bird.Swim();
            bird.Run();
            bird.Talk();
            bird.Listen();
            bird.Sound();
            Console.WriteLine();

            Fish fish = new Fish();
            fish.Fly();
            fish.Swim();
            fish.Run();
            fish.Talk();
            fish.Listen();
            fish.Sound();
            Console.WriteLine();

            Human human = new Human();
            human.Fly();
            human.Swim();
            human.Run();
            human.Talk();
            human.Listen();
            human.Sound();
            Console.WriteLine();

            Cheetah cheetah = new Cheetah();
            cheetah.Fly();
            cheetah.Swim();
            cheetah.Run();
            cheetah.Talk();
            cheetah.Listen();
            cheetah.Sound();
        }
    }
}
