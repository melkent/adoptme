﻿using SE_TUT_Adopt_Me_v3.Factory;
using SE_TUT_Adopt_Me_v3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SE_TUT_Adopt_Me_v3.Repository
{
    public class cart_repo
    {
        static DatabaseEntities2 db = new DatabaseEntities2();

        public void AddCart(string customerId)
        {
            cart_factory.CreateCart(customerId);
            db.SaveChanges();
        }

        public void UpdateCart(cart Cart)
        {
            var existingCart = db.carts.Find(Cart.cart_id);
            if (existingCart != null)
            {
                db.Entry(existingCart).CurrentValues.SetValues(Cart);
                db.SaveChanges();
            }
        }

        public void DeleteCart(string cartId)
        {
            var cart = db.carts.Find(cartId);
            if (cart != null)
            {
                db.carts.Remove(cart);
                db.SaveChanges();
            }
        }

        public cart GetCartById(string cartId)
        {
            return db.carts.Find(cartId);
        }

        public List<cart> GetAllCarts()
        {
            return db.carts.ToList();
        }
    }
}