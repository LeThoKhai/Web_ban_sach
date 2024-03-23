using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Web_ban_sach.Models
{
    [MetadataType(typeof(DONDATHANG.MetaData))]
    public  partial class DONDATHANG
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Mã mã đơn hàng không được để trống")]
            public string MaDonHang { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Ngày đặt không được để trống")]
            public System.DateTime Ngaydat { get; set; }


            [Required(AllowEmptyStrings = false, ErrorMessage = "Mã khách hàng không được để trống")]
            public string MaKH { get; set; }
        }
    }
}