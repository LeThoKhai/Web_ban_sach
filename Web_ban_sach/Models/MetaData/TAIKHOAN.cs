using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Web_ban_sach.Models
{
    public partial class TAIKHOAN
    {
        public List<string> lst_ChucNang { get; set; }
        sealed class MetaData
        {
            
            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã TK ko được để trống")]
            public string UserID { get; set; }



            [Required(AllowEmptyStrings = false,
                      ErrorMessage = "Mã TK ko được để trống")]

            public string Password { get; set; }



            [Required(AllowEmptyStrings = false,
                        ErrorMessage = "Loại TK ko được để trống")]
            public string ID_Loai_TK { get; set; }
        }
    }
}