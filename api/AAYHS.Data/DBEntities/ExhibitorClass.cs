﻿using AAYHS.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AAYHS.Data.DBEntities
{
    public class ExhibitorClass:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ExhibitorClassId { get; set; }
        public int ExhibitorId { get; set; }
        public int ClassId { get; set; }
        public int HorseId { get; set; }
        public bool IsScratch { get; set; }
        public DateTime? ScratchDate { get; set; }
        public DateTime Date { get; set; }
    }
}
