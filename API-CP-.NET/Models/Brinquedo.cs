using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API.NET.Models
{
    public class Brinquedo
    {
        [Key]
        [Column("ID_BRINQUEDO")]
        public int id_brinquedo { get; set; }

        [Column("NOME_BRINQUEDO")]
        public string nome_brinquedo { get; set; }

        [Column("TIPO_BRINQUEDO")]
        public string tipo_brinquedo { get; set; }

        [Column("CLASSIFICACAO")]
        public string classificacao { get; set; }

        [Column("TAMANHO")]
        public string tamanho { get; set; }

        [Column("PRECO")]
        public string preco { get; set; }
    }
}
