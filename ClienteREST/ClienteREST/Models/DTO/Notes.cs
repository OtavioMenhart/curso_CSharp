﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ClienteREST.Models.DTO
{
    public class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}