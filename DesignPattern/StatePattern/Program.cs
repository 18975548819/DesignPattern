using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// 状态模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            StateContent content = new StateContent();

            content.Hour = 6;
            content.NextAction();

            content.Hour = 8;
            content.NextAction();

            content.Hour = 12;
            content.NextAction();

            content.Hour = 18;
            content.NextAction();
            Console.ReadLine();
        }
    }
}
