using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTuningMusicNetCore.Model
{
    public class PlayListResult
    {
        public int id { get; set; }

        public string cancion { get; set; }

        public string artista { get; set; }

        public string genero { get; set; }
        public string img { get; set; }

        public string url { get; set; }

        public string album { get; set; }

        public string duracion { get; set; }

        public string fechapublicacion { get; set; }
    }
}
