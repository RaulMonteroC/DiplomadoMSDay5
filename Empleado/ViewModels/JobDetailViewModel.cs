using System;
using Empleado.Models;
using Prism.Mvvm;
using Prism.Navigation;
using Xamarin.Forms;

namespace Empleado.ViewModels
{
    public class JobDetailViewModel : BindableBase, INavigationAware
    {
        public Job Job { get; set; }
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

