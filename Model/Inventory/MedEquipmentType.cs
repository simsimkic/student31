// File:    MedEquipmentType.cs
// Created: Thursday, May 21, 2020 10:21:32 PM
// Purpose: Definition of Class MedEquipmentType

using System;

namespace Model.Inventory
{
   public class MedEquipmentType : Repository.IIdentifiable<uint>
    {
      private string name;
      private uint id;
      private uint number;

        public MedEquipmentType(string name, uint number)
        {
            this.name = name;
            this.id = 0;
            this.number = number;
        }

        public MedEquipmentType(uint id, string name, uint number)
        {
            this.name = name;
            this.id = id;
            this.number = number;
        }

        public string Name
      {
         get
         {
            return name;
         }
         set
         {
            this.name = value;
         }
      }
      
      public uint Id
      {
         get
         {
            return id;
         }
      }
      
      public uint Number
      {
         get
         {
            return number;
         }
         set
         {
            this.number = value;
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