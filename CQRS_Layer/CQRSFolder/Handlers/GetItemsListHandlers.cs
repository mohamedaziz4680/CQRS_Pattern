using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS_Layer.Data.Models;
using CQRS_Layer.CQRSFolder.Queries;
using CQRS_Layer.Data;
using MediatR;

namespace CQRS_Layer.CQRSFolder.Handlers
{
    public class GetItemsListHandlers : IRequestHandler<GetAllItemsQuery,List<Item>>
    {
        private readonly AppDbContext _appDbContext;

        public GetItemsListHandlers(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<List<Item>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(_appDbContext.Items.ToList());
        }
    }
}
