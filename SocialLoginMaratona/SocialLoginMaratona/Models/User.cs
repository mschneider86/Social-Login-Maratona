﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialLoginMaratona.Models
{
    public class User
    {           
        [JsonProperty("userid")]
        public string UserId { get; set; }
    }
}
