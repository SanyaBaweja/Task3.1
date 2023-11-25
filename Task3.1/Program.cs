namespace Clock
{
    class Clock1
    {
        static void Main()
        {
            Clock clock1 = new();  //new Instance

            for (int i = 0; i < 86400; i++)  // 86400 are the no of seconds in 24 hrs so the increment will go till no of seconds reach 86400
            {
                clock1.IncrementClock();
                Console.WriteLine(clock1.Output());
            }
            //clock1.ResetClock();
            Console.ReadLine();
        }

    }
}
