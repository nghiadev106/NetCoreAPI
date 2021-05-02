using RestAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Services.Interfaces
{
    public partial interface IItemServices
    {
        bool Create(ItemModel model);
        ItemModel GetDatabyID(string id);
        List<ItemModel> GetDataAll();
        List<ItemModel> Search(int pageIndex, int pageSize, out long total, string item_group_id);
    }
}
