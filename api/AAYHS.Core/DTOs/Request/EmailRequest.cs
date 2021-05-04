﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Core.DTOs.Request
{
    public class EmailRequest
    {
        public string To { get; set; }
        public string Url { get; set; }        
        public string TemplateType { get; set; }        
        public string SenderEmail { get; set; }
        public string CompanyEmail { get; set; }
        public string CompanyPassword { get; set; }        
        public string Token { get; set; }        
    }
}
