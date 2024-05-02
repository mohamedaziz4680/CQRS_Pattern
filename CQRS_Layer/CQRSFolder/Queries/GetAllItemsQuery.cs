using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS_Layer.Data.Models;
using MediatR;

namespace CQRS_Layer.CQRSFolder.Queries
{
    public record GetAllItemsQuery : IRequest<List<Item>>;

}
