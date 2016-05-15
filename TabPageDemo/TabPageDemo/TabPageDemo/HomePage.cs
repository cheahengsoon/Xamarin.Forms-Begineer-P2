using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace TabPageDemo
{
    public class HomePage : TabbedPage
    {
        public HomePage()
        {
            Children.Add(new Page
            {
                Title = "Tab 1",
            });

            Children.Add(new Page1());
            Children.Add(new Page2());

            this.SelectedItem = Children[2];
        }
    }
}
