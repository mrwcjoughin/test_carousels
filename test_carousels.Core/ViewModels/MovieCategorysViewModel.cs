﻿using System;
using System.Collections.ObjectModel;
using MvvmCross.Core.ViewModels;
using test_carousels.Core.Models;

namespace test_carousels.Core.ViewModels
{
	public class MovieCategorysViewModel : MvxViewModel
	{
		#region Fields

		private ObservableCollection<MovieCategory> _movieCategorys = new ObservableCollection<MovieCategory>();

		#endregion Fields

		#region Constructors

		public MovieCategorysViewModel()
		{
			_movieCategorys.Add(new MovieCategory() { Name = "Channels" });
			_movieCategorys.Add(new MovieCategory() { Name = "Continue Watching" });
			_movieCategorys.Add(new MovieCategory() { Name = "Highlights" });
		}

		#endregion Constructors

		#region Properties

		public ObservableCollection<MovieCategory> MovieCategorys
		{
			get
			{
				return _movieCategorys;
			}
			set
			{
				SetProperty(ref _movieCategorys, value);
			}
		}

		#endregion Properties
	}
}