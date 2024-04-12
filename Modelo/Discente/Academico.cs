using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Modelo.Discente
{
	public class Academico
	{
		[DisplayName("Id")]
		public long? AcademicoID { get; set; }


		[StringLength(10, MinimumLength = 10)]
		[RegularExpression("([0-9]{10})")]
		[Required]
		[DisplayName("RA")]
		public string RegistroAcademico { get; set; }


		[Required]
		public string Nome { get; set; }


		[DataType(DataType.Date)]
		[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")]
		[Required]
		public DateTime? Nascimento { get; set; }

		public string FotoMimeType { get; set; }
		public byte[] Foto { get; set; }

		[NotMapped]
		public IFormFile formFIle { get; set; }


	}
}
