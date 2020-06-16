using EFCoreTutorial.Models;
using System;

namespace EFCoreTutorial
{        

    public class SongRepository
    {

        private MusicContext db;
        public SongRepository(MusicContext db)
        {
            this.db = db;
        }
        public int Count()
        {
            return -1;
        }


    }
}
