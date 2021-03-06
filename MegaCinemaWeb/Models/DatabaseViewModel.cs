﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using MegaCinemaModel.Models;

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

    #region TamPhu
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
    #endregion

    #region #HoangMinh: FilmCategory, FilmFormat, FilmRating
    public class FilmViewModel
    {
        public int FilmID { get; set; }

        public string FilmPrefix { get; set; }

        public string FilmCode { get; set; }

        [DisplayName("Tên phim")]
        [Required(ErrorMessage = "Tên phim không được để trống")]
        public string FilmName { get; set; }

        [DisplayName("Thời lượng phim")]
        [Required(ErrorMessage = "Thời lượng không được để trống")]
        public int FilmDuration { get; set; }

        [DisplayName("Ngày dự định công chiếu phim")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày công chiếu không được để trống")]
        public DateTime FilmFirstPremiered { get; set; }

        [DisplayName("Ngôn ngữ hỗ trợ")]
        [Required(ErrorMessage = "Ngôn ngữ không được để trống")]
        public string FilmLanguage { get; set; }

        [DisplayName("Nội dung sơ lược của phim")]
        [Required(ErrorMessage = "Nội dung phim không được để trống")]
        public string FilmContent { get; set; }

        [DisplayName("Ngày dự định kết thúc phim")]
        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Ngày chiếu cuối cùng không được để trống")]
        public DateTime? FilmFinishPremiered { get; set; }

        [DisplayName("Poster phim")]
        //[Required(ErrorMessage = "Poster phim không được để trống")]
        public string FilmPoster { get; set; }

        [DisplayName("Thể loại phim")]
        public string FilmCategories { get; set; }

        [DisplayName("Công ty sản xuất phim")]
        [Required(ErrorMessage = "Công ty sản xuất không được để trống")]
        public string FilmCompanyRelease { get; set; }

        [DisplayName("Link trailer (youtube)")]
        public string FilmTrailer { get; set; }

        [DisplayName("Đánh giá")]
        //[Required(ErrorMessage = "Đánh giá không được để trống")]
        public int FilmRatingID { get; set; }

        [DisplayName("Trạng thái phim")]
        public string FilmStatus { get; set; }

        //Add
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

        [DisplayName("Thể loại phim")]
        [Required(ErrorMessage = "Thể loại phim không được để trống")]
        public string FilmCategoryName { get; set; }

        [DisplayName("Mô tả thể loại phim")]
        [Required(ErrorMessage = "* Không được để trống")]
        public string FilmCategoryDescrip { get; set; }

        //Add
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }

    public class FilmFormatViewModel
    {
        public int FilmFormatID { get; set; }

        [DisplayName("Định dạng phim")]
        [Required(ErrorMessage = "Tên định dạng phim không được để trống")]
        public string FilmFormatName { get; set; }

        [DisplayName("Mô tả")]
        public string FilmFormatDescrip { get; set; }

        //Add
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }

    public class FilmRatingViewModel
    {
        public int RatingID { get; set; }

        [DisplayName("Rating name")]
        [Required(ErrorMessage = "* Không được để trống")]
        public string RatingName { get; set; }

        [DisplayName("Mô tả")]
        public string RatingDescription { get; set; }

        //Add
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
    #endregion

    #region #TranVanPhuc: PromotionViewModel class, PromotionCineViewModel class
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
        public string PromotionPoster { get; set; }


        [DisplayName("Ngày bắt đầu")]
        [Required(ErrorMessage = "Ngày bắt đầu không được để trống")]
        public DateTime PromotionDateStart { get; set; }

        [DisplayName("Ngày kết thúc")]
        [Required(ErrorMessage = "Ngày kết thúc không được để trống")]
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

        [DisplayName("Trạng thái áp dụng ưu đãi cho rạp")]
        [Required(ErrorMessage = "Trạng thái áp dụng ưu đãi cho rạp không được để trống")]
        public string PromotionCineStatusID { get; set; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
    #endregion #TranVanPhuc

    #region NghiaNV
    public class CinemaFeatureViewModel
    {
        //No Display
        public int FeatureID { get; set; }

        [DisplayName("0 ảnh, - 1 nội dung")]
        [Required(ErrorMessage = "Trường dữ liệu này không được để trống")]
        public bool FeatureType { get; set; }

        [DisplayName("Nội dung")]
        [Required (ErrorMessage = "Nội dung không được để trống"), MaxLength(100)]
        public string FeatureContent { get; set; }

        [DisplayName("Mô tả")]
        [MaxLength(100)]
        public string FeatureDescription { get; set; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }

    }


    public class CinemaViewModel
    {
        public int CinemaID { get; set; }

        [DisplayName("Tiền tố rạp chiếu phim")]
        [Required(ErrorMessage = "Tiền tố không được để trống")]
        public string CinemaPrefix { get; set; }

        [DisplayName("Mã rạp")]
        public string CinemaCode { get; set; }

        [DisplayName("Tên rạp")]
        [Required (ErrorMessage = "Tên rạp không được để trống")]
        public string CinemaFullName { get; set; }

        [DisplayName("Đia chỉ")]
        [Required(ErrorMessage =  "Địa chỉ không được để trống")]
        public string CinemaAddress { get; set; }

        [DisplayName("Điện thoại")]
        [Required(ErrorMessage = "Điện thoại không được để trống")]
        public string CinemaPhone { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Email không được để trống")]
        [EmailAddress]
        public string CinemaEmail { get; set; }

        [DisplayName("Mã quản lý")]
        [Required(ErrorMessage = "Mã quản lý không được để trống")]
        public int CinemaManagerID { get; set; }

        [DisplayName("Trạng thái")]
        [Required(ErrorMessage = "Trạng thái không được để trống")]
        public string CinemaStatus { get; set; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }
    #endregion

    #region Tamphu.pn
    public class AdsBannerViewModel
    {
        public int AdsId { get; set; }
        public int FilmId { get; set; }
        public string AdsDescription { get; set; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }

    public class EventTopicViewModel
    {
        public int EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventContent { get; set; }
        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdatedDate { set; get; }
        public string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
    }

    public class FilmCalendarCreateViewModel
    {
        public int FilmCalendarCreateID { get; set; }
        public int FilmSessionID { get; set; }
        public int StaffID { get; set; }
        public string FilmCalendarContent { get; set; }
        public string FilmCalendarDescription { get; set; }
        public string StatusID { get; set; }
    }

    public class TimeSessionViewModel
    {
        public int TimeSessionID { get; set; }
        public string TimeDetail { get; set; }
        public string SeatTableState { get; set; }
        public string SeatTableDefault { get; set; }
    }
    public class RoomFilmDetailViewModel
    {
        [DisplayName("Tên phòng chiếu")]
        [Required(ErrorMessage = "Tên phòng chiếu không được để trống")]
        public string RoomName { get; set; }

        public string RoomSeatPosition { get; set; }

        [DisplayName("Mô tả sơ qua phòng chiếu")]
        public string RoomCinemaDescription { get; set; }

        public string RoomPoster { get; set; }

        [DisplayName("Rạp chiếu phim")]
        [Required(ErrorMessage = "Rạp chiếu phim không được để trống")]
        public int RoomCinemaID { get; set; }

        [DisplayName("Trạng thái cho phòng chiếu")]
        public string RoomStatusID { get; set; }

        [DisplayName("Diện tích ghế - số ghế chiều ngang")]
        [Required(ErrorMessage = "Diện tích ghế - số ghế chiều ngang không được để trống")]
        public int Width { get; set; }

        [DisplayName("Diện tích ghế - số ghế chiều dọc")]
        [Required(ErrorMessage = "Diện tích ghế - số ghế chiều dọc không được để trống")]
        public int Height { get; set; }

        [DisplayName("Số lượng ghế Vip")]
        [Required(ErrorMessage = "Số lượng ghế vip không được để trống")]
        public int VipTicket { get; set; }

        [DisplayName("Số lượng ghế thường")]
        [Required(ErrorMessage = "Số lượng ghế thường không được để trống")]
        public int SimpleTicket { get; set; }
    }

    public class BookingTicketViewModel
    {
        public int BookingTicketID { get; set; }
        public string BookingTicketPrefix { get; set; }
        public string BookingTicketCode { get; set; }
        public int BookingTicketFilmID { get; set; }
        public int BookingTicketRoomID { get; set; }
        public string BookingTicketTimeDetail { get; set; }
        public decimal BookingTicketPrice { get; set; }
        public DateTime BookingPaymentDate { get; set; }
        public int? CustomerID { get; set; }
        public string BookingTicketStatusID { get; set; }
    }
    #endregion 
}