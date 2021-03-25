using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetByCarId(int carId);
        IDataResult<List<Car>> GetAllByBrandId(int brandId);
        IDataResult<List<Car>> GetAllbyColorId(int colorId);

        IResult Add(Car car);
        IResult Update(Car car);
        IResult Delete(Car car);

    }
}
