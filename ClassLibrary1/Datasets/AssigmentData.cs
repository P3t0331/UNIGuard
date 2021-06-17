using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniGuardClassLibrary
{
    public class AssigmentData
    {
        [Key]
        public int AssigmentId { get; set; }
        public string AssigmentName { get; set; }
        public string AssigmentState { get; set; }
        public DateTime AssigmentEndDate { get; set; }
        public int SubjectId { get; set; }
    }
}
