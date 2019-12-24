﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Models
{
    public class RefreshToken
    {
        public string access_token { get; set; }

        public int expires_in { get; set; }

        public string scope { get; set; }

        public string token_type { get; set; }

        public string id_token { get; set; }

    }
}
