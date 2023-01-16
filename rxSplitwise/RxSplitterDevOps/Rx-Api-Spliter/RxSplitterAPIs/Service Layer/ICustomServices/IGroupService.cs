﻿using DomainLayer.Data;
using DomainLayer.DTO;
using Repository_Layer.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.ICustomServices
{
    public interface IGroupService : IRepository<Group>
    {
        Task<List<Group>> GetGroupDataWithMembersByGroupId(int GroupId);
        Task<IEnumerable<SP_GetAllGroupsOfUser>> GetAllDetailGroupsOfUser(Guid UserId);

        Task<IEnumerable<sp_GetAllGroups>> GetAllDetailGroups(Guid UserId);
        Task<List<Category>> GetAllCategories();
        Task<List<Currency>> GetAllCurrency();
    }
}
