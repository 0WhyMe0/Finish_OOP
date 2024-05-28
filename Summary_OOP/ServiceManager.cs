using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Summary_OOP
{
    internal class ServiceManager
    {
        List<MusicService> musicServiceList;

        public ServiceManager()
        {
            musicServiceList = new List<MusicService>();
        }

        public void ServiceAdd(MusicService serviceName)
        {
            musicServiceList.Add(serviceName);
            Console.WriteLine("Service added! ");
        }

        public void ServiceUpdate(string serviceName, MusicService updateService) 
        {
            MusicService service = musicServiceList.Find(s => s.nameMusicService == serviceName);

            if (service != null) 
            {
                service.nameMusicService = updateService.nameMusicService;
                Console.WriteLine($"Service update! ");
            }
            else
            {
                Console.WriteLine("Faile! ");
            }
        }

        public void ServiceDelete(string serviceName)
        {
            MusicService deleteService = musicServiceList.Find(s => s.nameMusicService == serviceName);

            if (deleteService != null)
            {
                musicServiceList.Remove(deleteService);
                Console.WriteLine("Service delete! ");
            }
            else
            {
                Console.WriteLine("Failed! ");
            }
        }

        public List<MusicService> GetMusicServiceList()
        {
            return musicServiceList;
        }
    }
}
