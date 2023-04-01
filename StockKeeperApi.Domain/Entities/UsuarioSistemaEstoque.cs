using System.ComponentModel.DataAnnotations.Schema;

namespace StockKeeperApi.Domain.Entities
{
    [Table("UsuarioSistemaEstoque")]
    public class UsuarioSistemaEstoque : Base
    {
        public int Id { get; set; }
        public string EmailUsuario { get; set; }
        public bool Administrador { get; set; }
        public bool SistemaAtual { get; set; }


        [ForeignKey("SistemaEstoque")]
        [Column(Order = 1)]
        public int IdSistema{ get; set; }
        public virtual SistemaEstoque SistemaEstoque { get; set; }
    }
}
