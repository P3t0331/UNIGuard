using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UniGuardClassLibrary
{
    public class SemesterData
    {
        [Key]
        public int SemesterId { get; set; }
        public string SemesterType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}
