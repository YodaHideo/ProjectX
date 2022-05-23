using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace main
{
    public partial class MainPage : ContentPage
    {

        Polyline a = new Polyline();
        double width = 0;
        double height = 0;
        public MainPage()
        {
            InitializeComponent(); 
            MainFoto.SizeChanged += MainFoto_SizeChanged;
        }

        private void LineOverLine()
        {
            
        }

        private void MainFoto_SizeChanged(object sender, EventArgs e)
        {
            label1.Text = MainFoto.Width.ToString();
            width = MainFoto.Width;
            height = MainFoto.Height;
            List<int> vs = new List<int>();
            vs.Add(1);
            vs.Add(2);
            vs.Add(3);
            vs.Add(4);
            vs.Add(5);
            vs.Add(6);
            vs.Add(7);
            vs.Add(8);
            vs.Add(9);
            vs.Add(10);
            vs.Add(11);
            output MainOut = new output(vs, 1000 /width, 1000 /height);
            a = MainOut.MakeLine();
            lolik.Children.Add(a);
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            lolik.ScaleTo(lolik.Scale - 0.4, 250);
        }
        void OnButtonClicked1(object sender, EventArgs args)
        {
            lolik.ScaleTo(lolik.Scale + 0.4, 250);
        }
        void OnButtonClickedUP(object sender, EventArgs args)
        {
            lolik.TranslateTo(lolik.TranslationX, lolik.TranslationY + 60, 250);
        }
        void OnButtonClickedDown(object sender, EventArgs args)
        {
            lolik.TranslateTo(lolik.TranslationX, lolik.TranslationY - 60, 250);
        }
        void OnButtonClickedLeft(object sender, EventArgs args)
        {
            lolik.TranslateTo(lolik.TranslationX + 60, lolik.TranslationY, 250);
        }
        void OnButtonClickedRight(object sender, EventArgs args)
        {
            lolik.TranslateTo(lolik.TranslationX - 60, lolik.TranslationY, 250);
        }
        void OnButtonClickedCenter(object sender, EventArgs args)
        {
            Navigation.PushModalAsync(new Page1());
        }
    }
}
