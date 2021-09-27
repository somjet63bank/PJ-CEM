using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nestle_service_api.Migrations
{
    public partial class N006 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_outbound_frist_call");

            migrationBuilder.CreateTable(
                name: "tb_outbound_first_call",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ob_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ob_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consurmer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consurmer_surmer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner_mobile_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    callback_customer_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    use_discount_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    discount_code_for = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    discount_code_exp_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    interested_brand_ambassador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tellscore_registration_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    case_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_outbound_first_call", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_outbound_first_call");

            migrationBuilder.CreateTable(
                name: "tb_outbound_frist_call",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    callback_customer_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    case_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consurmer_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    consurmer_surmer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    discount_code_exp_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    discount_code_for = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    interested_brand_ambassador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ob_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ob_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    owner_mobile_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tellscore_registration_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    use_discount_code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_outbound_frist_call", x => x.Id);
                });
        }
    }
}
