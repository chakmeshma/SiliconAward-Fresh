﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SiliconAward.ViewModels
{
    public class LoginResultViewModel
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public string Message { get; set; }
        public string Avatar { get; set; }
    }
}
