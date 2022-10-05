using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoEscola_API.Models
{
    public class Aluno
    {
        public int id {get;set;}


        [StringLength(5)]
        [Required(ErrorMessage = "campo obrigatório")]
        //[RegularExpression(@"^[0-9]{5}$",ErrorMessage = "o campo deve conter 5 números")]
        public string? ra {get;set;}


        [StringLength(30, MinimumLength = 3)]
        [Required(ErrorMessage = "campo obrigatório")]
        //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",ErrorMessage = "o nome não pode conter caracteres especiais")]
        public string? nome {get;set;}

        //[MaxLength(2)]
        [Required(ErrorMessage = "campo obrigatório")]
        public int codCurso {get;set;}
    }
}