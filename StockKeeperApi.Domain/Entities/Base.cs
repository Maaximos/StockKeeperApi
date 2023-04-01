﻿using System.ComponentModel.DataAnnotations;

namespace StockKeeperApi.Domain.Entities
{  
    public class Base
    {
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}
