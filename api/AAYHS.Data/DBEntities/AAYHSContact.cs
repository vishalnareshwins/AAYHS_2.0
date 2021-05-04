﻿using AAYHS.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AAYHS.Data.DBEntities
{
    public class AAYHSContact:BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AAYHSContactId { get; set; }
        public int YearlyMaintainenceId { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Location { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Address { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string City { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string State { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string ZipCode { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email1 { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string Email2 { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Phone1 { get; set; }
        [Column(TypeName = "varchar(15)")]
        public string Phone2 { get; set; }
        public int ExhibitorSponsorConfirmationAddressId { get; set; }
        public int ExhibitorSponsorRefundStatementAddressId { get; set; }
        public int ExhibitorConfirmationEntriesAddressId { get; set; }
    }
}
