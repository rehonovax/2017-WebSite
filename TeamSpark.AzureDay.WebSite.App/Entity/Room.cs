﻿using TeamSpark.AzureDay.WebSite.Data.Enum;

namespace TeamSpark.AzureDay.WebSite.App.Entity
{
	public class Room
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public RoomType RoomType { get; set; }

		public int ColorNumber { get; set; }
	}
}
