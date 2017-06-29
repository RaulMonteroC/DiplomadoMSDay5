using System;
using Empleado.Models;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace Empleado.ViewModels
{
    public class JobDetailViewModel : BindableBase, INavigationAware
    {
        Job _job;
        public Job Job
        {
            get { return _job; }
            set {SetProperty(ref _job, value);}
        }

        public string RemoteText { get; set; }

        public JobDetailViewModel()
        {
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            Job = (Job) parameters["Job"];
            RemoteText = Job.IsRemote ? "Remote" : "";
		}
    }
}

