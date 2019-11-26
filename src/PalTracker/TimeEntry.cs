using System;

namespace PalTracker
{
    public class TimeEntry
    {
        public long? Id { get; set; }
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }
        public TimeEntry(long? id,long projectid,long userid,DateTime date,int hours)
        {
            Id=id;
            ProjectId=projectid;
            UserId=userid;
            Date=date;
            Hours=hours;
        }

        public TimeEntry(long projectId, long userId, DateTime date, int hours)
        {
            Id = null;
            ProjectId = projectId;
            UserId = userId;
            Date = date;
            Hours = hours;    
        }

        public TimeEntry()
        {
            
        }

        public override bool Equals(object obj)
        {
            return obj is TimeEntry entry &&
                   Id == entry.Id &&
                   ProjectId == entry.ProjectId &&
                   UserId == entry.UserId &&
                   Date == entry.Date &&
                   Hours == entry.Hours;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, ProjectId, UserId, Date, Hours);
        }
    }
}