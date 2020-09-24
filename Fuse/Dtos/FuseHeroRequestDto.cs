﻿
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.Fuse.Dtos
{
	[MessagePackObject]
	public class FuseHeroRequestDto
	{
		// Fields
		[Json]
		// [Key]
		public int HeroId;
		[Json]
		// [Key]
		public int[] HeroInventoryIds;
	
		// Constructors
		public FuseHeroRequestDto() {}
	}
}
