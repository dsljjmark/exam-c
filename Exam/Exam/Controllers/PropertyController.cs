using System;
using System.Collections.Generic;
using System.Linq;
using Exam.Context;
using Exam.Models;
using Exam.ViewModels;
using GeoCoordinatePortable;
using Microsoft.AspNetCore.Mvc;


namespace Exam.Controllers
{
    [Produces("application/json")]
    [Route("api/property")]
    public class PropertyController : Controller
    {
        private readonly ExamContext _examContext;
        public PropertyController(ExamContext examContext)
        {
            _examContext = examContext;
        }
      
        [HttpGet]
        [Route("[action]")]
        public IActionResult GetAll()
        {
            try
            {
                var result = _examContext.Properties.ToList();
                var model = new ResultItemsViewModel<Properties>(result.Count, result);
                return Ok(model);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        [HttpGet]
        [Route("[action]")]
        public IActionResult Search(SearchPropertyViewModel input)
        {
            try
            {
                var query = (IQueryable<Properties>)_examContext.Properties;

                if (input.uniq_Id != null && input.uniq_Id != String.Empty)
                {
                    query = query.Where(d => d.UniqId == input.uniq_Id);
                }

                if (input.property_type != null && input.property_type != String.Empty)
                {
                    query = query.Where(d => d.PropertyType == input.property_type);
                }

                if (input.City != null && input.City != String.Empty)
                {
                    query = query.Where(d => d.City == input.City);
                }

                if (input.amenities != null && input.amenities.Count > 0)
                {
                    foreach(var amenitie in input.amenities)
                    {
                        query = query.Where(d => d.Amenities.Contains(amenitie));
                    }
                }

                var datas = query
                    .ToList()
                    .Select(f => new PropertyResult()
                    {
                        AdditionalInfo = f.AdditionalInfo,
                        Amenities = f.Amenities,
                        CheckInDate = f.CheckInDate,
                        CheckOutDate = f.CheckOutDate,
                        City = f.City,
                        Country = f.Country,
                        CrawlDate = f.CrawlDate,
                        Description = f.Description,
                        HighlightValue = f.HighlightValue,
                        HotelStarRating = f.HotelStarRating,
                        ImageCount = f.ImageCount,
                        ImageUrls = f.ImageUrls,
                        Internet = f.Internet,
                        Landmark = f.Landmark,
                        Latitude = f.Latitude,
                        Longitude = f.Longitude,
                        Occupancy = f.Occupancy,
                        Pageurl = f.Pageurl,
                        PropertyAddress = f.PropertyAddress,
                        PropertyId = f.PropertyId,
                        PropertyName = f.PropertyName,
                        PropertyType = f.PropertyType,
                        Qts = f.Qts,
                        QueryTimeStamp = f.QueryTimeStamp,
                        RoomPrice = f.RoomPrice,
                        RoomTypes = f.RoomTypes,
                        SearchTerm = f.SearchTerm,
                        ServiceValue = f.ServiceValue,
                        SimilarHotel = f.SimilarHotel,
                        Sitename = f.Sitename,
                        ThingsToDo = f.ThingsToDo,
                        ThingsToNote = f.ThingsToNote,
                        UniqId = f.UniqId,
                        CustomRoomPirce = Convert.ToDouble(f.RoomPrice.Split("per night incl. tax")[0]),
                        Point = new GeoCoordinate(Convert.ToDouble(f.Latitude), Convert.ToDouble(f.Longitude)),
                        area = 0
                    }).ToList();

                if (input.room_price != null && input.room_price != String.Empty)
                {
                    if (FindTextInSTR(input.room_price, "-"))
                    {
                        string[] splitString = input.room_price.Split("-");
                        double minPrice = Convert.ToDouble(splitString[0]);
                        double maxPrice = Convert.ToDouble(splitString[1]);
                        datas = datas.Where(o => o.CustomRoomPirce >= minPrice && o.CustomRoomPirce <= maxPrice).ToList();
                    }
                }

                if ((input.Location != null && input.Location != String.Empty) && (input.radius != null))
                {
                    if(FindTextInSTR(input.Location,","))
                    {
                        string[] splitString = input.Location.Split(",");
                        double latitude = Convert.ToDouble(splitString[0]);
                        double longitude = Convert.ToDouble(splitString[1]);
                        GeoCoordinate center = new GeoCoordinate(latitude, longitude);
                        foreach (var data in datas)
                        {
                            data.area = data.Point.GetDistanceTo(center);
                        }

                        datas = datas.Where(f => f.area <= input.radius).ToList();
                    }
                }

                var model = new ResultItemsViewModel<PropertyResult>(datas.Count, datas);

                return Ok(model);
            }
            catch (Exception ex)
            {
                throw new Exception (ex.Message);
            }
           
        }

        private Boolean FindTextInSTR(string t1,string t2)
        {
            var result = t1.Contains(t2);
            return result;
        }
       
    }
}
