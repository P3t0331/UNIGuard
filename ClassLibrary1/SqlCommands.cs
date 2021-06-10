using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace UniGuardClassLibrary
{
    public static class SqlCommands
    {
        public static async Task AddSemester(string semesterType, DateTime startDate, DateTime endDate)
        {
            using (var db = new UniGuardDbContext())
            {
                var semester = new SemesterData { SemesterType = semesterType, StartDate = startDate, EndDate = endDate };
                await db.SemesterData.AddAsync(semester);
                await db.SaveChangesAsync();
            }
        }

        public static async Task<List<SemesterData>> GetAllSemesters()
        {
            using (var db = new UniGuardDbContext())
            {
                var result = await db.SemesterData.ToListAsync();
                return result;
                
            }
        } 

        public static async Task AddSubject(string subjectCode, int semesterId)
        {
            using (var db = new UniGuardDbContext())
            {
                var subject = new SubjectData { SemesterName = subjectCode, SemesterId = semesterId };
                await db.SubjectData.AddAsync(subject);
                await db.SaveChangesAsync();

            }
        }

        public static async Task<List<SubjectData>> GetAllSubjects()
        {
            using (var db = new UniGuardDbContext())
            {
                var result = await db.SubjectData.ToListAsync();
                return result;
            }
        }
    }
}
