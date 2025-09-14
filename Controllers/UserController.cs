using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace MyFirstAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{

    /*
     * Formas de passar info para a API
     * Existem 4 formas principais:
     * 1 - Query String: /api/user?name=John&age=30
     * 2- Route Parameters: /api/user/John/30 (GET) 
     * 3- Request Body: Enviar um objeto JSON no corpo da requisição (Usado em POST, PUT, PATCH.)
     * 4 - Headers: Informações adicionais no cabeçalho da requisição (Autenticação, etc)
     */

    //ProducesResponseType é usado para documentar os tipos de resposta que a ação pode retornar


    //Usando Query String
    //[HttpGet]
    //[Route("{id}")] // Usado para route parameters
    //[ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    //[ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    //public IActionResult GetUser(int id)
    //{
    //    return Ok(new User{Id = 1,  Name = "John Doe", Age = 30 });
    //}



    //Usando Header
    //Necessario usar o [FromHeader], pois não consegue identificar sozinho
    // string? o paramentro vira opcional
    [HttpGet]
    [ProducesResponseType(typeof(User), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult GetUser([FromHeader][Required] int id, [FromHeader] string? nickname)
    {
        return Ok(new User { Id = 1, Name = "John Doe", Age = 30 });
    }


    [HttpPost]
    public IActionResult CreateUser()
    {
        return Created();
    }
}
