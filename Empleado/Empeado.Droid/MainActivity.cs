using Android.App;
using Android.Widget;
using Android.OS;
using Empleado;
using Microsoft.Practices.Unity;
using Prism.Unity;
using Android.Content.PM;

namespace Empeado.Droid
{
	[Activity(Theme = "@android:style/Theme.Holo.Light", Label = "Emplea.do", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);

			LoadApplication(new App(new AndroidInitializer()));


			Microsoft.WindowsAzure.MobileServices.CurrentPlatform.Init();
		}
	}

	public class AndroidInitializer : IPlatformInitializer
	{
		public void RegisterTypes(IUnityContainer container)
		{

		}
	}
}

