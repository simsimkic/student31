// File:    WorkingTime.cs
// Created: Thursday, May 21, 2020 10:21:32 PM
// Purpose: Definition of Class WorkingTime

using System;

namespace Model.Roles
{
   public class WorkingTime : Repository.IIdentifiable<uint>
   {
      private DateTime timestamp;
      private DateTime startTime;
      private DateTime endTime;
      private uint idStaff;
      private uint id;

        public WorkingTime(DateTime timestamp, DateTime startTime, DateTime endTime, uint idStaff, Staff staff)
        {
            this.timestamp = timestamp;
            this.startTime = startTime;
            this.endTime = endTime;
            this.idStaff = idStaff;
            this.id = 0;
            this.staff = staff;
        }

        public DateTime Timestamp
      {
         get
         {
            return timestamp;
         }
      }
      
      public DateTime StartTime
      {
         get
         {
            return startTime;
         }
         set
         {
            this.startTime = value;
         }
      }
      
      public DateTime EndTime
      {
         get
         {
            return endTime;
         }
         set
         {
            this.endTime = value;
         }
      }
      
      public uint IdStaff
      {
         get
         {
            return idStaff;
         }
         set
         {
            this.idStaff = value;
         }
      }
      
      public Staff staff;

        public uint GetId()
        {
            return id;
        }

        public void SetId(uint id)
        {
            this.id = id;
        }
    }
}