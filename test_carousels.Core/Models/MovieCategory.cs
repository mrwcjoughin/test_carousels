﻿using System;

namespace test_carousels.Core.Models
{
	public class MovieCategory
	{
		#region Constructors

		public MovieCategory ()
		{
		}

		#endregion Constructors

		#region Properties

		public string Name
		{
			get;
			set;
		}

		public MoviesViewModel Movies
		{
			get;
			set;
		}

		#endregion Properties
	}
}
