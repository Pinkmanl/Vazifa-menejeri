using System;
namespace vazifaMenejeri
{
    class vazifaMenejeri
    {
        static void Main()
        {
            int cmd = 0;
            string[] vazifalar = ["ertalab turish", "ovqat yeyish"];

            do
            {
                Console.WriteLine("Tanlovni kiriting");
                Console.WriteLine("1.Vazifa qo'shish");
                Console.WriteLine("2. Vazifani o'chirish");
                Console.WriteLine("3. Vazifaning bajarilganligini belgilash");
                Console.WriteLine("4. Vazifalar ro'yxatini ko'rish");
                Console.WriteLine("5. Dasturdan chiqish");
                Console.Write("Tanlovni kiriting: ");
                cmd = Convert.ToInt32(Console.ReadLine() ?? "");
                switch (cmd)
                {

                    //1.Vazifa qo'shish
                    case 1:
                        System.Console.WriteLine("qo'shadigan vazifani kiriting");
                        string qoshimchaVazifa = Console.ReadLine() ?? "";
                        Array.Resize(ref vazifalar, vazifalar.Length + 1);
                        vazifalar[vazifalar.Length - 1] = qoshimchaVazifa;

                        break;
                    //2.Vazifani o'chirish
                    case 2:
                        Console.WriteLine("Natija: " + string.Join(", ", vazifalar));
                        System.Console.WriteLine("qaysi vazifani o'chirmoqchisiz");
                        int m = Convert.ToInt32(Console.ReadLine() ?? "");
                        int turnOff = m - 1;
                        Array.Clear(vazifalar, turnOff, 1);
                        break;
                    //3.Vazifaning bajarilganligini belgilash
                    case 3:
                        System.Console.WriteLine("qaysi vazifani bajarildiga o'zgartirmoqchisiz");
                        int done = Convert.ToInt32(Console.ReadLine() ?? "");
                        int minus = done - 1;
                        string bajarildi = "  bajarildi";
                        int size = vazifalar.Length;
                        for (int i = 0; i <= size; i++)
                        {
                            if (minus == i)
                               vazifalar[i]= vazifalar[i] + bajarildi;
                        }
                        break;
                    //4.Vazifalar ro'yxatini ko'rish
                    case 4:
                        Console.WriteLine("Natija: " + string.Join(", ", vazifalar));
                        System.Console.WriteLine();
                        break;
                }

            } while (cmd != 5);

            Console.WriteLine("Natija: " + string.Join(", ", vazifalar));

        }
    }
}