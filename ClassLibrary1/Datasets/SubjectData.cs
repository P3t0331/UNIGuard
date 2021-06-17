﻿using System;
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
        public string SemesterName { get; set; }
        public int SemesterId { get; set; }
    }
}