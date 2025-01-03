﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemisApi.Models;

namespace HemisApi.Controllers.HTQT
{
    [Route("api/htqt/[controller]")]
    [ApiController]
    public class vLuuHocSinhSinhVienNNController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public vLuuHocSinhSinhVienNNController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VLuuHocSinhSinhVienNN
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VLuuHocSinhSinhVienNn>>> GetVLuuHocSinhSinhVienNNs()
        {
            return await _context.VLuuHocSinhSinhVienNns.ToListAsync();
        }

        // GET: api/VLuuHocSinhSinhVienNN/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VLuuHocSinhSinhVienNn>> GetVLuuHocSinhSinhVienNN(int id)
        {
            var VLuuHocSinhSinhVienNN = await _context.VLuuHocSinhSinhVienNns.FindAsync(id);

            if (VLuuHocSinhSinhVienNN == null)
            {
                return NotFound();
            }

            return VLuuHocSinhSinhVienNN;
        }

    }
}
