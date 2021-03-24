using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    /// <summary>
    /// State 抽象状态类，定义个接口以封装与Context的一个特定状态相关的行为。
    /// </summary>
    public abstract class StateDesignPattern
    {
        public abstract void DoAction(StateContent content);
    }
    /// <summary>
    /// Context 维护一个ConcreteState子类的实例，这个实例定义当前的状态
    /// </summary>
    public class StateContent
    {
        private StateDesignPattern stateDesignPattern;

        private int hour;
        public int Hour
        {
            get { return hour; }
            set
            {
                hour = value;
                //时间发生变化了，重新设置下状态具体实现类，
                //因为客户端调用的时候使用了同一个StateContent类
                //上面设置的会影响下面设置的。这里具体问题具体分析
                stateDesignPattern = new BreakFastState();
            }
        }
        public StateContent()
        {
            //默认从吃早餐开始
            stateDesignPattern = new BreakFastState();
        }
        /// <summary>
        /// 设置下一个动作的具体实现
        /// </summary>
        /// <param name="_stateDesignPattern"></param>
        public void SetState(StateDesignPattern _stateDesignPattern)
        {
            stateDesignPattern = _stateDesignPattern;
        }
        /// <summary>
        /// 进行下一个动作
        /// </summary>
        public void NextAction()
        {
            stateDesignPattern.DoAction(this);
        }
    }
    /// <summary>
    /// 吃早餐
    /// Context 维护一个ConcreteState子类的实例，这个实例定义当前的状态
    /// </summary>
    public class BreakFastState : StateDesignPattern
    {
        public override void DoAction(StateContent content)
        {
            //8点吃早餐
            if (content.Hour == 8)
            {
                Console.WriteLine("吃早餐吧");
            }
            else
            {
                content.SetState(new LunchState());
                content.NextAction();
            }
        }
    }
    public class LunchState : StateDesignPattern
    {
        public override void DoAction(StateContent content)
        {
            //12点吃午饭
            if (content.Hour == 12)
            {
                Console.WriteLine("吃午饭吧");
            }
            else
            {
                content.SetState(new DinnerState());
                content.NextAction();
            }
        }
    }
    public class DinnerState : StateDesignPattern
    {
        public override void DoAction(StateContent content)
        {
            //18点吃早餐
            if (content.Hour == 18)
            {
                Console.WriteLine("吃晚饭吧");
            }
            else
            {
                content.SetState(new NoTimeEatState());
                content.NextAction();
            }
        }
    }
    public class NoTimeEatState : StateDesignPattern
    {
        public override void DoAction(StateContent content)
        {
            Console.WriteLine("还没到吃饭时间哦");
        }
    }
}
