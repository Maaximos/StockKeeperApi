using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockKeeperApi.Domain.Entities
{
    [Table("Categoria")]
    public class Categoria : Base
    {
        [ForeignKey("SistemaEstoque")]
        [Column(Order = 1)]
        public int IdSistema { get; set; }
        public virtual SistemaEstoque SistemaEstoque { get; set; }
    }
}
