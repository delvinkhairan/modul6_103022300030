using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300030
{
    class sayaTubeVideos
    {
        private int id;
        private string title;
        private int playCount;

        public sayaTubeVideos(string title)
        {
            if (title == null || title.Length > 200)
                throw new ArgumentException("judul tidak boleh kosong dan maksimal adalah 200 character");
            this.id = new Random().Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 250000000)
                throw new AbandonedMutexException("harus diantara 0 dan 25.000.000");
            checked
            {
                playCount += count;
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: ");
            Console.WriteLine("JUDUL: ");
            Console.WriteLine("PLAY COUNT: ");
        }

        public int GetPlayCount()
        {
            return playCount;
        }





    }
}
