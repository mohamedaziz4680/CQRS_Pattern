using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS_Layer.Data;
using CQRS_Layer.Data.Models;
using CQRS_Layer.CQRSFolder.Commands;
using MediatR;

namespace CQRS_Layer.CQRSFolder.Handlers
{
    public class InsertItemHandler : IRequestHandler<InsertItemCommand,Item>
    {
        private readonly AppDbContext _appDbContext;

        public InsertItemHandler(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<Item> Handle(InsertItemCommand request, CancellationToken cancellationToken)
        {
            await _appDbContext.Items.AddAsync(request.item);
            await _appDbContext.SaveChangesAsync();
            return await Task.FromResult(request.item);
        }
    }
}
