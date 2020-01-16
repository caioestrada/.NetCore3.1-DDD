using C.Estudo.DDD.Application.AppServices.Interfaces;
using C.Estudo.DDD.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace C.Estudo.DDD.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        /// <summary>
        /// Get all users.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult<IEnumerable<UserEntryViewModel>> GetAll()
        {
            return Ok(_userAppService.GetAll());
        }

        /// <summary>
        /// Get user by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public ActionResult<UserEntryViewModel> Get(Guid id)
        {
            return Ok(_userAppService.Get(id));
        }

        /// <summary>
        /// Add user
        /// </summary>
        /// <param name="user"></param>
        [HttpPost]
        public ActionResult<UserEntryViewModel> Post([FromBody] UserEntryViewModel user)
        {
            var userViewModel = _userAppService.Insert(user);
            if (userViewModel.Invalid)
                return BadRequest(userViewModel);

            return Ok(userViewModel);
        }

        /// <summary>
        /// Update user
        /// </summary>
        /// <param name="id"></param>
        /// <param name="user"></param>
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserEntryViewModel user)
        {
            _userAppService.Update(user);
            return Ok();
        }

        /// <summary>
        /// Delete user
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("{id}")]
        public IActionResult Delete([FromBody] UserEntryViewModel user)
        {
            _userAppService.Delete(user);
            return Ok();
        }
    }
}
