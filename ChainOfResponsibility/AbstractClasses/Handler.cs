using ChainOfResponsibility.ConcreteClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.AbstractClasses
{
    public abstract class Handler
    {
        protected Handler NextHandler;

        public void SetNextHandler(Handler nextHandler)
        {
            this.NextHandler = nextHandler;
        }

        public abstract void HandleRequest(MemberJoinRequest request);
    }
}
