using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MKN4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Stuff stuff = new Stuff();
        public Page1()
        {
            InitializeComponent();
            stuff = new Stuff() {Name="qwe", Count="3"};
        }
    }
}