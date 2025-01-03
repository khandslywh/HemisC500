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
    public class vThongTinHopTacController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public vThongTinHopTacController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VThongTinHopTac
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VThongTinHopTac>>> GetVThongTinHopTacs()
        {
            return await _context.VThongTinHopTacs.ToListAsync();
        }

        // GET: api/VThongTinHopTac/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VThongTinHopTac>> GetVThongTinHopTac(int id)
        {
            var VThongTinHopTac = await _context.VThongTinHopTacs.FindAsync(id);

            if (VThongTinHopTac == null)
            {
                return NotFound();
            }

            return VThongTinHopTac;
        }

   
    }
}
