using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Basic.Models;
using Basic.Models.Menu;
using Basic.Services.MenuService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Basic.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MenuController : BasicController<MenuController>
    {
        private readonly IMenuService _menuService;
        public MenuController(IMenuService menuService)
        {
            this._menuService = menuService;           
        }

        [HttpPost]
        public Task<ActionResult<Result>> Create([FromBody] MenuCreateRQ model)
        {
            if (!ModelState.IsValid)
            {
                return Fail();
            }

            return _menuService.Create(model);
        }

        [HttpPost]
        public Task<ActionResult<Result>> Delete([FromBody] MenuDeleteRQ model)
        {
            if (!ModelState.IsValid)
            {
                return Fail();
            }

            return _menuService.Delete(model);
        }

        [HttpPost]
        public Task<ActionResult<Result>> Edit([FromBody] MenuEditRQ model)
        {
            if (!ModelState.IsValid)
            {
                return Fail();
            }

            return _menuService.Edit(model);
        }
    }
}
