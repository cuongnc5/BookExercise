﻿using System;

namespace BookStoreBusiness
{
    public class UserViewModel
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public Nullable<bool> DelFlag { get; set; }
    }
}
