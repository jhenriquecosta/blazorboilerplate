﻿using BlazorBoilerplate.Shared.SqlLocalizer;
using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorBoilerplate.Infrastructure.Storage.DataModels
{
    public partial class Message
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "FieldRequired")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "FieldRequired")]
        public string Text { get; set; }
        public DateTime When { get; set; }
        public Guid UserID { get; set; }
        public ApplicationUser Sender { get; set; }
    }
}
