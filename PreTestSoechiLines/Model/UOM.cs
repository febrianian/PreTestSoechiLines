using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreTestSoechiLines.Model
{
    public class UOM
    {
        [Key]
        public int IdUOM { get; set; }
        public string Satuan { get; set; }
        public int Rate { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }

    }
}
