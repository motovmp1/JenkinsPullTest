using System;
using System.Threading;

namespace JenkinsGitDll
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
                Thread.Sleep(400);
                Thread.Sleep(100);

            }

        }
    }
}
