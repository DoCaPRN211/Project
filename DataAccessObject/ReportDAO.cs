using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class ReportDAO
    {
        private static ReportDAO instance = null;
        private static object instanceLock = new object();
        private ReportDAO() { }
        public static ReportDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ReportDAO();
                }
                return instance;
            }
        }

        public List<Report> GetReports()
        {
            using var db = new DoCaPrnContext();
            return db.Reports.ToList();
        }

        public List<Report> GetReportByUserIdAndPostId(string userId, string id)
        {
            var reports = GetReports();
            if (reports != null)
            {
                var tmp = reports.Where(r =>
                    r.Userid.Equals(userId, StringComparison.OrdinalIgnoreCase) && r.Postid != null &&
                    r.Postid.Equals(id, StringComparison.OrdinalIgnoreCase) && r.Isactive &&
                    r.Commentid == null).ToList();

                return tmp;
            }
            return null;
        }

        public List<Report> GetReportByUserIdAndCommentId(string userId, string id)
        {
            var reports = GetReports();
            if (reports != null)
            {
                var tmp = reports.Where(r =>
                    r.Userid.Equals(userId, StringComparison.OrdinalIgnoreCase) && r.Commentid != null &&
                    r.Commentid.Equals(id, StringComparison.OrdinalIgnoreCase) && r.Isactive &&
                    r.Postid == null).ToList();

                return tmp;
            }
            return null;
        }

        public void AddReport(Report report)
        {
            using var db = new DoCaPrnContext();
            db.Reports.Add(report);
            db.SaveChanges();
        }

        public void DeleteReportByPostId(string id)
        {
            using var db = new DoCaPrnContext();
            var p = db.Reports.Where(p => p.Postid == id && p.Commentid == null);
            if (p != null)
            {
                foreach (var report in p)
                {
                    report.Isactive = false;
                }
                db.SaveChanges();
            }
        }

        public void DeleteReportByCommentId(string id)
        {
            using var db = new DoCaPrnContext();
            var p = db.Reports.Where(p => p.Commentid == id && p.Postid == null);
            if (p != null)
            {
                foreach (var report in p)
                {
                    report.Isactive = false;
                }
                db.SaveChanges();
            }
        }

        public void DeleteReportByUserIdAndPostId(string userid, string id)
        {
            using var db = new DoCaPrnContext();
            var report = db.Reports.Where(r =>
                    r.Userid.Equals(userid) && r.Postid != null &&
                    r.Postid.Equals(id) && r.Isactive &&
                    r.Commentid == null).ToList();
            if (report != null)
            {
                foreach (var p in report)
                {
                    p.Isactive = false;
                }
            }
            db.SaveChanges();
        }

        public void DeleteReportByUserIdAndCommentId(string userid, string id)
        {
            using var db = new DoCaPrnContext();
            var report = db.Reports.Where(r =>
                    r.Userid.Equals(userid) && r.Commentid != null &&
                    r.Commentid.Equals(id) && r.Isactive &&
                    r.Postid == null).ToList();
            if (report != null)
            {
                foreach (var p in report)
                {
                    p.Isactive = false;
                }
            }
            db.SaveChanges();
        }

    }
}
