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
        public static async Task AddSemesterAsync(string semesterType, DateTime startDate, DateTime endDate)
        {
            using (var db = new UniGuardDbContext())
            {
                var semester = new SemesterData
                { SemesterType = semesterType, StartDate = startDate, EndDate = endDate };
                await db.SemesterData.AddAsync(semester);
                await db.SaveChangesAsync();
            }
        }

        public static async Task<List<SemesterData>> GetAllSemestersAsync()
        {
            using (var db = new UniGuardDbContext())
            {
                var result = await db.SemesterData.ToListAsync();
                return result;
                
            }
        } 

        public static async Task AddSubjectAsync(string subjectCode, int semesterId)
        {
            using (var db = new UniGuardDbContext())
            {
                var subject = new SubjectData { SemesterName = subjectCode, SemesterId = semesterId };
                await db.SubjectData.AddAsync(subject);
                await db.SaveChangesAsync();

            }
        }

        public static async Task<List<SubjectData>> GetAllSubjectsAsync()
        {
            using (var db = new UniGuardDbContext())
            {
                var result = await db.SubjectData.ToListAsync();
                return result;
            }
        }

        public static async Task AddAssigmentAsync(string assigmentName,
            string assigmentState, int subjectId, DateTime endDate)
        {
            using (var db = new UniGuardDbContext())
            {
                var assigment = new AssigmentData
                { AssigmentName = assigmentName, AssigmentState = assigmentState, SubjectId = subjectId,
                AssigmentEndDate = endDate};
                await db.AssigmentData.AddAsync(assigment);
                await db.SaveChangesAsync();
            }
        }

        public static async Task<List<SubjectData>> GetAllSubjectsInSemesterAsync(int semesterId)
        {
            using (var db = new UniGuardDbContext())
            {
                var result = await db.SubjectData.Where(x => x.SemesterId == semesterId).ToListAsync();
                return result;
            }
        }

        public static async Task<List<AssigmentData>> GetAllAssigmentsInSubjectAsync(int subjectId)
        {
            using(var db = new UniGuardDbContext())
            {
                var result = await db.AssigmentData.Where(x => x.SubjectId == subjectId).ToListAsync();
                return result;
            }
        }

        public static async Task<List<AssigmentData>> GetAllAssigmentsInSemesterAsync(int semesterId)
        {
            using (var db = new UniGuardDbContext())
            {
                var subjects = db.SubjectData.Where(x => x.SemesterId == semesterId);
                var assigments = await db.AssigmentData
                    .Where(x => subjects.Select(y => y.Id).Contains(x.SubjectId)).ToListAsync();
                return assigments;
            }
        }

        public static async Task UpdateAssigmentAsync(int assigmentId, string newName,
            string newState, DateTime newDate)
        {
            using (var db = new UniGuardDbContext())
            {
                var assigment = db.AssigmentData.Where(x => x.AssigmentId == assigmentId).First();
                assigment.AssigmentName = newName;
                assigment.AssigmentState = newState;
                assigment.AssigmentEndDate = newDate;
                await db.SaveChangesAsync();
            }
        }

        public static async Task RemoveSemesterAsync(SemesterData semesterData)
        {
            using (var db = new UniGuardDbContext())
            {
                db.SemesterData.Attach(semesterData);
                db.SemesterData.Remove(semesterData);
                await db.SaveChangesAsync();
            }
        }
        public static async Task<List<AssigmentData>> GetAllAssigmentsAsync()
        {
            using (var db = new UniGuardDbContext())
            {
                var assigments = await db.AssigmentData.ToListAsync();
                return assigments;
            }
        }

        public static string GetAssigmentSubjectName(int subjectId)
        {
            using (var db = new UniGuardDbContext())
            {
                var result = db.SubjectData.Where(x => x.Id == subjectId).First().SemesterName;
                return result;

            }
        }

        public static async Task RemoveAssigmentAsync(AssigmentData assigment)
        {
            using (var db = new UniGuardDbContext())
            {
                db.Attach(assigment);
                db.Remove(assigment);
                await db.SaveChangesAsync();
            }
        }

        public static async Task RemoveSubjectAsync(SubjectData subject)
        {
            using (var db = new UniGuardDbContext())
            {
                db.Attach(subject);
                db.Remove(subject);
                await db.SaveChangesAsync();
            }
        }
    }
}
