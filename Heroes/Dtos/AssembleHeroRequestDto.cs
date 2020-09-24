﻿
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Heroes.Dtos
{
	[MessagePackObject]
	public class AssembleHeroRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroTypeId;
	
		// Constructors
		public AssembleHeroRequestDto() {}
	}
}
