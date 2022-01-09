using Basic.Infrastructure.Entities;
using Basic.Infrastructure.ExceptionHandler;
using Basic.Models;
using Basic.Models.Menu;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basic.Services.MenuService
{
    public class MenuService : BasicService,IMenuService
    {
        private readonly BasicContext _db;
        public MenuService(BasicContext db)
        {
            this._db = db;
        }

        public async Task<ActionResult<Result>> Create(MenuCreateRQ model)
        {          
            var entity = new Menu
            {
                MenuCode = model.Code,
                MenuName = model.Name,
            };
            _ = _db.Menus.AddAsync(entity);
            var result = await _db.SaveChangesAsync();

            if (result < 0)
            {
                return await Fail();
            }

            return await Success();
        }

        public async Task<ActionResult<Result>> Delete(MenuDeleteRQ model)
        {
            var entity = _db.Menus.FirstOrDefault(x => x.MenuId == model.Id);
            _db.Menus.Remove(entity);            
            var result = await _db.SaveChangesAsync();

            if (result < 0)
            {
                return await Fail();
            }

            return await Success();
        }

        public async Task<ActionResult<Result>> Edit(MenuEditRQ model)
        {
            var entity = _db.Menus.FirstOrDefault(x => x.MenuId == model.Id);
            entity.MenuCode = model.Code;
            entity.MenuName = model.Name;

            var result = await _db.SaveChangesAsync();

            if (result < 0)
            {
                return await Fail();
            }

            return await Success();
        }
    }
}
