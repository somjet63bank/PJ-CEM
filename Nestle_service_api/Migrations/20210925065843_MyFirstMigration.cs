using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Nestle_service_api.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "number_of_calls",
                table: "tb_RegisterHeading",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "tb_inbound_case",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    inbound_call_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    case_open_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    case_id = table.Column<int>(type: "int", nullable: false),
                    contact_channel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    contact_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_requst_verbatim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    solution = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    sratus_case = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_inbound_case", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_logs_inbound",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    case_id = table.Column<int>(type: "int", nullable: false),
                    aqent_id = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    number = table.Column<int>(type: "int", nullable: false),
                    status_of_case = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_of_contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_logs_inbound", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_logs_outbound",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    case_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    aqent_id = table.Column<int>(type: "int", nullable: false),
                    create_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    number = table.Column<int>(type: "int", nullable: false),
                    status_of_case = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    status_of_contact = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_logs_outbound", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_outbound_frist_call",
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
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_outbound_frist_call", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_outbound_second_call",
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
                    regietered_yet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    interested_brand_ambassador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    reasons_register = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tellscore_registration_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_outbound_second_call", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tb_outbound_telesale",
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
                    consurmer_group = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    discountcode_exp_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    discountcode_sending_status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tb_outbound_telesale", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tb_inbound_case");

            migrationBuilder.DropTable(
                name: "tb_logs_inbound");

            migrationBuilder.DropTable(
                name: "tb_logs_outbound");

            migrationBuilder.DropTable(
                name: "tb_outbound_frist_call");

            migrationBuilder.DropTable(
                name: "tb_outbound_second_call");

            migrationBuilder.DropTable(
                name: "tb_outbound_telesale");

            migrationBuilder.DropColumn(
                name: "number_of_calls",
                table: "tb_RegisterHeading");
        }
    }
}
