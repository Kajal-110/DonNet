using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Helpers.Helpers
{
    public class TeacherHelpers
    {
        public static List<Teacher1>  BindTeacher(List<TeacherModel> teacherModels)
        {
            try
            {
                List<Teacher1> teacherList = new List<Teacher1>();
                foreach(var item in teacherModels)
                {
                    Teacher1 teacher = new Teacher1();
                    teacher.TeacherId = item.TeacherId;
                    teacher.FirstName = item.FirstName;
                    teacher.LastName = item.LastName;
                    teacher.Address = item.Address;
                    teacher.Email = item.Email;
                    teacher.PhoneNumber = item.PhoneNumber;
                    teacher.CountryId = item.CountryId;
                  
                    teacher.StateId = item.StateId;
                    teacher.CityId = item.CityId;

                    teacherList.Add(teacher);
                }
                return teacherList;
            }
            catch (Exception e)
            {

                throw e;
            }
        }


        public static List<TeacherModel> BindTeacherModel(List<Teacher1> teacher)
        {
            try
            {
                List<TeacherModel> teacherModelList = new List<TeacherModel>();
                foreach(var item in teacher)
                {
                    TeacherModel teacherModel = new TeacherModel();
                    teacherModel.TeacherId = item.TeacherId;
                    teacherModel.FirstName = item.FirstName;
                    teacherModel.LastName = item.LastName;
                    teacherModel.Address = item.Address;
                    teacherModel.Email = item.Email;
                    teacherModel.PhoneNumber = item.PhoneNumber;
                    teacherModel.CountryId = item.CountryId;
                    teacherModel.CountryName = item.Country.CountryName;
                    teacherModel.StateId = item.StateId;
                    teacherModel.StateName = item.State.StateName;
                    teacherModel.CityId = item.CityId;
                    teacherModel.CityName = item.City.CityName;
                    teacherModelList.Add(teacherModel);
                }
                return teacherModelList;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public static Teacher1 ConvertToTeacherModel(TeacherModel teacherModel)
        {
            Teacher1 teacher1 = new Teacher1();
            teacher1.TeacherId = teacherModel.TeacherId;
            teacher1.FirstName = teacherModel.FirstName;
            teacher1.LastName = teacherModel.LastName;
            teacher1.Address = teacherModel.Address;
            teacher1.Email = teacherModel.Email;
            teacher1.PhoneNumber = teacherModel.PhoneNumber;
            teacher1.CountryId = teacherModel.CountryId;
            //teacher1.Country.CountryName = teacherModel.CountryName;
            teacher1.StateId = teacherModel.StateId;
            //teacher1.State.StateName = teacherModel.StateName;
            teacher1.CityId = teacherModel.CityId;
            //teacher1.City.CityName = teacherModel.CityName;
            return teacher1;
        }

        public static TeacherModel EditUser(Teacher1 teacher1)
        {
         
            TeacherModel teacherModel = new TeacherModel();
            teacherModel.TeacherId = teacher1.TeacherId;
            teacherModel.FirstName = teacher1.FirstName;
            teacherModel.LastName = teacher1.LastName;
            teacherModel.Address = teacher1.Address;
            teacherModel.Email = teacher1.Email;
            teacherModel.CountryId = teacher1.CountryId;
            teacherModel.CountryName = teacher1.Country.CountryName;
            teacherModel.StateId = teacher1.StateId;
            teacherModel.StateName = teacher1.State.StateName;
            teacherModel.CityId = teacher1.CityId;
            teacherModel.CityName = teacher1.City.CityName;
           
            return teacherModel;
        }
    }
}


