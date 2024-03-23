using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_ban_sach.Models
{
    [MetadataType(typeof(NHAXUATBAN.MetaData))]
    public partial class NHAXUATBAN
    {
        public int Count;

        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã NXB ko được để trống")]
            public string Ma_NXB { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Tên NXB ko được để trống")]
            public string Ten_NXB { get; set; }
        }
    }
}