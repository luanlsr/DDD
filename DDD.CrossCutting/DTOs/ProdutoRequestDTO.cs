using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.CrossCutting.DTOs
{
    public class ProdutoRequestDTO
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
