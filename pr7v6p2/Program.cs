using System;
using pr7v6;
namespace pr7v6p2
{
    class Program
    {
        static void Main(string[] args)
        {
            
               Class1 [] cpu;
            Console.WriteLine("введіть кількість процесорів");
            int a = Convert.ToInt32(Console.ReadLine());
            cpu = new Class1[a];
            for (int i = 0; i < a; i++)
            {
                Class1 cp = new Class1();
                cpu[i] = cp;
                Console.WriteLine("Модель процесора ");
                cp.modelCPU = Console.ReadLine();
                Console.WriteLine("Країна виробник ");
                cp.country = Console.ReadLine();
                Console.WriteLine("кількість ядер ");
                cp.kernel = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("присутня відеопамять");
                cp.VidCard = Console.ReadLine();
                Console.WriteLine("тип памяті ");
                cp.typeMemor = Console.ReadLine();
                Console.WriteLine("кількість потоків");
                cp.potokiv = Convert.ToInt32(Console.ReadLine());
                
            }
            foreach(Class1 It in cpu)
            {
                It.CPUinfo();
            }
        }
    }
}
