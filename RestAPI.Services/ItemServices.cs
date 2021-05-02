using RestAPI.Model;
using RestAPI.Repositories.Interfaces;
using RestAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Services
{
    public partial class ItemServices : IItemServices
    {
        private IItemRepository _res;
        public ItemServices(IItemRepository ItemGroupRes)
        {
            _res = ItemGroupRes;
        }
        public bool Create(ItemModel model)
        {
            return _res.Create(model);
        }
        public ItemModel GetDatabyID(string id)
        {
            return _res.GetDatabyID(id);
        }
        public List<ItemModel> GetDataAll()
        {
            return _res.GetDataAll();
        }
        public List<ItemModel> Search(int pageIndex, int pageSize, out long total, string item_group_id)
        {
            return _res.Search(pageIndex, pageSize, out total, item_group_id);
        }
    }

}
