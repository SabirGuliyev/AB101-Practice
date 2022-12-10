using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppSpotify.Models
{
    internal class Music
    {

        private static int _count = 1;
        public static List<Music> _allMusics = new List<Music>();
        public int Id { get; }
        public string Name { get; set; }
        public string ArtistName { get; set; }
        public int Second { get; set; }

        public Music(string name,string artistName,int second)
        {
            Name = name;
            ArtistName = artistName;
            Second = second;
            Id = _count++;
        }
        
        


    }
}
