using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_ban_sach.Models;

namespace Web_ban_sach.Models.DAO
{
    public class NHAXUATBAN_DAO
    {
        public static List<NHAXUATBAN> Read()
        {
            using (BanSachEntities db = new BanSachEntities())
            {
                List<NHAXUATBAN> ketqua = db.NHAXUATBAN.ToList();
                foreach(NHAXUATBAN nxb in ketqua)
                {
                    nxb.Count = db.SACH_.Count(n => n.MaNXB == nxb.MaNXB);
                }
                return ketqua;
            }
        }
    }
}