using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web_ban_sach.Models;

namespace Web_ban_sach.Models.DAO
{
    public class CHUDE_DAO
    {
        public static List<CHUDE> Read()
        {
            using (BanSachEntities2 db = new BanSachEntities2())
            {
                List<CHUDE> ketqua = db.CHUDE.ToList();
                foreach(CHUDE cd in ketqua)
                {
                    cd.count = db.SACH_.Count(n => n.MaCD == cd.MaCD);
                }
                return ketqua;
            }
        }
    }
}