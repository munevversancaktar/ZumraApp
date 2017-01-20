using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZumraApp.Data.Model.Models.Images
{
    public class Image
    {
        public int ImageID { get; set; }

        public string Name { get; set; }

        public string LittleImageWay { get; set; }

        public string MiddleImageWay { get; set; }

        public string BigImageWay { get; set; }

        public string VideoWay { get; set; }

        public Guid AddingID { get; set; }

        public DateTime AddingDate { get; set; }

        public int Seen { get; set; }

        public int Like { get; set; }
    }
}
