using System;

namespace Estoq
{
    public class Produto
    {
        public Produto(String ClintID,
                       String lote,
                       String nome, 
                       String unidade,
                       double quantidade,
                       DateTime validade) {
            this.ClintID = ClintID;
            this.lote = lote;
            this.nome = nome;
            this.unidade = unidade;
            this.quantidade = quantidade;
            this.validade = validade;
        }
        public readonly string ClintID;

        public readonly String lote;

        public readonly String nome;

        public readonly String unidade;

        public double quantidade { get; set; }

        public DateTime validade { get; set; }
    }
}
