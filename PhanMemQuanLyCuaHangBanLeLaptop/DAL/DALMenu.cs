using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class DALMenu
    {
        QL_LaptopDataContext db;
        public List<tblMenu> getMenus()
        {
            db = new QL_LaptopDataContext();
            return db.tblMenus.Select(t => t).ToList<tblMenu>();
        }
        public bool addMenuThreeParameter(string pMaMenu, string pTenMennu, string pParentMenu)
        {
            db = new QL_LaptopDataContext();
            bool kq = true;
            try
            {
                tblMenu menuNew = new tblMenu();
                menuNew.MaMenu = pMaMenu;
                menuNew.TenMenu = pTenMennu;
                menuNew.ParentMenu = pParentMenu;
                db.tblMenus.InsertOnSubmit(menuNew);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                kq = false;
            }
            return kq;
        }
        public bool addMenuTowParameter(string pMaMenu, string pTenMennu)
        {
            db = new QL_LaptopDataContext();
            bool kq = true;
            try
            {
                tblMenu menuNew = new tblMenu();
                menuNew.MaMenu = pMaMenu;
                menuNew.TenMenu = pTenMennu;
                menuNew.ParentMenu = null;
                db.tblMenus.InsertOnSubmit(menuNew);
                db.SubmitChanges();
            }
            catch (Exception)
            {
                kq = false;
            }
            return kq;
        }
        public bool updateMenuThreeParameter(string pMaMenu,string pTenMennu, string pParentMenu)
        {
            db = new QL_LaptopDataContext();
            bool kq = true;
            try
            {
                var menu = db.tblMenus.FirstOrDefault(t => t.MaMenu.Trim() == pMaMenu);
                if (menu != null)
                {
                    menu.TenMenu = pTenMennu;
                    menu.ParentMenu = pParentMenu;
                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {
                kq = false;
            }
            return kq;
        }
        public bool updateMenuTowParameter(string pMaMenu, string pTenMennu)
        {
            db = new QL_LaptopDataContext();
            bool kq = true;
            try
            {
                var menu = db.tblMenus.FirstOrDefault(t => t.MaMenu.Trim() == pMaMenu);
                if (menu != null)
                {
                    menu.TenMenu = pTenMennu;
                    db.SubmitChanges();
                }
            }
            catch (Exception)
            {
                kq = false;
            }
            return kq;
        }
    }
}
