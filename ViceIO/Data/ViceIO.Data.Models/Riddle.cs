﻿using System.ComponentModel.DataAnnotations;

using ViceIO.Data.Common.Models;

namespace ViceIO.Data.Models
{
    public class Riddle : BaseDeletableModel<int>
    {
        [Required]
        [MaxLength(2000)]
        public string Content { get; set; }

        public int CategoryId { get; set; }

        public virtual RiddleCategory Category { get; set; }

        public string AddedByUserId { get; set; }

        public virtual ApplicationUser AddedByUser { get; set; }
    }
}
