using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Shapes;

namespace main
{
    public class output
    {
        List<int> RequiredPointsId = new List<int>(); // id точек через который нужно пройти
        public double kfX { get; set; }
        double kfY = 0;
        public output(List<int> RequiredPointsId, double kfX, double kfY)
        {
            this.RequiredPointsId = RequiredPointsId;
            this.kfX = kfX;
            this.kfY = kfY;
        }

        public Polyline MakeLine()
        {
            Polyline a = new Polyline();
            a.Stroke = Xamarin.Forms.Color.Red;
            a.IsVisible = true;
            a.StrokeThickness = 2;
            double[] firstXY = new double[2];
            for (int i = 0; i<RequiredPointsId.Count; i++)
            {
                PointSearch(RequiredPointsId[i]);
                a.Points.Add(new Point((int)(PointSearch(RequiredPointsId[i])[0]/kfX), (int)(PointSearch(RequiredPointsId[i])[1]/kfY)));
            }
            return a;
        }
        
        public double[] PointSearch(int id)
        {
            double[] a = new double[2];
            List<string> temp = new List<string>();
            temp.Add("1 746 413");
            temp.Add("2 746 460");
            temp.Add("3 778 460");
            temp.Add("4 778 426");
            temp.Add("5 778 337");
            temp.Add("6 778 282");
            temp.Add("7 778 202");
            temp.Add("8 778 124");
            temp.Add("9 743 124");
            temp.Add("10 673 124");
            temp.Add("11 376 124");
            for(int i = 0; i<temp.Count; i++)
            {
                string[] s = temp[i].Split(' ');
                if (Convert.ToInt32(s[0]) == id)
                {
                    a[0] = Convert.ToInt32(s[1]);
                    a[1] = Convert.ToInt32(s[2]);
                    return a;
                }
            }
            return a;
        }
    }
}
