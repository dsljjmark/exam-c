using System;
using System.Collections.Generic;
using GeoCoordinatePortable;

namespace Exam.ViewModels
{
    public class PropertyViewModel
    {
        public string uniq_Id {get ;set ;}
        public string property_type { get; set; }
        public string City { get; set; }
        public string amenities { get; set; }
        public string room_price_min { get; set; }
        public string room_price_max { get; set; }
        public string Location { get; set; }
        public string radius { get; set; }
    }
    public class SearchPropertyViewModel
    {
        public string uniq_Id { get; set; }
        public string property_type { get; set; }
        public string City { get; set; }
        public List<string> amenities { get; set; }
        public string room_price { get; set; }
        public string Location { get; set; }
        public double? radius { get; set; }
    }
    public class PropertyResult
    {
        public string AdditionalInfo { get; set; }
        public string Amenities { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime? CrawlDate { get; set; }
        public string Description { get; set; }
        public string HighlightValue { get; set; }
        public int? HotelStarRating { get; set; }
        public int? ImageCount { get; set; }
        public string ImageUrls { get; set; }
        public string Internet { get; set; }
        public string Landmark { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
        public string Occupancy { get; set; }
        public string Pageurl { get; set; }
        public string PropertyAddress { get; set; }
        public int PropertyId { get; set; }
        public string PropertyName { get; set; }
        public string PropertyType { get; set; }
        public string Qts { get; set; }
        public string QueryTimeStamp { get; set; }
        public string RoomPrice { get; set; }
        public string RoomTypes { get; set; }
        public string SearchTerm { get; set; }
        public string ServiceValue { get; set; }
        public string SimilarHotel { get; set; }
        public string Sitename { get; set; }
        public string ThingsToDo { get; set; }
        public string ThingsToNote { get; set; }
        public string UniqId { get; set; }
        public double CustomRoomPirce { get; set; }
        public GeoCoordinate Point { get; set; }
        public double area { get; set; }
    }

    public class PaginatedItemsViewModel<TEntity> where TEntity : class
    {
        public int ActualPage { get; private set; }

        public int ItemsPerPage { get; private set; }

        public long TotalItems { get; private set; }

        public int TotalPages { get; set; }

        public IEnumerable<TEntity> Data { get; private set; }

        public PaginatedItemsViewModel(int pageIndex, int pageSize, long count, IEnumerable<TEntity> data)
        {
            ActualPage = pageIndex;
            ItemsPerPage = pageSize;
            TotalItems = count;
            TotalPages = (int)Math.Ceiling(((decimal)count / pageSize));
            Data = data;
        }
    }

    public class ResultItemsViewModel<TEntity> where TEntity : class
    {
        public long TotalItems { get; private set; }

        public IEnumerable<TEntity> Data { get; private set; }

        public ResultItemsViewModel(long count, IEnumerable<TEntity> data)
        {
            TotalItems = count;
            Data = data;
        }
    }

}
