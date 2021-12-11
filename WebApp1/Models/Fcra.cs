using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class Fcra
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public string ChangesMade { get; set; }
        public string Reflection{ get; set; }
        public string Proposed {get; set;}

    }
}