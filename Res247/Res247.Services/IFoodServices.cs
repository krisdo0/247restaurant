﻿using Res247.Models.Common;
using Res247.Services.BaseServices;
using System.Collections.Generic;

namespace Res247.Services
{
    public interface IFoodServices : IBaseService<Food>
    {
        IEnumerable<Food> GetFoodsByCate(int cateId, bool isIncludeDelete = false);

        IEnumerable<Food> GetSimilarFood(int foodId, bool isIncludeDelete = false);

        void RemoveCategoriesFromFood(int foodId);
    }
}
