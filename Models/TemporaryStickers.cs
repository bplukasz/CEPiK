using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CEPiK.Models
{
    public class TemporaryStickers
    {
        public int TemporaryStickersID { get; set; }
        public DateTime ReleaseOfTheControlSticker { get; set; }
        public DateTime ReleaseOfTheTemporaryBoardSticker { get; set; }

        public Vehicle vehicle { get; set; }

    }
}
