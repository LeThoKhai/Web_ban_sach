using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Website_BanSach.Models
{
    [MetadataType(typeof(TAC_GIA.MetaData))]
    public partial class TAC_GIA
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Tác giả ko được để trống")]
            public string MaTG { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Tên Tác giả ko được để trống")]
            public string TenTG { get; set; }
        }
    }
}