// File:    BlogPost.cs
// Created: Thursday, May 21, 2020 10:21:32 PM
// Purpose: Definition of Class BlogPost

using Model.Roles;
using System;

namespace Model.Blognfeedback
{
   public class BlogPost : Repository.IIdentifiable<uint>
    {
      private DateTime time;
      private string text;
      private uint id;

        public BlogPost(DateTime time, string text, Staff author)
        {
            this.time = time;
            this.text = text;
            this.id = 0;
            this.author = author;
        }

        public DateTime Time
      {
         get
         {
            return time;
         }
      }
      
      public string Text
      {
         get
         {
            return text;
         }
         set
         {
            this.text = value;
         }
      }
      
      public Model.Roles.Staff author;
      
      /// <summary>
      /// Property for Model.Roles.Staff
      /// </summary>
      /// <pdGenerated>Default opposite class property</pdGenerated>
      public Model.Roles.Staff Author
      {
         get
         {
            return author;
         }
         set
         {
            this.author = value;
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