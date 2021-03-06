﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCinemaData.Infrastructures;
using MegaCinemaModel.Models;

namespace MegaCinemaData.Repositories
{
    public interface IFilmCategoryRepository : IRepository<FilmCategory>
    {
        //triển khai phương thức mới không phải CRUD + paging
    }

    public class FilmCategoryRepository:RepositoryBase<FilmCategory>,IFilmCategoryRepository
    {
        public FilmCategoryRepository(IDbFactory dbfactory):base(dbfactory)
        {

        }
    }
}
