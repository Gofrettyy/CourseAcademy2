using System.ComponentModel.DataAnnotations;
using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using FluentValidation;
using ValidationException = FluentValidation.ValidationException;

namespace Business.Concrete;

public class CourseManager:ICourseService
{
    ICourseDal _courseDal;
    public CourseManager(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
 
       
    public IDataResult<List<Course>> GetByCourseId(int id)
    {
        return new SuccessDataResult<List<Course>>(_courseDal.GetAll(c => c.Id == id));
    }

    public IDataResult<List<Course>> GetAll()
    {
        if (DateTime.Now.Hour == 18)
        {
            return new ErrorDataResult<List<Course>>(Messages.MaintenanceTime);
        }
        return new SuccessDataResult<List<Course>>(_courseDal.GetAll(),Messages.CourseListed);
    }


    public IDataResult<List<CourseDetailDto>> GetCourseDetails()
    {
        return new SuccessDataResult<List<CourseDetailDto>>(_courseDal.GetCourseDetails());
    }

    [ValidationAspect(typeof(CourseValidator))]
    public IResult Add(Course course)
    {
        _courseDal.Add(course);
        return new SuccessResult(Messages.CourseAdded);
    }

    public IResult Delete(Course course)
    {
        _courseDal.Delete(course);
        return new SuccessResult(Messages.CourseDeleted);
    }

    public IResult Update(Course course)
    {
        _courseDal.Update(course);
        return new SuccessResult(Messages.CourseUpdated);
    }
}