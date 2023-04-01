using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations.Schema;

namespace StockKeeperApi.Domain.Entities
{
    [Table("USUARIOESTOQUE")]
    public class ApplicationUser : IdentityUser
    {
        [Column("USRCPF")]
        public string CPF { get; set; }

    }
}
