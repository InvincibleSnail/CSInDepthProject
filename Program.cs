﻿using System.Text;
using CSInDepthProject.ChapterFive;

namespace CSInDepthProject;

class Programw
{
    static void Main(string[] args)
    {
        ClosureTest.MethodInvoker[] delegates = new ClosureTest.MethodInvoker[2];
        int outside = 0;
        for (int i = 0; i < 2; ++i)
        {
            int inside = 0;
            delegates[i] = delegate
            {
                Console.WriteLine("{0},{1}", outside, inside);
                outside++;
                inside++;
            };
        }

        ClosureTest.MethodInvoker first = delegates[0];
        ClosureTest.MethodInvoker second = delegates[1];
        
        first();
        first();
        first();
        
        second();
        second();
    }
}