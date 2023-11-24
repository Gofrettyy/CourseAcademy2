using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract;


    public interface ICategoryService
    {
        public IDataResult<List<Category>> GetAll();

        public IDataResult<List<Category>> GetByCategoryId(int id);

        //crud
        public IResult Add(Category category);
        public IResult Delete(Category category);
        public IResult Update(Category category);

    }
