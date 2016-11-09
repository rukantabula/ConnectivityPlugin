using Plugin.Messaging;
using Plugin.Share;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConnectivitySample.View
{
    public partial class MenuPage : MasterDetailPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void Conectivity_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConnectivityPage());
        }

        private async void siteButton_OnClicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new MapsAarhus());
            bool n2 = await DisplayAlert("Notification",
                "You are about to open the browser!",
                "Proceed",
                "Stop");

            if (n2 == true)
            {

                Device.OpenUri(new Uri("http://grundfos.com"));

            }

        }

        private async void Share_OnClicked(object sender, EventArgs e)
        {
            bool n1 = await DisplayAlert("Notification",
                "This service will connect you to another app installed in this phone!",
                "Proceed",
                "Stop");

            if (n1 == true)
            {

                await CrossShare.Current.Share("Hey workmate!! Check out this cool app!     http://goo.gl/hbhsm4e", "Title");

            }

        }

       

        private async void Call_OnClicked(object sender, EventArgs e)
        {

            bool n1 = await DisplayAlert("Notification",
                "This service will connect your dialer",
                "Proceed",
                "Stop");

            if (n1 == true)
            {
                string admin = await DisplayActionSheet("Choose Area",
                "Stop",
                "Proceed",
                "Help Desk",
                "Bettina",
                "Benson"
               );

                if (admin == "Help Desk")
                {

                    var phoneDialer = CrossMessaging.Current.PhoneDialer;
                    if (phoneDialer.CanMakePhoneCall)
                    {
                        phoneDialer.MakePhoneCall("3333", "Benson Rukantabula");


                    }
                    else if (admin == "Bettina")
                    {

                        var phoneDialer1 = CrossMessaging.Current.PhoneDialer;
                        if (phoneDialer1.CanMakePhoneCall)
                        {
                            phoneDialer1.MakePhoneCall("+4538613509", "Benson Rukantabula");


                        }
                        else if (admin == "Benson")
                        {

                            var phoneDialer2 = CrossMessaging.Current.PhoneDialer;
                            if (phoneDialer2.CanMakePhoneCall)
                            {
                                phoneDialer2.MakePhoneCall("+456171456", "Benson Rukantabula");


                            }

                        }

                    }


                }
            }
        }
    }
}