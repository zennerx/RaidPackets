﻿
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using MessagePack;
using Plarium.Common.Serialization;
using SharedModel.Meta.Inbox;
using SharedModel.Meta.UserPrizes;



namespace SharedModel.Meta.LoyaltyProgram.Dto
{
	[MessagePackObject]
	public class TrackNewLoyaltyProgramDayResponseDto
	{
		// Fields
		[Json]
		// [Key]
		public List<InboxItem> InboxItems_Old;
		[Json]
		// [Key]
		public UserPrize GivenPrize;
	
		// Constructors
		public TrackNewLoyaltyProgramDayResponseDto() {}
		public TrackNewLoyaltyProgramDayResponseDto(UserPrize givenPrize) {}
	}
}
