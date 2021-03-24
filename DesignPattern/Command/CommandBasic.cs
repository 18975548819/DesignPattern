using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    public abstract class CommandBasic
    {
        protected Receiver receiver;

        protected CommandBasic(Receiver receiver)
        {
            this.receiver = receiver;
        }

        abstract public void Execute();
    }
}
