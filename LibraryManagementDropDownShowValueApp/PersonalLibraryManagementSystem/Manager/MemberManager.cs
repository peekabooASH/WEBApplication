using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.WebSockets;
using PersonalLibraryManagementSystem.DAL.Gateway;

namespace PersonalLibraryManagementSystem.Manager
{
    public class MemberManager
    {
        MemberGateway aMemberGateway= new MemberGateway();
        public bool HasMember(string memberNo)
        {
            return aMemberGateway.HasMember(memberNo);
        }
    }
}