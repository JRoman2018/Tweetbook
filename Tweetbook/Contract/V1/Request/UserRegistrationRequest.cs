﻿using System.ComponentModel.DataAnnotations;

namespace Tweetbook.Contract.V1.Request
{
    public class UserRegistrationRequest
    {
        [EmailAddress]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
