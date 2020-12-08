using ChainOfResponsibility.AbstractClasses;
using ChainOfResponsibility.ConcreteClasses;
using System;
using System.Collections.Generic;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler h1 = new ProfessionalMemberHandlers();
            Handler h2 = new StudentMemberHandler();
            Handler h3 = new LifeMemberHandler();

            h1.SetNextHandler(h2);
            h2.SetNextHandler(h3);

            IList<MemberJoinRequest> memberJoinRequests = new List<MemberJoinRequest>()
            {
                new MemberJoinRequest { Name = "John", MemberType = "Professional"},
                new MemberJoinRequest { Name = "Amanda", MemberType = "Life"},
                new MemberJoinRequest { Name = "Chris", MemberType = "Student"},
                new MemberJoinRequest { Name = "Bob", MemberType = "Life"},
                new MemberJoinRequest { Name = "Nancy", MemberType = "Professional"},
                new MemberJoinRequest { Name = "Tina", MemberType = "Student"},
                new MemberJoinRequest { Name = "Larry", MemberType = "Professional"},
                new MemberJoinRequest { Name = "Nick", MemberType = "Professional"},
            };

            foreach (var request in memberJoinRequests)
            {
                h1.HandleRequest(request);
            }

            Console.ReadKey();
        }
    }
}
