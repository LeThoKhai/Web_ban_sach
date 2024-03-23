using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Web_ban_sach.Models
{
    [MetadataType(typeof(KHACHHANG.MetaData))]
    public partial class KHACHHANG
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Khách hàng ko được để trống")]
            public string MaKH { get; set; }

            [EmailAddress(ErrorMessage = "Địa chỉ email ko đúng định dạng")]
            public string Email { get; set; }
        }
    }
}