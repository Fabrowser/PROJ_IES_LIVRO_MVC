﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Capitulo01_MVC.Models.Infra
{
    public class RegistrarNovoUsuarioViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "A	{0}	precisa	ter	ao	menos	{2} e no  máximo	{1} caracteres de	cumprimento.",	MinimumLength	=	6)]
        [DataType(DataType.Password)]
        [Display(Name = "Senha")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar	senha")]
        [Compare("Password", ErrorMessage = "Os	valores	informados   para    SENHA   e   CONFIRMAÇÃO não são iguais.")]
        public string ConfirmPassword { get; set; }



    }
}
