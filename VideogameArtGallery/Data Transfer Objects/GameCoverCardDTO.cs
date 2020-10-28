using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideogameArtGallery.Data_Transfer_Objects
{
    public class GameCoverCardDTO
    {
        public string gameName;

        public string gameDescription;

        public string imageCoverUrl;

        public string imageGameLogoUrl;

        public string[] genresNames;

        public int[] platformsIds;
    }
}
