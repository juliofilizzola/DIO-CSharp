using System;

namespace Instrucoes
{
    class Program
    {
        static void Main(string[] arg)
        {
            static void Declaracoes()
            {
                int a;
                int b = 2, c = 3;
                const int d = 4;
                a = 1;
                Console.WriteLine(a + b + c + d);
            }
            Declaracoes();
            static void InstrucaoIf(string[] args) {
                Console.WriteLine(5);

            }
            InstrucaoIf();
            // static void InstrucaoSwitch(string[] args) { }
            // static void InstrucaoWhile(string[] args) { }
            // static void InstrucaoDo(string[] args) { }
            // static void InstrucaoFor(string[] args) { }

        }
    }
}
