using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;

namespace Business.Concrete;

public class InstructorManager:IInstructorService
{
    IInstructorDal _instructorDal;
    public InstructorManager(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }

    public IDataResult<List<Instructor>>GetAll()
    {
        return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll());
    }

    public IDataResult<List<Instructor>> GetByInstructorId(int id)
    {
        return new SuccessDataResult<List<Instructor>>(_instructorDal.GetAll(i => i.Id == id));
    }

    public IResult Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
        return new SuccessResult(Messages.InstructorAdded);
    }

    public IResult Delete(Instructor instructor)
    {
        _instructorDal.Delete(instructor);
        return new SuccessResult(Messages.InstructorDeleted);
    }

    public IResult Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
        return new SuccessResult(Messages.InstructorUpdated);
    }
}