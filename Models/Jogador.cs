﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Brasileirao_App.Models
{
    public class Jogador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O campo Nome deve ter no máximo 100 caracteres.")]
        public string Nome { get; set; }

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataNascimento { get; set; }

        [Range(1, 99, ErrorMessage = "O número da camisa deve estar entre 1 e 99.")]
        public int Nr_Camisa { get; set; }

        [ForeignKey("Time")]
        public int IdTime { get; set; }

        [Required]
        [ForeignKey("Posicao")]
        public int IdPosicao { get; set; }

        public virtual Time TimeNavigation { get; set; }

        public virtual Posicao PosicaoNavigation { get; set; }

        public bool Lesionado { get; set; }

        public bool Suspenso { get; set; }
    }
}
