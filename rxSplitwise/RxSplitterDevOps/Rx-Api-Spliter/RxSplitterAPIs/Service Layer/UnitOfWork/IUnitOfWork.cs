﻿using Repository_Layer.IRepository;
using Service_Layer.ICustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserDetailService User { get; }
        IGroupService Group { get; }
        IGroupMemberService GroupMember { get; }
        IExpenseService Expense { get; }
         IMemberInvitationService MemberInvitation { get; }
        ITransactionService Transaction { get; }
        IReportService Report { get; }
        void Save();
        
    }
}
