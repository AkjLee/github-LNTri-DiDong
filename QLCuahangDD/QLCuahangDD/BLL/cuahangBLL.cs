using QLCuahangDD.DAL;
using QLCuahangDD.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLCuahangDD.BLL
{
    internal class cuahangBLL
    {
        public static List<Cuahang> GetList(String name)
        {
            QLCuahangModel model = new QLCuahangModel();
            var ls = model.Cuahangs.Where(e => e.Name == name).ToList();
            return ls;
        }

        public static List<CuahangViewModel> GetListViewModel()
        {
            QLCuahangModel model = new QLCuahangModel();
            var ls = model.Cuahangs.Select(e => new CuahangViewModel
            {
                MaCH = e.MaCH.ToString(),
                Name = e.Name,
                Diachi = e.Diachi,
                SDT = e.SDT,
            }).ToList();
            return ls;
        }



        public static bool Delete (String Name)
        {
            QLCuahangModel model = new QLCuahangModel();
            var Cuahang = model.Cuahangs.Where(e => e.Name == Name).FirstOrDefault();

                model.Cuahangs.Remove(Cuahang);
                model.SaveChanges();
            return true;

        }

    }
}
