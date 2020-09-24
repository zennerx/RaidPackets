﻿
using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;



namespace SharedModel.Meta.AutoOpen.Conditions
{
	[MessagePackObject]
	public class DaysSinceLastSessionCondition
	{
		// Fields
		[Json]
		// [Key]
		public int Min;
	
		// Constructors
		public DaysSinceLastSessionCondition() {}
	}
}
