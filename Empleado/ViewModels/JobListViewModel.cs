using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;
using Empleado.Models;
using Empleado.Data.SeedData;

namespace Empleado.ViewModels
{
	public class JobListViewModel : BindableBase, INavigationAware
	{
        public List<JobListItemViewModel> Jobs { get; set; }

        readonly INavigationService _navigationService;

		public JobListViewModel(INavigationService navigationService)
		{
            _navigationService = navigationService;
            
			LoadJobs();
        }

        public void LoadJobs()
        {
			var jobData = JobSeedData.Seed();

			Jobs = Jobs ?? new List<JobListItemViewModel>();

			foreach (var job in jobData)
			{
                Jobs.Add(new JobListItemViewModel(job, _navigationService));
			}
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            
        }
    }
}
