﻿using System;

namespace sample1
{
    class Program
    {
        static void Main()
        {
            var s = new Pilha();
            s.Empilhar(1);
            s.Empilhar(10);
            s.Empilhar(100);
            Console.WriteLine(s.Desempilhar());
        }
    }
}
