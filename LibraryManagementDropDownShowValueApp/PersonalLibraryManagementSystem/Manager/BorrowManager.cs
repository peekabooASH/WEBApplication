using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PersonalLibraryManagementSystem.DAL.Gateway;
using PersonalLibraryManagementSystem.Models;

namespace PersonalLibraryManagementSystem.Manager
{
    public class BorrowManager
    {
        MemberManager aMemberManager= new MemberManager();
        BorrowGateway aBorrowGateway= new BorrowGateway();
        public int Save(Borrow aBorrow)
        {
            if (!HasMember(aBorrow.MemberNo))
            {
                throw new Exception("Member doesn't exsit");
            }
            else
            {
                return aBorrowGateway.Save(aBorrow);
            }
        }

        private bool HasMember(string memberNo)
        {
            return aMemberManager.HasMember(memberNo);
        }
    }
}