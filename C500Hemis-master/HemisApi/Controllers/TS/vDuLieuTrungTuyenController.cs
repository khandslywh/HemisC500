﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemisApi.Models;

namespace HemisApi.Controllers.TS
{
    [Route("api/ts/[controller]")]
    [ApiController]
    public class vDuLieuTrungTuyenController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public vDuLieuTrungTuyenController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VDuLieuTrungTuyen
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VDuLieuTrungTuyen>>> GetVDuLieuTrungTuyens()
        {
            return await _context.VDuLieuTrungTuyens.ToListAsync();
        }

        // GET: api/VDuLieuTrungTuyen/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VDuLieuTrungTuyen>> GetVDuLieuTrungTuyen(int id)
        {
            var VDuLieuTrungTuyen = await _context.VDuLieuTrungTuyens.FindAsync(id);

            if (VDuLieuTrungTuyen == null)
            {
                return NotFound();
            }

            return VDuLieuTrungTuyen;
        }

    }
}
