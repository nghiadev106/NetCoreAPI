using RestAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Repositories.Interfaces
{
    public partial interface IItemGroupRepository
    {
        List<ItemGroupModel> GetData();
    }
}
