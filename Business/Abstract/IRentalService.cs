using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Add(Rentals rental);
        IResult Update(Rentals rental);
        IResult Delete(Rentals rental);
        IDataResult<List<Rentals>> GetAll();
       
        IDataResult<Rentals> GetById(int Id);
        IDataResult<List<RentalDetailDto>> GetRentalDetails();
        IResult CheckReturnDate(int carId);
        
    }
}
