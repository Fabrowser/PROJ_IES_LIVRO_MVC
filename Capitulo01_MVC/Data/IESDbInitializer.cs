﻿using Capitulo01_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Capitulo01_MVC.Data
{
    public class IESDbInitializer
    {	
			public static void Initialize(IESContext context)
			{
				context.Database.EnsureCreated();
				if (context.Departamentos.Any())
				{
					return;
				}
				var departamentos = new Departamento[]
				{
				new Departamento { Nome="Ciência da	Computação"},
				new Departamento {   Nome="Ciência de Alimentos"}
				};
				foreach (Departamento d in departamentos)
				{
					context.Departamentos.Add(d);
				}
				context.SaveChanges();
			}

		}
	}
