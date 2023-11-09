using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IReportRepository
    {
        List<Report> GetReports();
        List<Report> GetReportByUserIdAndPostId(string userId, string id);
        List<Report> GetReportByUserIdAndCommentId(string userId, string id);
        void AddReport(Report report);
        void DeleteReportByPostId(string id);
        void DeleteReportByCommentId(string id);
        void DeleteReportByUserIdAndPostId(string userid, string id);     
        void DeleteReportByUserIdAndCommentId(string userid, string id);
    }
}
