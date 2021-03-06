﻿using BoardGamesRentalApplication.BLL.Enums;
using BoardGamesRentalApplication.BLL.Models;
using BoardGamesRentalApplication.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesRentalApplication.BLL.IService
{
    public interface IBoardGameFilterService
    {
        IQueryable<BoardGame> FilterBy(IQueryable<BoardGame> boardGamesQuery, Dictionary<int, int> filterParametersDict);
        IList<Filter> GetAllFilterParameters();
        string GetSelectedFilterOptionByFilterParameters(IList<Filter> filterParameters);
        Dictionary<int, int> GetFilterParametersDictByString(string selectedFilterOption);
        void SetSelectedFilterOptionInFilterParameters(IList<Filter> filterParameters, Dictionary<int, int> filterParametersDict);
    }
}
