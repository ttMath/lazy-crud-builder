using LazyCrud.Core.Application.DTO.Attributes;
using LazyCrud.Core.Domain.Aggregates.CommonAgg.Entities;
using LazyCrud.Core.Domain.Attributes.T4;

namespace LazyCrud.MarketPlace.Domain.Aggregates.UsersAgg.Entities
{
    [EndpointsT4(EndpointTypes.HttpAll), AutoGenerateDefaultFiles]
    public partial class Carrinho : Entity
    {
    
        public int ProdutoId { get; set; }
    
        public int UsuarioId { get; set; }
    
        public int Pagamento { get; set; }
    }
}