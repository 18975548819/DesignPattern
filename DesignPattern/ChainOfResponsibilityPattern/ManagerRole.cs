using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 部门经理
    /// </summary>
    public class ManagerRole : RoleAbstract
    {
        public ManagerRole(string name) : base(name) { }

        public override void Behaviour(BehaviourRequest request)
        {
            if (request.Money <= 1000)
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
