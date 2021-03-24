using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 角色抽象类
    /// </summary>
    public abstract class RoleAbstract
    {
        public RoleAbstract NextRole { get; set; }
        public string name { get; set; }
        public RoleAbstract(string name)
        { this.name = name; }

        /// <summary>
        /// 该角色的执行行为
        /// </summary>
        public abstract void Behaviour(BehaviourRequest request);
    }
}
