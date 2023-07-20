using Public_Solution_test;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace OpenSilverApplication2
{
    public partial class MainPage : Page
    {
        public string Text { get; set; }
        public MainPage()
        {
            var cls = new Class1();
            Text = cls.Greeting;
            DataContext = this;
            this.InitializeComponent();

            // Enter construction logic here...
        }
    }
}
