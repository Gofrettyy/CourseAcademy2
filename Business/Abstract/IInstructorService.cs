using Core.Utilities.Results;
using Entity.Concrete;

namespace Business.Abstract;



    public interface IInstructorService
    {
        public IDataResult<List<Instructor>> GetAll();
        public IDataResult<List<Instructor>> GetByInstructorId(int id);
        public IResult Add(Instructor instructor);

        public IResult Delete(Instructor instructor);

        public IResult Update(Instructor instructor);

    }
