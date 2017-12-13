using Xamarin.Forms;

namespace ICT13580074
{
    public partial class ICT13580074Page : ContentPage
    {
        public ICT13580074Page()
        {
            InitializeComponent();
            okButton.Clicked += OkButton_Clicked;
            genderPicker.Items.Add("man");
            genderPicker.Items.Add("women");
	       
            myStepper.ValueChanged+= MyStepper_ValueChanged;
            mySlider.ValueChanged+= MySlider_ValueChanged;

		}

        void OkButton_Clicked(object sender, System.EventArgs e)
        {
            firstNameLable.Text = firstNameEntry.Text;


        }



        void MyStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }

        void MySlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            int value = (int)e.NewValue;
            valueLabel.Text = value.ToString();
        }
    }
}
