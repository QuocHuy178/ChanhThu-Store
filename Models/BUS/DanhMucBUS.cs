using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChanhThuStore.Models.BUS
{
    public class DanhMucBUS
    {
        public static IEnumerable<DanhMuc> DanhSach()
        {
            var db = new ChanhThuStoreDB();
            return db.Query<DanhMuc>("select * from DanhMuc ");
        }

        public static IEnumerable<DanhMuc> DanhMucCon(String id)
        {
            var db = new ChanhThuStoreDB();
            return db.Query<DanhMuc>("select * from DanhMucCon where MaDanhMuc = '" + id + "'");
        }

        public static IEnumerable<DanhMucCon> DanhSachDMC()
        {
            var db = new ChanhThuStoreDB();
            return db.Query<DanhMucCon>("select * from DanhMucCon ");
        }
    }
}