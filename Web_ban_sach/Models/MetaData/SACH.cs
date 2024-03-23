using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Website_BanSach.Models
{
    [MetadataType(typeof(SACH.MetaData))]
    public partial class SACH
    {
        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã Sách ko được để trống")]
            public string Ma_Sach { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Tên Sách ko được để trống")]
            public string Ten_Sach { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Giá bán ko được để trống")]
            [Range(0, double.MaxValue, 
                      ErrorMessage = "Giá bán phải lớn hơn 0")]
            public decimal Gia_Ban { get; set; }

            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Số lượng tồn ko được để trống")]
            [Range(0, int.MaxValue,
                      ErrorMessage = "Số lượng tồn kho phải lớn hơn 0")]
            public int SoLuong_Ton { get; set; }
        }
    }
}