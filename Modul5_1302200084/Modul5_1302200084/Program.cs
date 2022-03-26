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
            Console.WriteLine();
            SayaTubeVideo b = new SayaTubeVideo("Review Film b oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();
            SayaTubeVideo c = new SayaTubeVideo("Review Film c oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();
            SayaTubeVideo d = new SayaTubeVideo("Review Film d oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();
            SayaTubeVideo e = new SayaTubeVideo("Review Film e oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();
            SayaTubeVideo f = new SayaTubeVideo("Review Film f oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();
            SayaTubeVideo g = new SayaTubeVideo("Review Film g oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();
            SayaTubeVideo h = new SayaTubeVideo("Review Film h oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();
            SayaTubeVideo i = new SayaTubeVideo("Review Film i oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();
            SayaTubeVideo j = new SayaTubeVideo("Review Film j oleh Ahmad Fadhil Aulia Faisal");
            Console.WriteLine();

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

            SayaTubeUser namaUser = new SayaTubeUser("Ahmad Fadhil Aulia Faisal");

            a.IncreasePlayCount(1);
            b.IncreasePlayCount(3);
            c.IncreasePlayCount(5);
            d.IncreasePlayCount(3);
            e.IncreasePlayCount(1);
            f.IncreasePlayCount(2);
            g.IncreasePlayCount(2);
            h.IncreasePlayCount(3);
            i.IncreasePlayCount(5);
            j.IncreasePlayCount(2);

            namaUser.AddVideo(a);
            namaUser.AddVideo(b);
            namaUser.AddVideo(c);
            namaUser.AddVideo(d);
            namaUser.AddVideo(e);
            namaUser.AddVideo(f);
            namaUser.AddVideo(g);
            namaUser.AddVideo(h);
            namaUser.AddVideo(i);
            namaUser.AddVideo(j);

            a.PrintVideoDetails();

            namaUser.PrintAllVideoPlaycount();
        }
    }
}