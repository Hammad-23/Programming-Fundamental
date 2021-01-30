using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter your name");
            //string name = Console.ReadLine();
            //int age = 20;
            //Console.WriteLine(name + " is " + age + " years old");

            //string any = "total" + 2 + 2;
            //Console.WriteLine(any);

            //string firstName = "Syed Hammad";
            //string lastName = "Ahmed";
            //Console.WriteLine("Students first name is {0}\n and last name is {1}",firstName,lastName);
            //Console.WriteLine("\f");
            //int num1 = 10;
            //int num2 = 5;
            //Console.WriteLine("sum of " + (num1 + num2));
            //Console.WriteLine("Div of " + num1 / num2);

            //Lab TAsk 3
            //Q1;

            //Console.WriteLine("Enter value of mass");
            //int mass = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter value of velocity");
            //int velocity = Convert.ToInt32(Console.ReadLine());
            //double velocitySquare = Math.Pow(velocity, 2);
            //Console.WriteLine("velicity square--> {0} ", velocitySquare); 
            //double kineticEnergy = (0.5) * (double)mass * (double)velocitySquare;
            //Console.WriteLine("kinetic energy--> {0} ", kineticEnergy);
            //Console.WriteLine("Value of kinetic energy is {0}", kineticEnergy);


            //Q2

            //Console.WriteLine("Enter value of initial velocity");
            //int initialVelocity = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter value of time");
            //int time = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter value of acceleration");
            //int acceleration = Convert.ToInt32(Console.ReadLine());
            //double timeSquare = Math.Pow(time, 2);
            //double distance = ((double)initialVelocity * (double)time) + (0.5) * ((double)acceleration * (double)timeSquare);
            //Console.WriteLine("Value of distance is {0}", distance);



            //Q3

            Console.WriteLine("Enter value of initial velocity");
            int initialVelocity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of final velocity");
            int finalVelocity = Convert.ToInt32(Console.ReadLine());
            double averageVelocity = ((double)initialVelocity + (double)finalVelocity) / 2;
            Console.WriteLine("Value of average velocity is {0}", averageVelocity);



        }
    }
}
