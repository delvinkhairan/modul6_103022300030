using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300030
{
    class SayaTubeUser
    {
        private int id;
        private string username;
        private List<sayaTubeVideos> uploadedVideos;

        public SayaTubeUser(String username)
        {
            if (username == null || username.Length > 100)
                throw new ArgumentException("username tidak boleh kosong dan maksimal adalah 200 character");
            this.id = new Random().Next(10000, 99999);
            this.username = username;
            this.uploadedVideos = new List<sayaTubeVideos>();
        }

        public void AddVideo(sayaTubeVideos Video)
        {
            if (Video == null)
                throw new ArgumentException("video tidak boleh kosong");
            uploadedVideos.Add(Video);
            
        }

        public int GetTotalVideoPlayCount()
        {
            int totalPlayCount = 0;
            foreach (var video in uploadedVideos)
            {
                totalPlayCount += video.GetPlayCount();
            }


            return totalPlayCount;
        }

        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("user: ");
            for (int i = 0; i < Math.Min(8, uploadedVideos.Count); i++)
            {
                Console.WriteLine("video: ");
            }

        }
    }
}
