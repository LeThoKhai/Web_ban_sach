using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_ban_sach.Models.DAO
{
    public class TAIKHOAN_DAO
    {
        public static TAIKHOAN Read(string username) {
            using(BanSachEntities2 db = new BanSachEntities2())
            {
                TAIKHOAN ketqua=db.TAIKHOAN.FirstOrDefault(n=>n.UserID == username);
                if (ketqua != null)
                {
                    List<CHUCNANG>lst_chunang=ketqua.LOAI_TAIKHOAN.CHUCNANG.ToList();
                    ketqua.lst_ChucNang = new List<string>();
                    foreach(CHUCNANG cn in lst_chunang)
                    {
                        ketqua.lst_ChucNang.Add(cn.ID_ChucNang);
                    }
                }
                return ketqua;
            }
        }
    }
}