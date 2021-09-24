using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nestle_service_api.Migrations
{
    public partial class N001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tb_age_range",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    age_range = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_age_range", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_animal_type",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    pet_type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_animal_type", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_district",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    province_id = table.Column<int>(type: "int", nullable: false),
                    pvnc_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    district_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_district", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_master_link",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    customer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_send = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_link_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    random_numbe = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_master_link", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_members",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    member = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_members", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_province",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    province_name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_province", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_RegisterDetail",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_master = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Nescafe = table.Column<bool>(type: "bit", nullable: false),
                    food_supplement = table.Column<bool>(type: "bit", nullable: false),
                    coffee_mate = table.Column<bool>(type: "bit", nullable: false),
                    milk_powder = table.Column<bool>(type: "bit", nullable: false),
                    Nestea = table.Column<bool>(type: "bit", nullable: false),
                    Milo = table.Column<bool>(type: "bit", nullable: false),
                    Chocolate = table.Column<bool>(type: "bit", nullable: false),
                    grains = table.Column<bool>(type: "bit", nullable: false),
                    medical_food = table.Column<bool>(type: "bit", nullable: false),
                    water = table.Column<bool>(type: "bit", nullable: false),
                    entrepreneurs = table.Column<bool>(type: "bit", nullable: false),
                    Maggi = table.Column<bool>(type: "bit", nullable: false),
                    pet_products = table.Column<bool>(type: "bit", nullable: false),
                    cereal = table.Column<bool>(type: "bit", nullable: false),
                    ice_cream = table.Column<bool>(type: "bit", nullable: false),
                    cereal_children = table.Column<bool>(type: "bit", nullable: false),
                    is_nutrition = table.Column<bool>(type: "bit", nullable: false),
                    is_health = table.Column<bool>(type: "bit", nullable: false),
                    is_feel_happy = table.Column<bool>(type: "bit", nullable: false),
                    is_love_coffee = table.Column<bool>(type: "bit", nullable: false),
                    is_don_coffee = table.Column<bool>(type: "bit", nullable: false),
                    Facebook = table.Column<bool>(type: "bit", nullable: false),
                    Line = table.Column<bool>(type: "bit", nullable: false),
                    Twitter = table.Column<bool>(type: "bit", nullable: false),
                    Youtube = table.Column<bool>(type: "bit", nullable: false),
                    Instagram = table.Column<bool>(type: "bit", nullable: false),
                    Tiktok = table.Column<bool>(type: "bit", nullable: false),
                    social_other = table.Column<bool>(type: "bit", nullable: false),
                    frequency_social = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Follow_news = table.Column<bool>(type: "bit", nullable: false),
                    React = table.Column<bool>(type: "bit", nullable: false),
                    Post_picture = table.Column<bool>(type: "bit", nullable: false),
                    Post_video = table.Column<bool>(type: "bit", nullable: false),
                    objective_other = table.Column<bool>(type: "bit", nullable: false),
                    general_store = table.Column<bool>(type: "bit", nullable: false),
                    convenience_store = table.Column<bool>(type: "bit", nullable: false),
                    supermarket = table.Column<bool>(type: "bit", nullable: false),
                    online_channel = table.Column<bool>(type: "bit", nullable: false),
                    purchase_other = table.Column<bool>(type: "bit", nullable: false),
                    purchase_others = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isexpenses = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    family_income = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    family_members = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    children_birthday10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    number_adults = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age_range_adults10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    number_pets = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_type10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    pet_year10 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_RegisterDetail", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_RegisterHeading",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    id_master = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    lastname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    facebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    house_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    village = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    swine = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    road = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sub_district_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    district_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    province_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zip_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OTP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    isstatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    datesave = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefID = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_RegisterHeading", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_sexs",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sexs = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_sexs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_sub_district",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    district_id = table.Column<int>(type: "int", nullable: false),
                    district_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sub_district_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zip_code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_sub_district", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_title",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sex_title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_title", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_user_login",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    user_ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    password_ = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    project_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_user_login", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_zip_code",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sub_district_id = table.Column<int>(type: "int", nullable: false),
                    sub_district_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    zip_code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_zip_code", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_age_range");

            migrationBuilder.DropTable(
                name: "tb_animal_type");

            migrationBuilder.DropTable(
                name: "tb_district");

            migrationBuilder.DropTable(
                name: "tb_master_link");

            migrationBuilder.DropTable(
                name: "tb_members");

            migrationBuilder.DropTable(
                name: "tb_province");

            migrationBuilder.DropTable(
                name: "tb_RegisterDetail");

            migrationBuilder.DropTable(
                name: "tb_RegisterHeading");

            migrationBuilder.DropTable(
                name: "tb_sexs");

            migrationBuilder.DropTable(
                name: "tb_sub_district");

            migrationBuilder.DropTable(
                name: "tb_title");

            migrationBuilder.DropTable(
                name: "tb_user_login");

            migrationBuilder.DropTable(
                name: "tb_zip_code");
        }
    }
}
