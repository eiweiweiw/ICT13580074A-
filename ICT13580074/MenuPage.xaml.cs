using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580074
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
		public MenuPage()
		{
			InitializeComponent();
			viewButton.Clicked += ViewButton_Clicked;
			stackButton.Clicked += StackButton_Clicked;
			gridButton.Clicked += GridButton_Clicked;
            absoluteButton.Clicked += ApsoluteButton_Clicked;
			contentButton.Clicked += ContentButton_Clicked;
			navigationButton.Clicked += NavigationButton_Clicked;
			tapButton.Clicked += TabButton_Clicked;
			carouselButton.Clicked += CarouselButton_Clicked;
		}

		void ViewButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;
			var np = new NavigationPage(new ICT13580074Page());
			mp.Detail = np;
			mp.IsPresented = false;
		}

		void StackButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;
			var np = new NavigationPage(new StackPage());
			mp.Detail = np;
			mp.IsPresented = false;
		}

		void GridButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;
			var np = new NavigationPage(new GridPage());
			mp.Detail = np;
			mp.IsPresented = false;
		}

		void ApsoluteButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;
			var np = new NavigationPage(new AbsolutePage());
			mp.Detail = np;
			mp.IsPresented = false;
		}

		void ContentButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;
			var np = new NavigationPage(new MyPage1());
			mp.Detail = np;
			mp.IsPresented = false;
		}

		void NavigationButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;
			var np = new NavigationPage(new NavPage1());
			mp.Detail = np;
			mp.IsPresented = false;
		}

		void TabButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;
			var tp = new TabbedPage();
			tp.Children.Add(new TapPage1());
            tp.Children.Add(new TapPage2());
			tp.Children.Add(new TapPage3());
			var np = new NavigationPage(tp);
			mp.Detail = np;
			mp.IsPresented = false;
		}

		void CarouselButton_Clicked(object sender, EventArgs e)
		{
			var mp = Parent as MasterDetailPage;
			var cp = new CarouselPage();
			cp.Children.Add(new TapPage1());
			cp.Children.Add(new TapPage2());
			cp.Children.Add(new TapPage3());
			var np = new NavigationPage(cp);
			mp.Detail = np;
			mp.IsPresented = false;
		}
	}
}   