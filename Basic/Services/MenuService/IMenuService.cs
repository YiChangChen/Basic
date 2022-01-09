using Basic.Models;
using Basic.Models.Menu;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Basic.Services.MenuService
{
    public interface IMenuService
    {
        public Task<ActionResult<Result>> Create(MenuCreateRQ model);
        public Task<ActionResult<Result>> Delete(MenuDeleteRQ model);
        public Task<ActionResult<Result>> Edit(MenuEditRQ model);
    }
}
