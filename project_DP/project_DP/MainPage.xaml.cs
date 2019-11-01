using project_DP.Models;
using project_DP.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace project_DP
{
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            TestModels();
        }

        private async Task TestModels()
        {
            Dictionary<string, BitcoinLiveData> dict = new Dictionary<string, BitcoinLiveData>();
            dict = await BitcoinRepository.GetJsonData();
            Debug.WriteLine(dict);
            //foreach(BitcoinLiveData item in dict)
            //{
            //    Debug.WriteLine()
            //}
        }
    }
}
