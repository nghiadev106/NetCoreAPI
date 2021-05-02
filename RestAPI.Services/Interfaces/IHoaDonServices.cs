using RestAPI.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Services.Interfaces
{
    public partial interface IHoaDonServices
    {
        bool Create(HoaDonModel model);
    }
}
