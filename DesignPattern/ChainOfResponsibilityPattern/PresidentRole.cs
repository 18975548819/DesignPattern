using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 副总经理角色
    /// </summary>
    public class PresidentRole : RoleAbstract
    {
        public PresidentRole(string name) : base(name) { }

        public override void Behaviour(BehaviourRequest request)
        {
            if (request.Money <= 5000)
            {
                Console.WriteLine("{0}的请求批准得到{1}批准,需要金额：{2}", request.ActiveName, this.name, request.Money);
            }
            else if (NextRole != null)
            {
                Console.WriteLine("{0}无权力批准，给上级{0}处理！", this.name, NextRole.name);
                NextRole.Behaviour(request);
            }
        }
    }
}
