using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    /// <summary>
    /// 行为请求
    /// </summary>
    public class BehaviourRequest
    {
        /// <summary>
        /// 金额
        /// </summary>
        public double Money { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        public string ActiveName { get; set; }

        public BehaviourRequest(double money, string activename)
        {
            this.Money = money;
            this.ActiveName = activename;
        }
    }
}
