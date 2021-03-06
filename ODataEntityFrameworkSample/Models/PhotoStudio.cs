﻿using Ark.Tools.EntityFrameworkCore.SystemVersioning.Auditing;
using Microsoft.AspNet.OData.Builder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ODataEntityFrameworkSample.Models
{
	public class PhotoStudio: IAuditableEntityFramework
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }

		[Contained]
		public virtual HashSet<Worker> Workers { get; set; }

		public Audit Audit { get; set; }
		public Guid AuditId { get; set; }
	}

	[Owned]
	public class Worker
	{
		public string Name { get; set; }
		public string SurName { get; set; }
		public StudioRole Role { get; set; }

		public string Quality { get; set; }
	}

	public enum StudioRole
	{
		Photografer,
		Editor,
		PressOfficer
	}

	//***********************************************************//

	//public class UniversityDto
	//{
	//	[Key]
	//	public int Id { get; set; }
	//	public string Name { get; set; }

	//	[Contained]
	//	public virtual HashSet<PersonDto> People { get; set; }
	//}

	//[Owned]
	//public class PersonDto
	//{
	//	public string Name { get; set; }
	//	public string SurName { get; set; }
	//	public Role Role { get; set; }

	//	public string Field { get; set; }
	//}
}
