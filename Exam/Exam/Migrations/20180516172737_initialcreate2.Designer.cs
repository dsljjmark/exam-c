﻿// <auto-generated />
using Exam.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Exam.Migrations
{
    [DbContext(typeof(ExamContext))]
    [Migration("20180516172737_initialcreate2")]
    partial class initialcreate2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Exam.Models.Properties", b =>
                {
                    b.Property<string>("UniqId")
                        .HasColumnName("uniq_id")
                        .HasMaxLength(32)
                        .IsUnicode(false);

                    b.Property<string>("AdditionalInfo")
                        .IsRequired()
                        .HasColumnName("additional_info")
                        .HasMaxLength(422)
                        .IsUnicode(false);

                    b.Property<string>("Amenities")
                        .HasColumnName("amenities")
                        .HasMaxLength(149)
                        .IsUnicode(false);

                    b.Property<DateTime>("CheckInDate")
                        .HasColumnName("check_in_date")
                        .HasColumnType("date");

                    b.Property<DateTime>("CheckOutDate")
                        .HasColumnName("check_out_date")
                        .HasColumnType("date");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnName("city")
                        .HasMaxLength(28)
                        .IsUnicode(false);

                    b.Property<string>("Country")
                        .HasColumnName("country")
                        .HasMaxLength(5)
                        .IsUnicode(false);

                    b.Property<DateTime?>("CrawlDate")
                        .HasColumnName("crawl_date")
                        .HasColumnType("date");

                    b.Property<string>("Description")
                        .HasColumnName("description")
                        .HasMaxLength(4131)
                        .IsUnicode(false);

                    b.Property<string>("HighlightValue")
                        .HasColumnName("highlight_value")
                        .HasMaxLength(1024)
                        .IsUnicode(false);

                    b.Property<int?>("HotelStarRating")
                        .HasColumnName("hotel_star_rating");

                    b.Property<int?>("ImageCount")
                        .HasColumnName("image_count");

                    b.Property<string>("ImageUrls")
                        .HasColumnName("image_urls")
                        .HasMaxLength(7190)
                        .IsUnicode(false);

                    b.Property<string>("Internet")
                        .HasColumnName("internet")
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<string>("Landmark")
                        .HasColumnName("landmark")
                        .HasMaxLength(134)
                        .IsUnicode(false);

                    b.Property<decimal>("Latitude")
                        .HasColumnName("latitude")
                        .HasColumnType("numeric(30, 7)");

                    b.Property<decimal>("Longitude")
                        .HasColumnName("longitude")
                        .HasColumnType("numeric(30, 7)");

                    b.Property<string>("Occupancy")
                        .HasColumnName("occupancy")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("Pageurl")
                        .IsRequired()
                        .HasColumnName("pageurl")
                        .HasMaxLength(155)
                        .IsUnicode(false);

                    b.Property<string>("PropertyAddress")
                        .IsRequired()
                        .HasColumnName("property_address")
                        .HasMaxLength(83)
                        .IsUnicode(false);

                    b.Property<int>("PropertyId")
                        .HasColumnName("property_id");

                    b.Property<string>("PropertyName")
                        .IsRequired()
                        .HasColumnName("property_name")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("PropertyType")
                        .IsRequired()
                        .HasColumnName("property_type")
                        .HasMaxLength(9)
                        .IsUnicode(false);

                    b.Property<string>("Qts")
                        .HasColumnName("qts")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("QueryTimeStamp")
                        .IsRequired()
                        .HasColumnName("query_time_stamp")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("RoomPrice")
                        .HasColumnName("room_price")
                        .HasMaxLength(25)
                        .IsUnicode(false);

                    b.Property<string>("RoomTypes")
                        .IsRequired()
                        .HasColumnName("room_types")
                        .HasMaxLength(407)
                        .IsUnicode(false);

                    b.Property<string>("SearchTerm")
                        .HasColumnName("search_term")
                        .HasMaxLength(16)
                        .IsUnicode(false);

                    b.Property<string>("ServiceValue")
                        .HasColumnName("service_value")
                        .HasMaxLength(81)
                        .IsUnicode(false);

                    b.Property<string>("SimilarHotel")
                        .HasColumnName("similar_hotel")
                        .HasMaxLength(121)
                        .IsUnicode(false);

                    b.Property<string>("Sitename")
                        .IsRequired()
                        .HasColumnName("sitename")
                        .HasMaxLength(17)
                        .IsUnicode(false);

                    b.Property<string>("ThingsToDo")
                        .HasColumnName("things_to_do")
                        .HasMaxLength(46)
                        .IsUnicode(false);

                    b.Property<string>("ThingsToNote")
                        .HasColumnName("things_to_note")
                        .HasMaxLength(1017)
                        .IsUnicode(false);

                    b.HasKey("UniqId");

                    b.ToTable("properties");
                });
#pragma warning restore 612, 618
        }
    }
}