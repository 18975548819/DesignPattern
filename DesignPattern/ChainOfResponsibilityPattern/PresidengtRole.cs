using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 总经理
    /// </summary>
    public class PresidengtRole : RoleAbstract
    {
        public PresidengtRole(string name) : base(name) { }

        public override void Behaviour(BehaviourRequest request)
        {
            if (request.Money <= 10000)
            {
                Console.WriteLine("{0}的请求批准得到{1}批准,需要金额：{2}", request.ActiveName, this.name, request.Money);
            }
            else
            {
                Console.WriteLine("这个活动需要进行会议讨论决定");
            }
        }
    }
}
