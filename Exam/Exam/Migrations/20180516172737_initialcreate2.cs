using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Exam.Migrations
{
    public partial class initialcreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "properties",
                columns: table => new
                {
                    uniq_id = table.Column<string>(unicode: false, maxLength: 32, nullable: false),
                    additional_info = table.Column<string>(unicode: false, maxLength: 422, nullable: false),
                    amenities = table.Column<string>(unicode: false, maxLength: 149, nullable: true),
                    check_in_date = table.Column<DateTime>(type: "date", nullable: false),
                    check_out_date = table.Column<DateTime>(type: "date", nullable: false),
                    city = table.Column<string>(unicode: false, maxLength: 28, nullable: false),
                    country = table.Column<string>(unicode: false, maxLength: 5, nullable: true),
                    crawl_date = table.Column<DateTime>(type: "date", nullable: true),
                    description = table.Column<string>(unicode: false, maxLength: 4131, nullable: true),
                    highlight_value = table.Column<string>(unicode: false, maxLength: 1024, nullable: true),
                    hotel_star_rating = table.Column<int>(nullable: true),
                    image_count = table.Column<int>(nullable: true),
                    image_urls = table.Column<string>(unicode: false, maxLength: 7190, nullable: true),
                    internet = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    landmark = table.Column<string>(unicode: false, maxLength: 134, nullable: true),
                    latitude = table.Column<decimal>(type: "numeric(30, 7)", nullable: false),
                    longitude = table.Column<decimal>(type: "numeric(30, 7)", nullable: false),
                    occupancy = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    pageurl = table.Column<string>(unicode: false, maxLength: 155, nullable: false),
                    property_address = table.Column<string>(unicode: false, maxLength: 83, nullable: false),
                    property_id = table.Column<int>(nullable: false),
                    property_name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    property_type = table.Column<string>(unicode: false, maxLength: 9, nullable: false),
                    qts = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    query_time_stamp = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    room_price = table.Column<string>(unicode: false, maxLength: 25, nullable: true),
                    room_types = table.Column<string>(unicode: false, maxLength: 407, nullable: false),
                    search_term = table.Column<string>(unicode: false, maxLength: 16, nullable: true),
                    service_value = table.Column<string>(unicode: false, maxLength: 81, nullable: true),
                    similar_hotel = table.Column<string>(unicode: false, maxLength: 121, nullable: true),
                    sitename = table.Column<string>(unicode: false, maxLength: 17, nullable: false),
                    things_to_do = table.Column<string>(unicode: false, maxLength: 46, nullable: true),
                    things_to_note = table.Column<string>(unicode: false, maxLength: 1017, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_properties", x => x.uniq_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "properties");
        }
    }
}
