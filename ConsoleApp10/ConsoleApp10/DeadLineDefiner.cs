using System;
namespace ConsoleApp10
{
    class DeadLineDefiner
    {
        private static double defaultTime=2;
        private static bool isFirstTime = true;

        public static double DefineDeadline(TaskGeneretor selected)
        {
            if (selected.Degree == 5 && isFirstTime)
            {
                defaultTime = 1.5;
            }
            isFirstTime = false;

            return selected.Degree * defaultTime;

        }
        public static void StartTime(double deadline)
        {
            var Deadline = DateTime.Now.AddSeconds(deadline);
            Console.WriteLine(Deadline.Hour+ " : "+Deadline.Minute+" : " +Deadline.Second+ " sonra deadline bitir.");
            while (DateTime.Now<Deadline)
            {
                string done =Console.ReadLine();
                if (done=="done")
                {
                    break;
                }
            }
            if (DateTime.Now<Deadline)
            {
                Console.WriteLine("Tebrik");
            }
            else
            {
                Console.WriteLine("alinmadi alinmadi xixi");
            }
        }
    }
}