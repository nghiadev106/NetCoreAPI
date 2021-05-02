using RestAPI.Model;
using RestAPI.Repositories.Interfaces;
using RestAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPI.Services
{
    public partial class HoaDonServices : IHoaDonServices
    {
        private IHoaDonRepository _res;
        public HoaDonServices(IHoaDonRepository res)
        {
            _res = res;
        }
        public bool Create(HoaDonModel model)
        {
            return _res.Create(model);
        }
    }
}
