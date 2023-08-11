using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCF1.Model
{
    internal class Emp
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Empno { get; set; }
        public string? Ename { get; set; }
        public string? Addr { get; set; }

        [Required] [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Deptno { get; set; } 
        public Dept? Deptnonav { get; set; }    

    }
}
