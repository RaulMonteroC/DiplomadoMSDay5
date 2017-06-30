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


		}

		protected override void RegisterTypes()
		{

		}
	}
}

