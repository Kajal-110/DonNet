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
    public class SubjectServices: ISubject
    {
        KajalPatel_SIT0330Entities _context = new KajalPatel_SIT0330Entities();
        public List<SubjectModel> GetAllSubjectList()
        {
            try
            {
                List<subject> subjects1 = new List<subject>();
                List<SubjectModel> subjectModels = new List<SubjectModel>();
                subjects1 = _context.subjects.ToList();
                if(subjects1 != null && subjects1.Count > 0)
                {
                    subjectModels = SubjectHelpers.BindUserModel(subjects1);
                }
                return subjectModels;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
