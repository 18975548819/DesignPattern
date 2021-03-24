using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// C#设计模式-责任链模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //活动信息
            BehaviourRequest behavior = new BehaviourRequest(10000, "部门招商活动");

            //对该活动的审批可能涉及的角色
            RoleAbstract manager = new ManagerRole("部门经理");
            RoleAbstract vp = new PresidentRole("副总经理");
            RoleAbstract pre = new PresidengtRole("总经理");

            //设置责任链
            manager.NextRole = vp;
            vp.NextRole = pre;

            //请求处理
            manager.Behaviour(behavior);
            Console.ReadLine();
        }
    }
}
