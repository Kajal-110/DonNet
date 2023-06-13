using SchoolManagement_SIT0330.Helpers.Helpers;
using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using SchoolManagement_SIT0330.Repository.Ropositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Repository.Services
{
    public class TeacherServices : ITeacher
    {
        KajalPatel_SIT0330Entities _context = new KajalPatel_SIT0330Entities();
        public List<TeacherModel> GetAllTeacherList()
        {
            try
            {

                List<Teacher1> teachers = new List<Teacher1>();
                List<TeacherModel> teacherModels = new List<TeacherModel>();

                teachers = _context.Teacher1Set.ToList();
                if(teachers != null && teachers.Count > 0)
                {
                    teacherModels = TeacherHelpers.BindTeacherModel(teachers);
                }
                    return teacherModels;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public string CreateTeacher(TeacherModel teacherModel)
        {
            try
            {
                Teacher1 teacher = new Teacher1();
                teacher = TeacherHelpers.ConvertToTeacherModel(teacherModel);
                if(teacher != null)
                {
                    _context.Teacher1Set.Add(teacher);
                    _context.SaveChanges();
                    return "success";
                }
                else
                {
                    return "Fail";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int TeacherDelete(int id)
        {
            try
            {
                var res = _context.Teacher1Set.Where(x => x.TeacherId == id).FirstOrDefault();
                _context.Teacher1Set.Remove(res);
                _context.SaveChanges();
                 return 1;
                
            }
            catch (Exception E)
            {
                throw E;
                
            }   
            
        }

        public TeacherModel EditTeacherModel(int id)
        {
            Teacher1 teacher1;
            teacher1 = _context.Teacher1Set.Find(id);

            TeacherModel teacherModel = TeacherHelpers.EditUser(teacher1);
            return teacherModel;
        }

        public int PostTeacherData(TeacherModel teacherModel)
        {
            try
            {
                Teacher1 teacher = TeacherHelpers.ConvertToTeacherModel(teacherModel);
                _context.Entry(teacher).State = System.Data.Entity.EntityState.Modified;
                _context.SaveChanges();
                return 1;
            }
            catch (Exception e)
            {

                throw e;
            }
        }

        public List<Country> GetALLCountry()
        {
            List<Country> countries = _context.Countries.ToList();
            return (countries);
        }

        public List<State> GetAllState(int CountryId)
        {
            List<State> states = _context.States.Where(x => x.CountryId == CountryId).ToList();
            return states;
        }

        public List<City> GetAllCity(int StateId)
        {
            List<City> cities = _context.Cities.Where(x => x.StateId == StateId).ToList();
            return cities;
        }

       
    }
}

