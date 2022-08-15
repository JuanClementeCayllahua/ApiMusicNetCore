using ApiTuningMusicNetCore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiTuningMusicNetCore.Dao
{
    public class PlayListDao
    {
        public List<PlayListResult> listarmusica()
        {
            PlayListResult obj = new PlayListResult();




            List<PlayListResult> lista = new List<PlayListResult>();

            lista.Add(new PlayListResult
            {
                id = 1,
                cancion = "La carretera",
                artista = "Prince Royce",
                genero = "Bachata",
                url = "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/musica%2FPrinceRoyce-LaCarretera.mp3?alt=media&token=cd7a7272-34b1-41d8-b0da-664a7e4dc497",
                img= "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/file%2Faplemusic-princeroyce.jpg?alt=media&token=5041d255-21c4-4557-a3b4-1c8c2d3bee13",
                album = "Bachateando",
                duracion = "3:00",
                fechapublicacion = "20220814"
            });
            lista.Add(new PlayListResult
            {
                id = 2,
                cancion = "Propuesta Indecente",
                artista = "Romeo Santos",
                genero = "Bachata",
                url = "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/bachata%2FPropuesta-Indecente-RomeoSantos.mp3?alt=media&token=28c9c2d9-91cd-438f-941c-8d0744df44cc",
                img = "https://sss.moda.pe/imagen/square/el-farsante-remix-b4458.jpg",
                album = "Bachateando",
                duracion = "3:50",
                fechapublicacion = "20220814"
            });
            lista.Add(new PlayListResult
            {
                id = 3,
                cancion = "Cancioncitas de Amor",
                artista = "Romeo Santos",
                genero = "Bachata",
                url = "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/bachata%2FCancioncitasdeAmor-RomeoSantos.mp3?alt=media&token=ced5ce30-5bb7-48c2-8e81-1e7b9666545a",
                img = "https://sss.moda.pe/imagen/square/el-farsante-remix-b4458.jpg",
                album = "Bachateando",
                duracion = "3:57",
                fechapublicacion = "20220814"
            });
            
            lista.Add(new PlayListResult
            {
                id = 4,
                cancion = "Te Robaré",
                artista = "Prince Royce",
                genero = "Bachata",
                url = "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/file%2FTeRobarePrinceRoyce.mp3?alt=media&token=a95a1e90-9b1e-41ee-9354-323588887b1c",
                img = "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/file%2Faplemusic-princeroyce.jpg?alt=media&token=5041d255-21c4-4557-a3b4-1c8c2d3bee13",
                album = "Bachateando",
                duracion = "3:41",
                fechapublicacion = "20220814"
            });

            lista.Add(new PlayListResult
            {
                id = 5,
                cancion = "Propuesta Indecente",
                artista = "Romeo Santos",
                genero = "Bachata",
                url = "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/bachata%2FPropuesta-Indecente-RomeoSantos.mp3?alt=media&token=28c9c2d9-91cd-438f-941c-8d0744df44cc",
                img = "https://sss.moda.pe/imagen/square/el-farsante-remix-b4458.jpg",
                album = "Bachateando",
                duracion = "3:50",
                fechapublicacion = "20220814"
            });

            lista.Add(new PlayListResult
            {
                id = 6,
                cancion = "Dile al amor",
                artista = "Aventura",
                genero = "Bachata",
                url = "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/bachata%2FDileAlAmor-Aventura.mp3?alt=media&token=77cc4970-7b4d-4956-962d-8098ca55e29f",
                img = "https://yt3.ggpht.com/proxy/BgYu6OKWY6ZO2ni6AGvGaD2g6te9OARZV6h2SxxzhlDFpBaqQbXqU7E5B4gxL4GFu_9GyqERsTGOorvFYbaPITVsNnwRr9vpK-hOKQjH7xsNWR9uLxGdlfhhVsVkXc_-fW9CGE0RoLvYAIf82K7Dfcb1ScgWbJyFbXDedZyE608owEVsxHYEY456Ln1pCDNo4itYrihWJMcBn1BtCmpJCgnNy0dLujHbgQg7hjRUPkRhXdiUxJjazHxQ1h-IckyMJthWMrz0PUapsNiwp59SfhR7ji04xQ=-w400-h400-n-rj-c0xffffffff",
                album = "Bachateando",
                duracion = "3:50",
                fechapublicacion = "20220814"
            });

            lista.Add(new PlayListResult
            {
                id = 7,
                cancion = "Llevame contigo",
                artista = "Romeo Santos",
                genero = "Bachata",
                url = "https://firebasestorage.googleapis.com/v0/b/munayapp-2227b.appspot.com/o/bachata%2FLlevame-contigo-RomeoSantos.mp3?alt=media&token=d8531f4e-c044-4e67-bb04-645db6e82707",
                img = "https://sss.moda.pe/imagen/square/el-farsante-remix-b4458.jpg",
                album = "Bachateando",
                duracion = "3:49",
                fechapublicacion = "20220814"
            });

            return lista;
        }
    }
}
