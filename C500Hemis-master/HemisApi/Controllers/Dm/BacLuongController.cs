﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemisApi.Models;

namespace HemisApi.Controllers.Dm
{
    [Route("api/dm/[controller]")]
    [ApiController]
    public class BacLuongController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public BacLuongController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/DmBacLuong
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DmBacLuong>>> GetDmBacLuongs()
        {
            return await _context.DmBacLuongs.ToListAsync();
        }

        // GET: api/DmBacLuong/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DmBacLuong>> GetDmBacLuong(int id)
        {
            var dmBacLuong = await _context.DmBacLuongs.FindAsync(id);

            if (dmBacLuong == null)
            {
                return NotFound();
            }

            return dmBacLuong;
        }

    }
}
