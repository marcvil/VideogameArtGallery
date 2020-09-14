using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideogameArtGallery.Data_Transfer_Objects
{
    public class ImagesByGame
    {
        public string GameName;
        public string GameDescription;
        public ImageDTO[] images;
        public Genre[] genres;
        public Platform[] platforms;

    }
}
