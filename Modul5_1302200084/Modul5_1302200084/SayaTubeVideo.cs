using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_1302200084
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Debug.Assert(title.Length < 100 && title != null, "Length nama jangan lebih dari 100 dan jangan juga NULL!");

            this.title = title;
            Random random = new Random();
            id = random.Next(0, 100000);
            playCount = 0;
        }

        public int getplayCount()
        {
            return playCount;
        }
        public string gettitle()
        {
            return title;
        }

        public void IncreasePlayCount(int playC)
        {
            try
            {
                if (playC > 10000000) throw new Exception("playCount maksimal 10.000.000!");
                playCount = playC + playCount;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("judul: " + title);
            Console.WriteLine("play count: " + playCount);
        }
    }
}
