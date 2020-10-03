using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using dojo_net_core.Modelo;
using Microsoft.AspNetCore.Mvc;

namespace dojo_net_core.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        FirebaseAcount Instancia = FirebaseAcount.Instancia;
        public UsuarioController()
        {
        }
        [HttpGet]

        [HttpGet]
        public async Task<List<Usuario>> Get()
        {
            return await Instancia.GetUser();
        }
        [HttpPost]
        public async Task<String> Post(Usuario user)
        {
            return await Instancia.AddUser(user);
        }

        [HttpDelete]
        public async Task<String> Delete([FromQuery] String id)
        {
            return await Instancia.deleteUser(id);
        }
    }
}