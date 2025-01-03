﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemisApi.Models;

namespace HemisApi.Controllers.NH
{
    [Route("api/nh/[controller]")]
    [ApiController]
    public class vThongTinHocTapNghienCuuSinhController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public vThongTinHocTapNghienCuuSinhController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VThongTinHocTapNghienCuuSinh
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VThongTinHocTapNghienCuuSinh>>> GetVThongTinHocTapNghienCuuSinhs()
        {
            return await _context.VThongTinHocTapNghienCuuSinhs.ToListAsync();
        }

        // GET: api/VThongTinHocTapNghienCuuSinh/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VThongTinHocTapNghienCuuSinh>> GetVThongTinHocTapNghienCuuSinh(int id)
        {
            var VThongTinHocTapNghienCuuSinh = await _context.VThongTinHocTapNghienCuuSinhs.FindAsync(id);

            if (VThongTinHocTapNghienCuuSinh == null)
            {
                return NotFound();
            }

            return VThongTinHocTapNghienCuuSinh;
        }

    }
}
