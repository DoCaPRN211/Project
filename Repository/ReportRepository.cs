using BusinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReportRepository : IReportRepository
    {
        public List<Report> GetReports()
            => ReportDAO.Instance.GetReports();
        public List<Report> GetReportByUserIdAndPostId(string userId, string id)
            => ReportDAO.Instance.GetReportByUserIdAndPostId(userId, id);
        public List<Report> GetReportByUserIdAndCommentId(string userId, string id)
            => ReportDAO.Instance.GetReportByUserIdAndCommentId(userId, id);
        public void AddReport(Report report)
            => ReportDAO.Instance.AddReport(report);
        public void DeleteReportByPostId(string id)
            => ReportDAO.Instance.DeleteReportByPostId(id);
        public void DeleteReportByCommentId(string id)
            => ReportDAO.Instance.DeleteReportByCommentId(id);
        public void DeleteReportByUserIdAndPostId(string userid, string id)
            => ReportDAO.Instance.DeleteReportByUserIdAndPostId(userid, id);
        public void DeleteReportByUserIdAndCommentId(string userid, string id)
            => ReportDAO.Instance.DeleteReportByUserIdAndCommentId(userid, id);
    }
}
