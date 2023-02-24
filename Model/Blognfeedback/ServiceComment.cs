// File:    ServiceComment.cs
// Created: Thursday, May 21, 2020 10:21:32 PM
// Purpose: Definition of Class ServiceComment

using System;

namespace Model.Blognfeedback
{
   public class ServiceComment : Repository.IIdentifiable<uint>
    {
      private string note;
      private uint id;
      private uint appointmentId;

        public ServiceComment(string note, uint appointmentId)
        {
            this.note = note;
            this.id = 0;
            this.appointmentId = appointmentId;
        }

        public string Note
      {
         get
         {
            return note;
         }
         set
         {
            this.note = value;
         }
      }
      
      public uint AppointmentId
      {
         get
         {
            return appointmentId;
         }
         set
         {
            this.appointmentId = value;
         }
      }

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