using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesAgenda.Models
{
    public class AGENDA
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string DDD { get; set; }
        public string Celular { get; set; }
        public string Empresa { get; set; }

    }
}