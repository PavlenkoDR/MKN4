using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MKN4
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Stuff> stuffs = new ObservableCollection<Stuff>();

        public SortedDictionary<string, Stuff> stuffs_dict = new SortedDictionary<string, Stuff>(); 
        public MainPage()
        {
            InitializeComponent();
            MyList.ItemsSource = stuffs;
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var page = new Page1();
            page.Disappearing += (a, b) => {
                Console.WriteLine("qwqw");

                stuffs_dict[page.stuff.Name] =  page.stuff;
                stuffs.Clear();
                var temp = stuffs_dict.Select(x => { return x.Value; }).ToList();
                foreach(var item in temp)
                {
                    stuffs.Add(item);
                }
            };
            Navigation.PushAsync(page);
        }
    }

    public class Stuff
    {
        public string Name { get; set; }
        public string Count { get; set; }

    }
}
