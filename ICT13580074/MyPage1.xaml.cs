using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ICT13580074
{
   
    public partial class MyPage1 : ContentPage
    {
        public MyPage1()
        {
            InitializeComponent();
      
            nextButton.Clicked += NextButton_Clicked;
        
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage2());
        }
    }
}