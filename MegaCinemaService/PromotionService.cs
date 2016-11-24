﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCinemaData.Infrastructures;
using MegaCinemaData.Repositories;
using MegaCinemaModel.Models;

namespace MegaCinemaService
{
    public interface IPromotionService
    {
        Promotion Add(Promotion promotion);
        IEnumerable<Promotion> GetPromotionPaging(int page, int pageSize, out int totalRow);
        // triển khai các phương thức của service
        void SaveChanges();
    }
    public class PromotionService : IPromotionService
    {
        IPromotionRepository _promotionRepository;
        IUnitOfWork _unitOfWork;

        public PromotionService(IPromotionRepository promotionRepository, IUnitOfWork unitOfWork)
        {
            _promotionRepository = promotionRepository;
            _unitOfWork = unitOfWork;
        }

        public Promotion Add(Promotion promotion)
        {
            return _promotionRepository.Add(promotion);
        }

        public IEnumerable<Promotion> GetPromotionPaging(int page, int pageSize, out int totalRow)
        {
            var query = _promotionRepository.GetAll();
            totalRow = query.Count();
            return query.Skip((page - 1) * pageSize).Take(pageSize);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }
    }
}
