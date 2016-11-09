using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ConnectivitySample.View
{
    public partial class ConnectivityPage : ContentPage
    {
        public ConnectivityPage()
        {
            InitializeComponent();
        }

        private async void Home_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }

        private void Test_OnClicked(object sender, EventArgs e)
        {

            ConnectedLabel.Text = "Connection Status:";
            bandwidthLabel.Text = "Bandwidth Strength:";
            connectionTypeLabel.Text = "Connection Type:";

            ConnectedLabel.Text = CrossConnectivity.Current.IsConnected ? "Connection Status: Connected" : "Connection Status: No Connection";


            foreach (var band in CrossConnectivity.Current.Bandwidths)
            {
                bandwidthLabel.Text += band.ToString() + ", ";
            }

            foreach (var band in CrossConnectivity.Current.ConnectionTypes)
            {
                connectionTypeLabel.Text += band.ToString() + ", ";
            }

        }
        private void Clear_OnClicked(object sender, EventArgs e)
        {

            ConnectedLabel.Text = "Connection Status:";
            bandwidthLabel.Text = "Bandwidth Strength:";
            connectionTypeLabel.Text = "Connection Type:";

        }

        private void Refresh_OnClicked(object sender, EventArgs e)
        {
           
            ConnectedLabel.Text = "Connection Status:";
            bandwidthLabel.Text = "Bandwidth Strength:";
            connectionTypeLabel.Text = "Connection Type:";

            ConnectedLabel.Text = CrossConnectivity.Current.IsConnected ? "Connection Status: Connected" : "Connection Status: No Connection";

            foreach (var band in CrossConnectivity.Current.Bandwidths)
            {
                bandwidthLabel.Text += band.ToString() + ", ";
            }

            foreach (var band in CrossConnectivity.Current.ConnectionTypes)
            {
                connectionTypeLabel.Text += band.ToString() + ", ";
            }


        }

        //connected.Text = CrossConnectivity.Current.IsConnected ? "Connected" : "No Connection";
        //bandwidths.Text = "Bandwidth Strength: ";
        //foreach (var band in CrossConnectivity.Current.Bandwidths)
        //{
        //    bandwidths.Text += band.ToString() + ", ";
        //}
        //connectionTypes.Text = "ConnectionTypes:  ";
        //foreach (var band in CrossConnectivity.Current.ConnectionTypes)
        //{
        //    connectionTypes.Text += band.ToString() + ", ";
        //}

        //try
        //{
        //    canReach1.Text = await CrossConnectivity.Current.IsReachable(host.Text) ? "Reachable" : "Not reachable";

        //}
        //catch (Exception ex)
        //{

        //}
        //try
        //{
        //    canReach2.Text = await CrossConnectivity.Current.IsRemoteReachable(host2.Text, int.Parse(port.Text)) ? "Reachable" : "Not reachable";

        //}
        //catch (Exception ex)
        //{

        //}


    }
    }
