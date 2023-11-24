// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;


class Program
{
    static void Main(string[] args)
    {

        CourseManager courseManager = new CourseManager(new EfCourseDal());
        var result = courseManager.GetAll();

        if (result.Success)
        {
            foreach (var course in result.Data)
            {
                Console.WriteLine(course.Title);
            }

            Console.WriteLine(result.Message);
        }
        else
        {
            Console.WriteLine(result.Message);
        }

        CourseTest();

        void CourseTest()
        {
            CourseManager courseManager = new CourseManager(new EfCourseDal());

            var result = courseManager.GetCourseDetails(); //GetAll() -> çağırılırsa datalar gelecek
            if (result.Success == true)
            {
                foreach (var course in result.Data)
                {
                    Console.WriteLine(course.Title + "/" + course.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

        }
    }
}
   
