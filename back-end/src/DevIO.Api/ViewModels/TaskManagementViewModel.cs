﻿using System.ComponentModel.DataAnnotations;

namespace DevIO.Api.ViewModels
{
    public class TaskManagementViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string UserId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime StartTime { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public DateTime EndTime { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Subject { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Description { get; set; }

    }
}