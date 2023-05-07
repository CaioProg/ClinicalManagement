using ClinicalManagement.Models;
using System.Collections.Generic;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ClinicalManagement.Context
{
	public class Contexto : DbContext
	{
		public Contexto(DbContextOptions<Contexto> options) : base(options)
		{
		}

		public DbSet<Patients> Patients { get; set; }
		public DbSet<Doctors> Doctors { get; set; }
	}
}
