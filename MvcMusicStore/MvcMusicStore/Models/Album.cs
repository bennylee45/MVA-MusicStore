using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcMusicStore.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; }
        public virtual Artist Artist { get; set; }

        public virtual List<Review> Review { get; set; }


    }
}
