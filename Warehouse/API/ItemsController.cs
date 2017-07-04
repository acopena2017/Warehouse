using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Warehouse.Entities;
using Warehouse.Model;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Warehouse.API
{
  [Route("api/[controller]")]
  public class ItemsController : Controller
  {
    // GET: api/values
    [HttpGet]
    public  IEnumerable<ItemModel> Get()
    {
      List<ItemModel> model = new List<ItemModel>();
      using (var db = new wmsContext())
      {
        model = (from p in db.Item
                     select new ItemModel
                     {
                       ItemId =  p.ItemId,
                       ItemName =  p.Name,
                       Description= p.Description
                     }).Take(500).ToList();
      }
      return model;
    }

  }
}
