﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula01PullExampleGitHub
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Hello");
                Thread.Sleep(500);
                
            }
            Console.ReadKey();
        }
    }
}
