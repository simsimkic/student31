// File:    PrescriptionRepository.cs
// Created: Saturday, May 30, 2020 10:02:48 PM
// Purpose: Definition of Class PrescriptionRepository

using Class_Diagram.Repository;
using Model.Examination;
using Model.Medicine;
using Repository.Medicine;
using System;
using System.Collections.Generic;

namespace Repository.Patientdata
{
   public class PrescriptionRepository : Repository.IRepositoryCRUD<Prescription, uint>

        //Id, DrugId, Number, Usage

    {
        private string path = @"../../Data/prescription.csv";
        private static PrescriptionRepository instance = null;

        private PrescriptionRepository() {}
      
      public static PrescriptionRepository GetInstance()
      {
            if (instance == null) instance = new PrescriptionRepository();
            return instance;
      }

        public bool Delete(uint id)
        {
            return Persistence.RemoveEntry(path, id.ToString());
        }

        public Prescription Create(Prescription item)
        {
            string[] data = new string[4];
            data[0] = Persistence.GetNewId(path).ToString();
            item.SetId(uint.Parse(data[0]));
            data[1] = item.drug.GetId().ToString();
            data[2] = item.Number.ToString();
            data[3] = item.Usage.ToString();
            bool isAdded = Persistence.WriteEntry(path, data);
            if (isAdded) return item;
            else return null;
        }

        public Prescription Read(uint id)
        {
            List<string[]> data = Persistence.ReadEntryByPrimaryKey(path, id.ToString());
            if (data.Count == 1)
            {
                uint presID = uint.Parse(data[0][0]);
                uint drugID = uint.Parse(data[0][1]);
                Drug d = DrugRepository.GetInstance().Read(drugID);
                uint num = uint.Parse(data[0][2]);
                string usage = data[0][3];
                Prescription ret = new Prescription(num, usage, d);
                ret.SetId(presID);
                return ret;
            }
            return null;
        }

        public Prescription Update(Prescription item)
        {
            throw new NotImplementedException();
        }

        public List<Prescription> GetAll()
        {
            List<string> ids = Persistence.ReadAllPrimaryIds(path);
            List<Prescription> ret = new List<Prescription>();
            foreach (string s in ids) ret.Add(Read(uint.Parse(s)));
            return ret;
        }
   }
}