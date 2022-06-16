using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class BLLAutoCodeGeneration
    {
        DALAutoCodeGeneration dalACG;

        public string createIDPhieuXuat()
        {
            dalACG = new DALAutoCodeGeneration();
            return dalACG.createIDPhieuXuat();
        }
        public string createIDKH()
        {
            dalACG = new DALAutoCodeGeneration();
            return dalACG.createIDKH();
        }
    }
}
