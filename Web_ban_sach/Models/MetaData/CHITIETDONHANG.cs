using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Web_ban_sach.Models
{
    public partial class CHITIETDONHANG
    {
        //kiểm tra dữ liệu
        [MetadataType(typeof(CHITIETDONHANG.MetaData))]
        sealed class MetaData
        {
            [Required(AllowEmptyStrings =false,ErrorMessage ="Mã đơn hàng không được để trống")]
            public string MaDonHang { get; set; }

            [Required(AllowEmptyStrings = false, ErrorMessage = "Mã sách không được để trống")]
            public string MaSach { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Mã số lượng không được để trống")]
            [Range(1,int.MaxValue,ErrorMessage ="Số lượng phải lớn hơn 0")]
            public int Soluong { get; set; }
            [Required(AllowEmptyStrings = false, ErrorMessage = "Đơn giá không được để trống")]
            [Range(0, float.MaxValue, ErrorMessage = "Đơn giá phải lớn hơn 0 hoặc bằng")]
            public decimal Dongia { get; set; }

        }
    }
}