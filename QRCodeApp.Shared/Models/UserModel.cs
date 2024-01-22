﻿using System;
using System.ComponentModel.DataAnnotations;

namespace QRCodeApp.Shared.Models
{
    public class UserModel
    {
        [Key]
        public int Id { get; set; } // base class ta da var tekrar eklenmiyor
        public string UserName { get; set; } = string.Empty;
        public string UserSurname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
    }

}

