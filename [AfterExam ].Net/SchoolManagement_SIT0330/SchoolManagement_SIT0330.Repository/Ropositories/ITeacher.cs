using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Repository.Ropositories
{
    public interface ITeacher
    {
        List<TeacherModel> GetAllTeacherList();

        string CreateTeacher(TeacherModel teacherModel);

        int TeacherDelete(int id);

        TeacherModel EditTeacherModel(int id);

        int PostTeacherData(TeacherModel teacherModel);

        List<Country> GetALLCountry();
        List<State> GetAllState(int CountryId);

        List<City> GetAllCity(int StateId);

        
    }
}
