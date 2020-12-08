using ChainOfResponsibility.AbstractClasses;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.ConcreteClasses
{
    public class StudentMemberHandler : Handler
    {
        public override void HandleRequest(MemberJoinRequest request)
        {
            if (string.Compare(request.MemberType, "Student", true) == 0)
            {
                Console.WriteLine("{0} handled {1} member join request for {2}",
                  this.GetType().Name, request.MemberType, request.Name);
            }
            else if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
        }
    }
}
