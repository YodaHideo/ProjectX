using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace main
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            label1.Margin = new Thickness(0, 200, 0, 0);
            frame1.Margin = new Thickness(50, 15, 50, 0);
            label2.Margin = new Thickness(0, 40, 0, 0);
            frame2.Margin = new Thickness(50, 15, 50, 0);
            button1.Margin = new Thickness(90, 50, 90, 0);
            label_login.Margin = new Thickness(10, 0, 0, 0);
            ylk_foto.Margin = new Thickness(0, 0, 10, 0);
            up_text.Margin = new Thickness(0, 10, 0, 0);
        }
    }
}