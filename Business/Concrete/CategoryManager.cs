using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;


public class CategoryManager:ICategoryService
{
    ICategoryDal _categoryDal;

    public CategoryManager(ICategoryDal categoryDal)
    {
        _categoryDal = categoryDal;
    }

    public IResult Add(Category category)
    {
        _categoryDal.Add(category);
        return new SuccessResult(Messages.CategoryAdded);
    }

    public IResult Delete(Category category)
    {
        _categoryDal.Delete(category);
        return new SuccessResult(Messages.CategoryDeleted);
    }

    public IDataResult<List<Category>> GetAll()
    {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Messages.CategoryListed);
    }

    public IDataResult<List<Category>> GetByCategoryId(int id)
    {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(ct=>ct.Id == id));
    }

    public IResult Update(Category category)
    {
        _categoryDal.Update(category);
        return new SuccessResult(Messages.CategoryUpdated);
    }
}