﻿using System;

namespace ConsoleApp1
{
    public class Class1
    {
        public string LocalPrint(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine("Master change");
            return str;
        }
    }
}
