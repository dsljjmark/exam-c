using System;
using System.Collections.Generic;
using Exam.Models;
using Microsoft.EntityFrameworkCore;

namespace Exam.Context
{
    public class ExamContext : DbContext
    {
        public ExamContext(DbContextOptions<ExamContext> options)
            : base(options)
        { }

       
        public virtual DbSet<Properties> Properties { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Properties>(entity =>
            {
                entity.HasKey(e => e.UniqId);

                entity.ToTable("properties");

                entity.Property(e => e.UniqId)
                    .HasColumnName("uniq_id")
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AdditionalInfo)
                    .IsRequired()
                    .HasColumnName("additional_info")
                    .HasMaxLength(422)
                    .IsUnicode(false);

                entity.Property(e => e.Amenities)
                    .HasColumnName("amenities")
                    .HasMaxLength(149)
                    .IsUnicode(false);

                entity.Property(e => e.CheckInDate)
                    .HasColumnName("check_in_date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckOutDate)
                    .HasColumnName("check_out_date")
                    .HasColumnType("date");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(28)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CrawlDate)
                    .HasColumnName("crawl_date")
                    .HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(4131)
                    .IsUnicode(false);

                entity.Property(e => e.HighlightValue)
                    .HasColumnName("highlight_value")
                    .HasMaxLength(1024)
                    .IsUnicode(false);

                entity.Property(e => e.HotelStarRating).HasColumnName("hotel_star_rating");

                entity.Property(e => e.ImageCount).HasColumnName("image_count");

                entity.Property(e => e.ImageUrls)
                    .HasColumnName("image_urls")
                    .HasMaxLength(7190)
                    .IsUnicode(false);

                entity.Property(e => e.Internet)
                    .HasColumnName("internet")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Landmark)
                    .HasColumnName("landmark")
                    .HasMaxLength(134)
                    .IsUnicode(false);

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasColumnType("numeric(30, 7)");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasColumnType("numeric(30, 7)");

                entity.Property(e => e.Occupancy)
                    .HasColumnName("occupancy")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Pageurl)
                    .IsRequired()
                    .HasColumnName("pageurl")
                    .HasMaxLength(155)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyAddress)
                    .IsRequired()
                    .HasColumnName("property_address")
                    .HasMaxLength(83)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyId).HasColumnName("property_id");

                entity.Property(e => e.PropertyName)
                    .IsRequired()
                    .HasColumnName("property_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .IsRequired()
                    .HasColumnName("property_type")
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Qts)
                    .HasColumnName("qts")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.QueryTimeStamp)
                    .IsRequired()
                    .HasColumnName("query_time_stamp")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RoomPrice)
                    .HasColumnName("room_price")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.RoomTypes)
                    .IsRequired()
                    .HasColumnName("room_types")
                    .HasMaxLength(407)
                    .IsUnicode(false);

                entity.Property(e => e.SearchTerm)
                    .HasColumnName("search_term")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceValue)
                    .HasColumnName("service_value")
                    .HasMaxLength(81)
                    .IsUnicode(false);

                entity.Property(e => e.SimilarHotel)
                    .HasColumnName("similar_hotel")
                    .HasMaxLength(121)
                    .IsUnicode(false);

                entity.Property(e => e.Sitename)
                    .IsRequired()
                    .HasColumnName("sitename")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.ThingsToDo)
                    .HasColumnName("things_to_do")
                    .HasMaxLength(46)
                    .IsUnicode(false);

                entity.Property(e => e.ThingsToNote)
                    .HasColumnName("things_to_note")
                    .HasMaxLength(1017)
                    .IsUnicode(false);
            });
        }
    }
  

}
