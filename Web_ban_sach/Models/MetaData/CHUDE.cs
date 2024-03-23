using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_ban_sach.Models
{
    [MetadataType(typeof(CHUDE.MetaData))]
    public partial class CHUDE
    {
        public int count;

        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Chủ đề ko được để trống")]
            public string Ma_ChuDe { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Tên Chủ đề ko được để trống")]
            public string Ten_ChuDe { get; set; }
        }
    }
}