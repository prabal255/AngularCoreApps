using AutoMapper;
using DomainLayer.Data;
using DomainLayer.DTO;
using Repository_Layer.IRepository;
using Repository_Layer.Repository;
using Service_Layer.ICustomServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_Layer.CustomServices
{
    public class ReportService : Repository<Report>, IReportService
    {
        private readonly RxSplitterContext _context;
        private readonly ISprocRepository _sprocRepo;
        private readonly IMapper _mapper;

        public ReportService(RxSplitterContext context, IMapper mapper, ISprocRepository sprocRepo) : base(context)
        {

            _context = context;
            _sprocRepo = sprocRepo;
            _mapper = mapper;
        }
        public async Task<IEnumerable<SP_GetAllExpensesChart>> GetAllExpensesChart(Guid UserId)
        {
            var obj = _sprocRepo.GetStoredProcedure("sp_allExpensesChart")
               .WithSqlParams(("UserId", UserId.ToString()))
               .ExecuteStoredProcedureAsync<SP_GetAllExpensesChart>();
            return obj.Result;
        }
        public async Task<IEnumerable<SP_GetAllExpensesChart>> GetGroupExpensesChart(Guid UserId,int GroupId)
        {
            var obj = _sprocRepo.GetStoredProcedure("sp_allExpensesChart")
               .WithSqlParams(("UserId", UserId.ToString()),("groupId", GroupId))
               .ExecuteStoredProcedureAsync<SP_GetAllExpensesChart>();
            return obj.Result;
        }

    }
}
