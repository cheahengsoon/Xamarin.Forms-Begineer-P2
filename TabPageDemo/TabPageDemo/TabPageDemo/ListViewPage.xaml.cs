using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TabPageDemo
{
    public partial class ListViewPage : ContentPage
    {
        public ListViewPage()
        {
            InitializeComponent();

            //Part 1
            //MainList.ItemsSource = new List<string>
            //{
            //    "Bill","Mark","Steve"
            //};

            //Part 2
            MainList.ItemsSource = new List<Person>
            {
                new Person
                {
                    Name="Bill",
                    Age=26
                },
                new Person
                {
                    Name="Mark",
                    Age=30
                },
                 new Person
                {
                    Name="Steve",
                    Age=35
                },
            };

        }
    }
}
