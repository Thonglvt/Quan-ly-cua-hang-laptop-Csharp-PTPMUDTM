using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class BLLMenu
    {
        DALMenu dalMenu;

        public BLLMenu() { }
        public bool kiemTraChucNangDaTonTai(string pMaMenu)
        {
            dalMenu = new DALMenu();
            List<tblMenu> lstMenu = dalMenu.getMenus();
            var menu = lstMenu.FirstOrDefault(t => t.MaMenu.Trim() == pMaMenu);
            return (menu != null) ? true : false;//True: đã tồn tại
        }
        public bool ChekAddTowParam(string pMaMenu, string pTenMennu)
        {
            dalMenu = new DALMenu();
            return dalMenu.addMenuTowParameter(pMaMenu, pTenMennu);
        }
        public bool ChekAddThreeParam(string pMaMenu, string pTenMennu, string pParentMenu)
        {
            dalMenu = new DALMenu();
            return dalMenu.addMenuThreeParameter(pMaMenu, pTenMennu,pParentMenu);
        }
        public bool ChekUpdateTowParameter(string pMaMenu, string pTenMennu)
        {
            dalMenu = new DALMenu();
            return dalMenu.updateMenuTowParameter(pMaMenu, pTenMennu);
        }
        public bool ChekUpdateThreeParameter(string pMaMenu, string pTenMennu, string pParentMenu)
        {
            dalMenu = new DALMenu();
            return dalMenu.updateMenuThreeParameter(pMaMenu, pTenMennu, pParentMenu);
        }
    }
}
