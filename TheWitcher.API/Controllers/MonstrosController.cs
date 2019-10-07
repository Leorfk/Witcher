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
        private readonly IConnection _connection;
        public MonstrosController()
        {
            _connection = new Connection();
            _monstros = new MonstrosDAO(_connection);
        }
        // GET: api/<controller>
        [HttpGet]
        public List<Monstro> Get()

        {
            return _monstros.GetAll();
        }

        // GET v1/monstros/unico?id=90
        [HttpGet("unico")]
        public Monstro Get(int id)
        {
            return _monstros.GetById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE v1/monstros/del?id=90
        [HttpDelete("del")]
        public void Delete(int id)
        {
            _monstros.Delete(id);
        }
    }
}
