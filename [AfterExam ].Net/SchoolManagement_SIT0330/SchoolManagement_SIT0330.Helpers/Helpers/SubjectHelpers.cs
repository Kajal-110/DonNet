using SchoolManagement_SIT0330.Models.Context;
using SchoolManagement_SIT0330.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement_SIT0330.Helpers.Helpers
{
    public class SubjectHelpers
    {
        public static List<subject> BindSubject(List<SubjectModel> subjectModels)
        {
            try
            {
                List<subject> subjectList = new List<subject>();
                foreach( var item in subjectModels)
                {
                    subject subject1 = new subject();
                    subject1.SubjectId = item.SubjectId;
                    subject1.SubjectName = item.SubjectName;
                    subjectList.Add(subject1);

                }
                return subjectList;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<SubjectModel> BindUserModel(List<subject> subjects)
        {
            try
            {
                List<SubjectModel> subjectModelList = new List<SubjectModel>();
                foreach(var item in subjects)
                {
                    SubjectModel subjectModel = new SubjectModel();
                    subjectModel.SubjectId = item.SubjectId;
                    subjectModel.SubjectName = item.SubjectName;
                    subjectModelList.Add(subjectModel);
                }
                return subjectModelList;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
