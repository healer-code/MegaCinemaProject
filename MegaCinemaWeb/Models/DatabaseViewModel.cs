<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MegaCinemaWeb.Models
{
    public class StatusViewModel
    {
        public string StatusID { get; set; }
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
    public class FilmCategoryViewModel
    {       
        public int FilmCategoryID { get; set; }

        [Required(ErrorMessage ="Cần phải nhập loại")]
        public string FilmCategoryName { get; set; }
        public string FilmCategoryDescrip { get; set; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
    public class FoodListViewModel
    {
        
        public int FoodID { get; set; }

        [DisplayName("Mã món ăn")]
        [MaxLength(3)]
        public string FoodPrefix { get; set; }


        public string FoodCode { get; set; }

        [DisplayName("Tên món ăn")]
        [Required(ErrorMessage = "Tên món ăn không được để trống")]
        public string FoodName { get; set; }

        [DisplayName("Giá tiền")]
        [Required(ErrorMessage = "Giá tiền không được để trống")]
        public decimal FoodPrice { get; set; }

        [DisplayName("Mô tả khái quát")]
        public string FoodDescription { get; set; }

        [DisplayName("Upload ảnh")]
        [DataType("nvarchar"), MaxLength(100)]
        public string FoodPoster { get; set; }

        [DisplayName("Trạng thái món ăn")]
        public string FoodStatusID { get; set; }
        public virtual StatusViewModel Status { get; set; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
    public class PromotionViewModel
    {
        public int PromotionID { get; set; }

        [DisplayName("Tên ưu đãi")]
        [Required(ErrorMessage = "Tên ưu đãi không được để trống")]
        public string PromotionHeader { get; set; }

        [DisplayName("Nội dung ưu đãi")]
        [Required(ErrorMessage = "Nội dung ưu đãi không được để trống")]
        public string PromotionContent { get; set; }

        [DisplayName("Ảnh poster")]
        [Required(ErrorMessage = "Ảnh poster không được để trống")]
        public string PromotionPoster { get; set; }

        [DisplayName("Ngày kết thúc")]
        public DateTime PromotionDateFinish { get; set; }

        [DisplayName("Trạng thái")]
        public string PromotionStatusID { get; set; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
    public class PromotionCineViewModel
    {
        public int PromotionID { get; set; }
        
        public int CinemaID { get; set; }

        [DisplayName("Mô tả")]
        public string Description { get; set; }

        [DisplayName("Trạng thái ưu đãi")]
        [Required(ErrorMessage = "Trạng thái ưu đãi không được để trống")]
        public string PromotionCineStatusID { get; set; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
=======
﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MegaCinemaWeb.Models
{
    public class StatusViewModel
    {
        public string StatusID { get; set; }

        [DisplayName("Tên trạng thái")]
        [Required(ErrorMessage = "Tên trạng thái không được để trống")]
        public string StatusName { get; set; }
        public string StatusDescription { get; set; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }

    public class FoodListViewModel
    {
        public int FoodID { get; set; }

        [DisplayName("Mã món ăn")]
        [MaxLength(3)]
        public string FoodPrefix { get; set; }


        public string FoodCode { get; set; }

        [DisplayName("Tên món ăn")]
        [Required(ErrorMessage = "Tên món ăn không được để trống")]
        public string FoodName { get; set; }

        [DisplayName("Giá tiền")]
        [Required(ErrorMessage = "Giá tiền không được để trống")]
        public decimal FoodPrice { get; set; }

        [DisplayName("Mô tả khái quát")]
        public string FoodDescription { get; set; }

        [DisplayName("Upload ảnh")]
        [DataType("nvarchar"), MaxLength(100)]
        public string FoodPoster { get; set; }

        [DisplayName("Trạng thái món ăn")]
        public string FoodStatusID { get; set; }
        public virtual StatusViewModel Status { get; set; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
    public class FilmViewModel
    {
        public int FilmID { get; set; }

        public string FilmPrefix { get; set; }

        public string FilmCode { get; set; }

        [DisplayName("Tên film")]
        [Required(ErrorMessage = "Tên phim không được để trống")]        
        public string FilmName { get; set; }

        [DisplayName("Thời lượng")]
        [Required(ErrorMessage = "Thời lượng không được để trống")]
        public int FilmDuration { get; set; }

        [DisplayName("Ngày công chiếu")]
        //[Required(ErrorMessage = "Ngày công chiếu không được để trống")]
        public DateTime FilmFirstPremiered { get; set; }

        [DisplayName("Ngôn ngữ")]
        [Required(ErrorMessage = "Ngôn ngữ không được để trống")]
        public string FilmLanguage { get; set; }

        [DisplayName("Nội dung phim")]
        [Required(ErrorMessage = "Nội dung phim không được để trống")]
        public string FilmContent { get; set; }

        [DisplayName("Ngày chiếu cuối cùng")]
        //[Required(ErrorMessage = "Ngày chiếu cuối cùng không được để trống")]
        public DateTime? FilmFinishPremiered { get; set; }

        [DisplayName("Poster phim")]
        //[Required(ErrorMessage = "Poster phim không được để trống")]
        public string FilmPoster { get; set; }

        [DisplayName("Công ty sản xuất")]
        [Required(ErrorMessage = "Công ty sản xuất không được để trống")]
        public string FilmCompanyRelease { get; set; }

        [DisplayName("Link trailer (youtube)")]
        [Required(ErrorMessage = "Link trailer (youtube) không được để trống")]
        public string FilmTrailer { get; set; }

        [DisplayName("Đánh giá")]
        //[Required(ErrorMessage = "Đánh giá không được để trống")]
        public int FilmRatingID { get; set; }

        [DisplayName("Trạng thái phim")]
        [Required(ErrorMessage = "Trạng thái phim không được để trống")]
        public string FilmStatus { get; set; }

        //Add
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }

    public class FilmCategory
    {

    }
>>>>>>> origin/master
}