using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniGuardClassLibrary
{
    public class SubjectData
    {
        [Key]
        public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public string SubjectFaculty { get; set; }

        [ForeignKey("SemesterData")]
        public int SemesterId { get; set; }
    }
}
