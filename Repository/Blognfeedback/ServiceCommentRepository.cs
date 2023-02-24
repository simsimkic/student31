// File:    ServiceCommentRepository.cs
// Created: Saturday, May 30, 2020 9:17:12 PM
// Purpose: Definition of Class ServiceCommentRepository

using Model.Blognfeedback;
using System;
using System.Collections.Generic;

namespace Repository.Blognfeedback
{
   public class ServiceCommentRepository : Repository.IRepositoryCRUD<ServiceComment, uint>

        //Id,Note,AppointmentId

    {
        private string path = @"../../Data/service_comment.csv";
        private static ServiceCommentRepository instance = null;

        private ServiceCommentRepository() {}
      
      public static ServiceCommentRepository GetInstance()
      {
            if (instance == null) instance = new ServiceCommentRepository();
            return instance;
      }

        public bool Delete(uint id)
        {
            throw new NotImplementedException();
        }

        public ServiceComment Create(ServiceComment item)
        {
            throw new NotImplementedException();
        }

        public ServiceComment Read(uint id)
        {
            throw new NotImplementedException();
        }

        public ServiceComment Update(ServiceComment item)
        {
            throw new NotImplementedException();
        }

        public List<ServiceComment> GetAll()
        {
            throw new NotImplementedException();
        }
   }
}