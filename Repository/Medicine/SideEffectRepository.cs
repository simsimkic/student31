// File:    SideEffectRepository.cs
// Created: Saturday, May 30, 2020 9:29:02 PM
// Purpose: Definition of Class SideEffectRepository

using Class_Diagram.Repository;
using Model.Medicine;
using System;
using System.Collections.Generic;

namespace Repository.Medicine
{
   public class SideEffectRepository : Repository.IRepositoryCRUD<SideEffect, uint>

        //Id,Name,Description

    {
        private string path = @"../../Data/side_effect.csv";
        private static SideEffectRepository instance = null;

        private SideEffectRepository() {}
      
      public static SideEffectRepository GetInstance()
      {
            if (instance == null) instance = new SideEffectRepository();
            return instance;
      }

        public bool Delete(uint id)
        {
            return Persistence.RemoveEntry(path, id.ToString());
        }

        public SideEffect Create(SideEffect item)
        {
            string[] data = new string[3];
            item.SetId(Persistence.GetNewId(path));
            data[0] = item.GetId().ToString();
            data[1] = item.Name;
            data[2] = item.Description;
            if (Persistence.WriteEntry(path, data))
                return item;
            else return null;
        }

        public SideEffect Read(uint id)
        {
            List<string[]> temp = Persistence.ReadEntryByPrimaryKey(path, id.ToString());
            return new SideEffect(uint.Parse(temp[0][0]), temp[0][2], temp[0][1]);
        }

        public SideEffect Update(SideEffect item)
        {
            string[] data = new string[3];
            data[0] = item.GetId().ToString();
            data[1] = item.Name;
            data[2] = item.Description;
            if (Persistence.WriteEntry(path, data))
                return item;
            else return null;
        }

        public List<SideEffect> GetAll()
        {
            throw new NotImplementedException();
        }
   }
}