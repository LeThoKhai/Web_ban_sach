using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_ban_sach.Models
{
    public partial class SACH_
    {
        [MetadataType(typeof(SACH_.MetaData))]

        sealed class MetaData
        {
            [Required(AllowEmptyStrings = false, ErrorMessage = "Mã sách không được để trống")]
            public string Masach { get; set; }


            [Required(AllowEmptyStrings = false, ErrorMessage = "Tên sách không được để trống")]
            public string Tensach { get; set; }

            [Range(0, float.MaxValue, ErrorMessage = "Giá bán phải lớn hơn 0 hoặc bằng")]
            [Required(AllowEmptyStrings = false, ErrorMessage = "Giá bán không được để trống")]
            public decimal Giaban { get; set; }


            [Range(1, int.MaxValue, ErrorMessage = "Số lượng tồn phải lớn hơn 0")]
            [Required(AllowEmptyStrings = false, ErrorMessage = "Số lượng tồn không được để trống")]
            public int Soluongton { get; set; }
        }
    }
}