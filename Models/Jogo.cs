using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DadosComCSV.Models
{
    public class Jogo
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Desenvolvedora { get; set; }
        public string? Genero { get; set; }
        public int AnoLancamento { get; set; }
        public decimal Preco { get; set; }
    }
}