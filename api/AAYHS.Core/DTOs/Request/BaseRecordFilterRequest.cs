﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Core.DTOs.Request
{
    public class BaseRecordFilterRequest
    {
        /// <summary>
        /// To search the record
        /// </summary>
        public string SearchTerm { get; set; }
        /// <summary>
        /// Send According to the number of page required
        /// </summary>
        public int Page { get; set; } = 1;
        /// <summary>
        /// Number of record required on a page
        /// </summary>
        public int Limit { get; set; } = 10;
        /// <summary>
        /// Need to send like UserId,CreatedOn etc
        /// </summary>
        public string OrderBy { get; set; } = "CreatedOn";
        /// <summary>
        /// Need to send true if record required  in descending order
        /// </summary>
        public bool OrderByDescending { get; set; } = true;
        /// <summary>
        /// Need to send false when page and limit are sending and for all records send true
        /// </summary>
        public bool AllRecords { get; set; } = false;
    }
}
