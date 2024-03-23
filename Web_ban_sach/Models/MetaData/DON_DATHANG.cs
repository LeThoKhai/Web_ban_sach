using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Website_BanSach.Models
{
    [MetadataType(typeof(DON_DATHANG.MetaData))]
    public partial class DON_DATHANG
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Đơn hàng ko được để trống")]
            public string Ma_DonHang { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Ngày Đặt hàng ko được để trống")]
            public System.DateTime Ngay_Dat { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Khách hàng ko được để trống")]
            public string MaKH { get; set; }
        }
    }
}