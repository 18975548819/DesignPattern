using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class ConcreteStrategyA : StrategyBasic
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }
}
