﻿using Mango.Services.CouponAPI.Data;
using Mango.Services.CouponAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Mango.Services.CouponAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CouponAPIController : ControllerBase
    {
        private readonly AppDbContext _db;

        public CouponAPIController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public object Get()
        {
            try
            {
                IEnumerable<Coupon> objList = _db.Coupons.ToList();
                return objList;

            }
            catch (Exception ex) 
            {
            }
            return null;
        }

        [HttpGet("{id:int}")]
        public object Get(int id) 
        {
            try
            {
                Coupon obj = _db.Coupons.First(u => u.CouponId == id);
                return obj;

            }
            catch (Exception ex)
            {
            }
            return null;
        }
    }
}
