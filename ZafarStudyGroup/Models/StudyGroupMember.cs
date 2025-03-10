﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ZafarStudyGroup.Models
{
    public class StudyGroupMember
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string StudentNumber { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}