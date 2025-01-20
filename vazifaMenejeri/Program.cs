using System;
namespace vazifaMenejeri
{
    class VazifaMenejeri
    {
        static void Main()
        {
            int cmd = 0;
            string[] tasks = ["ertalab turish", "ovqat yeyish"];
            PrintTasks(tasks);
            do
            {
                Console.WriteLine("|--------------------------------------------|");
                Console.WriteLine("| Amallar                                    |");
                Console.WriteLine("| 1. Vazifa qo'shish                         |");
                Console.WriteLine("| 2. Vazifani o'chirish                      |");
                Console.WriteLine("| 3. Vazifaning bajarilganligini belgilash   |");
                Console.WriteLine("| 4. Vazifalar ro'yxatini ko'rish            |");
                Console.WriteLine("| 5. Dasturdan chiqish                       |");
                Console.WriteLine("|--------------------------------------------|");
                Console.Write("Tanlovni kiriting:         ");
                cmd = Convert.ToInt32(Console.ReadLine() ?? "");
                switch (cmd)
                {

                    //1.Vazifa qo'shish
                    case 1:
                        System.Console.WriteLine("Yangi vazifa nomini kiriting:");
                        string newTask = Console.ReadLine() ?? "";
                        Array.Resize(ref tasks, tasks.Length + 1);
                        tasks[tasks.Length - 1] = newTask;
                        PrintTasks(tasks);
                        break;

                    //2.Vazifani o'chirish
                    case 2:
                        Console.WriteLine("Natija: " + string.Join(", ", tasks));
                        System.Console.WriteLine("qaysi vazifani o'chirmoqchisiz");
                        int m = Convert.ToInt32(Console.ReadLine() ?? "");
                        int deleteIndex = m - 1;
                        Array.Clear(tasks, deleteIndex, 1);
                        PrintTasks(tasks);
                        break;
                    //3.Vazifaning bajarilganligini belgilash
                    case 3:
                        System.Console.WriteLine("qaysi vazifani bajarildiga o'zgartirmoqchisiz");
                        int done = Convert.ToInt32(Console.ReadLine() ?? "");
                        int index = done - 1;
                        string completed = " :bajarildi";
                        tasks[index] = tasks[index].EndsWith(completed)
                                    ? tasks[index]
                                    : $"{tasks[index]} {completed}";
                        PrintTasks(tasks);
                        break;
                    //4.Vazifalar ro'yxatini ko'rish
                    case 4:
                        PrintTasks(tasks);
                        System.Console.WriteLine();
                        break;
                }

            } while (cmd != 5);

            PrintTasks(tasks);

        }
        private static void PrintTasks(string[] tasks)
        {
            System.Console.WriteLine("Vazifalar ro'yxati:");
            for (int i = 0; i < tasks.Length; i++)
            {
                System.Console.WriteLine($" >> {i + 1}. {tasks[i]}");
            }
        }
    }
}
