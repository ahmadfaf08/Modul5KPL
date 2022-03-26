using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_1302200084
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayaTubeVideo a = new SayaTubeVideo("Review Film a oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo b = new SayaTubeVideo("Review Film b oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo c = new SayaTubeVideo("Review Film c oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo d = new SayaTubeVideo("Review Film d oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo e = new SayaTubeVideo("Review Film e oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo f = new SayaTubeVideo("Review Film f oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo g = new SayaTubeVideo("Review Film g oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo h = new SayaTubeVideo("Review Film h oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo i = new SayaTubeVideo("Review Film i oleh Ahmad Fadhil Aulia Faisal");
            SayaTubeVideo j = new SayaTubeVideo("Review Film j oleh Ahmad Fadhil Aulia Faisal");
            a.PrintVideoDetails();
            b.PrintVideoDetails();
            c.PrintVideoDetails();
            d.PrintVideoDetails();
            e.PrintVideoDetails();
            f.PrintVideoDetails();
            g.PrintVideoDetails();
            h.PrintVideoDetails();
            i.PrintVideoDetails();
            j.PrintVideoDetails();
        }
    }
}