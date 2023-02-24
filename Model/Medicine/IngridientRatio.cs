// File:    IngridientRatio.cs
// Created: Thursday, May 21, 2020 10:21:32 PM
// Purpose: Definition of Class IngridientRatio

using System;

namespace Model.Medicine
{
   public class IngridientRatio : Repository.IIdentifiable<uint>
    {
      private decimal ratio;
      private uint drugId;
      private uint id;

        public IngridientRatio(decimal ratio, uint drugId, Ingridient ingridient)
        {
            this.ratio = ratio;
            this.drugId = drugId;
            this.id = 0;
            this.ingridient = ingridient;
        }

        public IngridientRatio(uint id, decimal ratio, uint drugId, Ingridient ingridient)
        {
            this.ratio = ratio;
            this.drugId = drugId;
            this.id = id;
            this.ingridient = ingridient;
        }

        public decimal Ratio
      {
         get
         {
            return ratio;
         }
         set
         {
            this.ratio = value;
         }
      }
      
      public uint DrugId
      {
         get
         {
            return drugId;
         }
         set
         {
            this.drugId = value;
         }
      }
      
      public Ingridient ingridient;

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