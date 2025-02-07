﻿using Res247.Models.Common;
using Res247.Services.BaseServices;

namespace Res247.Services
{
    public interface ICovidInfoServices : IBaseService<CovidInfo>
    {
        CovidInfo GetCovidInfoByAccountId(string accountId);
    }
}
