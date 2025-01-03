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
    public class vGVDuocCuDiDaoTaoController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public vGVDuocCuDiDaoTaoController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VGVDuocCuDiDaoTao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VGvduocCuDiDaoTao>>> GetVGVDuocCuDiDaoTaos()
        {
            return await _context.VGvduocCuDiDaoTaos.ToListAsync();
        }

        // GET: api/VGVDuocCuDiDaoTao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VGvduocCuDiDaoTao>> GetVGVDuocCuDiDaoTao(int id)
        {
            var VGVDuocCuDiDaoTao = await _context.VGvduocCuDiDaoTaos.FindAsync(id);

            if (VGVDuocCuDiDaoTao == null)
            {
                return NotFound();
            }

            return VGVDuocCuDiDaoTao;
        }
    }
}
