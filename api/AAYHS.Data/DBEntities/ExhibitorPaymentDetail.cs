﻿using AAYHS.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AAYHS.Data.DBEntities
{
    public class ExhibitorPaymentDetail:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ExhibitorPaymentId { get; set; }
        public int FeeTypeId { get; set; }
        public int ExhibitorId { get; set; }
        public decimal Amount { get; set; }
        public string TimeFrameType{ get; set; }
        [Column(TypeName = "varchar(50)")]
        public string CheckNumber { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string Description { get; set; }
        public DateTime PayDate { get; set; }
        [Column(TypeName = "varchar(5000)")]
        public string DocumentPath { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RefundAmount { get; set; }
    }
}
