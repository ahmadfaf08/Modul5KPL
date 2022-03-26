using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul5_1302200084
{
    internal class SayaTubeUser
    {
        private int id;
        public string Username;
        List<SayaTubeVideo> uploadedVideos;

        public SayaTubeUser(string uname)
        {
            Random random = new Random();
            this.id = random.Next(0, 100000);
            uploadedVideos = new List<SayaTubeVideo>();
            this.Username = uname;

        }

        public int GetTotalVideoPlayCount()
        {
            int total, tambah;
            total = 0;

            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                tambah = uploadedVideos[i].getplayCount();
                total = total + tambah;
            }

            return total;
        }

        public void AddVideo(SayaTubeVideo x)
        {
            uploadedVideos.Add(x);
        }

        public void PrintAllVideoPlaycount()
        {
            Console.WriteLine("User \t: " + this.Username);
            Console.WriteLine("\n");
            for (int i = 0; i < uploadedVideos.Count; i++)
            {
                Console.WriteLine("Video " + (i + 1) + " judul \t: " + uploadedVideos[i].gettitle());
                uploadedVideos[i].PrintVideoDetails();
            }

        }
    }
}
