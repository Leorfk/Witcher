using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheWitcher.Data.Connections;
using TheWitcher.Data.DAO;
using TheWitcher.Data.Interfaces;
using TheWitcher.Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TheWitcher.API.Controllers
{
    [Route("v1/[controller]")]
    public class MonstrosController : Controller
    {
        private readonly IDAO<Monstro> _monstros;
        public MonstrosController()
        {
            _monstros = new MonstrosDAO();
        }
        // GET: api/<controller>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(Ok(_monstros.GetAll()));
            }
            catch (Exception ex)
            {

                return Json(StatusCode(500, "Deu ruim: " + ex.Message));
            }
            
        }

        // GET v1/monstros/unico?id=90
        [HttpGet("unico")]
        public IActionResult Get(int id)
        {
            try
            {
                return Json(Ok(_monstros.GetById(id)));
            }
            catch (Exception ex)
            {

                return Json(StatusCode(500, "Deu ruim: " + ex.Message));
            }
        }

        // POST v1/monstros/cadastro
        [HttpPost("cadastro")]
        public IActionResult Post([FromBody]Monstro monstro)
        {
            try
            {
                return Json(Ok(_monstros.Insert(monstro)));
            }
            catch (Exception ex)
            {
                return Json(StatusCode(500, "Deu ruim: " + ex.Message));
            }
        }

        // PUT api/<controller>/5
        [HttpPut("atualizar")]
        public IActionResult Put([FromBody]Monstro monstro)
        {
            try
            {
                _monstros.Update(monstro);
                return Json(Ok("Atualizado com sucesso"));
            }
            catch (Exception ex)
            {

                return Json(StatusCode(500, "Deu ruim: " + ex.Message));
            }
        }

        // DELETE v1/monstros/delete?idMonstro=90
        [HttpDelete("delete")]
        public IActionResult Delete(int idMonstro)
        {
            try
            {
                return Json(Ok(_monstros.Delete(idMonstro)));
            }
            catch (Exception ex)
            {

                return Json(StatusCode(500, "Deu ruim: " + ex.Message));
            }
            
        }
    }
}
