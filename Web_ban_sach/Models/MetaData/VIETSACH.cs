using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_ban_sach.Models
{
    [MetadataType(typeof(VIETSACH.MetaData))]
    public partial class VIETSACH
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Tác giả ko được để trống")]
            public string MaTG { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Sách ko được để trống")]
            public string Ma_Sach { get; set; }
        }
    }
}