using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using DataAccess.Abstract;
using Business.Constants.Business;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            _carDal.Add(car);
            return new SuccessResult(Messages.CarAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.CarDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(), Messages.CarsListed);
        }

        public IDataResult<List<Car>> GetAllByBrandId(int brandId)
        {
            return new SuccessDataResult<List<Car>> (_carDal.GetList(p => p.BrandId == brandId), Messages.CarListedForBrandId);
        }

        public IDataResult<List<Car>> GetAllbyColorId(int colorId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetList(p => p.ColorId == colorId), Messages.CarListedForColorId);
        }

        public IDataResult<Car> GetByCarId(int carId)
        {
            return new SuccessDataResult<Car>(_carDal.Get(p => p.Id == carId));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.CarUpdated);
        }
    }
}
