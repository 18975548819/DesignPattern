using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    /// <summary>
    /// 命令模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Receiver r = new Receiver();
            CommandBasic c = new ConcreteCommand(r);
            Invoker i = new Invoker();
            i.SetCommand(c);
            i.ExecuteCommand();
            Console.ReadLine();
        }
    }
}
