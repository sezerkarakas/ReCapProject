using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, DbForCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (DbForCarContext context = new DbForCarContext())
            {
                var result = from c in context.Car
                             join b in context.Brand
                             on c.BrandId equals b.BrandId                             
                             join r in context.Colors
                             on c.ColorId equals r.ColorId
                             select new CarDetailDto { CarId = c.CarId, ColorName = r.ColorName, Description = c.Description ,  BrandName = b.BrandName };

                return result.ToList();
            }

            
        }
    }
}
