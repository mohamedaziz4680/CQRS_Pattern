using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CQRS_Layer.Data.Models;
using MediatR;

namespace CQRS_Layer.CQRSFolder.Commands
{
    public record InsertItemCommand(Item item) : IRequest<Item>
    {
    }
}
