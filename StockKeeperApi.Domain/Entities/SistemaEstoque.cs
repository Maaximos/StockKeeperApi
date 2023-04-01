namespace StockKeeperApi.Domain.Entities
{
    public class SistemaEstoque : Base
    {
        public DateTime Validade { get; set; }
        public decimal ValorCompra { get; set; }
        public decimal ValorVenda { get; set; }
        public decimal Custo { get; set; }
        public int QuantidadeMinima { get; set; }
        public int QuantidadeMaxima { get; set; }
        public int QuantidadeMedia { get; set; }
        public DateTime TempoReposicao { get; set; }
        public string DescricaoObservacao{ get; set; }
    }
}
