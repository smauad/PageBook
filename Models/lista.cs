using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesLista.Models
{
    public class LISTA
    {
        public int ID { get; set; }
        public string Item { get; set; }

        [DataType(DataType.Date)]
        public DateTime DeadLine { get; set; }
        public string Info { get; set; }

    }
}