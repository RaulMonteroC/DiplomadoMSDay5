﻿using Prism.Unity;
using Empleado.Views;
using Empleado.Services;
using Microsoft.Practices.Unity;

namespace Empleado
{
	public partial class App : PrismApplication
	{
		public App(IPlatformInitializer initializer = null) : base(initializer) { }

		protected override void OnInitialized()
		{
			InitializeComponent();

            NavigationService.NavigateAsync($"{nameof(NavContainer)}/{nameof(JobList)}");
		}

		protected override void RegisterTypes()
		{
            Container.RegisterTypeForNavigation<JobList>();
            Container.RegisterTypeForNavigation<JobDetail>();
            Container.RegisterTypeForNavigation<NavContainer>();

            Container.RegisterType<AzureDataService, AzureDataService>();
		}
	}
}

