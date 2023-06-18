﻿using SE_TUT_Adopt_Me_v3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SE_TUT_Adopt_Me_v3.Repository
{
    public class pet_header_repo
    {
        static DatabaseEntities db = new DatabaseEntities();

        public void AddPetHeader(pet_header PetHeader)
        {
            db.pet_header.Add(PetHeader);
            db.SaveChanges();
        }

        public void UpdatePetHeader(pet_header PetHeader)
        {
            var existingPetHeader = db.pet_header.Find(PetHeader.pet_header_id);
            if (existingPetHeader != null)
            {
                db.Entry(existingPetHeader).CurrentValues.SetValues(PetHeader);
                db.SaveChanges();
            }
        }

        public void DeletePetHeader(int petHeaderId)
        {
            var petHeader = db.pet_header.Find(petHeaderId);
            if (petHeader != null)
            {
                db.pet_header.Remove(petHeader);
                db.SaveChanges();
            }
        }

        public pet_header GetPetHeaderById(int petHeaderId)
        {
            return db.pet_header.Find(petHeaderId);
        }

        public List<pet_header> GetAllPetHeaders()
        {
            return db.pet_header.ToList();
        }
    }
}