﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SCD_Frontend.models
{
    public class LoginRequest
    {
        public string username { get; set; }
        public string password { get; set; }

        public LoginRequest(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        public override string ToString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
