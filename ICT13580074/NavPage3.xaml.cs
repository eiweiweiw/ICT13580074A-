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
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()
        {
            InitializeComponent();
			backButton.Clicked += BackButton_Clicked;
			backtToRootButton.Clicked += BackToRootButton_Clicked;
		}

		void BackButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopAsync();
		}

		void BackToRootButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PopToRootAsync();
		}
	}
}