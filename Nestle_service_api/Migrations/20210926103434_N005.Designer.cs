﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nestle_service_api.Context;

namespace Nestle_service_api.Migrations
{
    [DbContext(typeof(Nestle_Connect))]
    [Migration("20210926103434_N005")]
    partial class N005
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nestle_service_api.Model.tb_RegisterDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Chocolate")
                        .HasColumnType("bit");

                    b.Property<bool>("Facebook")
                        .HasColumnType("bit");

                    b.Property<bool>("Follow_news")
                        .HasColumnType("bit");

                    b.Property<bool>("Instagram")
                        .HasColumnType("bit");

                    b.Property<bool>("Line")
                        .HasColumnType("bit");

                    b.Property<bool>("Maggi")
                        .HasColumnType("bit");

                    b.Property<bool>("Milo")
                        .HasColumnType("bit");

                    b.Property<bool>("Nescafe")
                        .HasColumnType("bit");

                    b.Property<bool>("Nestea")
                        .HasColumnType("bit");

                    b.Property<bool>("Post_picture")
                        .HasColumnType("bit");

                    b.Property<bool>("Post_video")
                        .HasColumnType("bit");

                    b.Property<bool>("React")
                        .HasColumnType("bit");

                    b.Property<bool>("Tiktok")
                        .HasColumnType("bit");

                    b.Property<bool>("Twitter")
                        .HasColumnType("bit");

                    b.Property<bool>("Youtube")
                        .HasColumnType("bit");

                    b.Property<string>("age_range_adults1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age_range_adults9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("cereal")
                        .HasColumnType("bit");

                    b.Property<bool>("cereal_children")
                        .HasColumnType("bit");

                    b.Property<string>("children")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("children_birthday9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("coffee_mate")
                        .HasColumnType("bit");

                    b.Property<bool>("convenience_store")
                        .HasColumnType("bit");

                    b.Property<bool>("entrepreneurs")
                        .HasColumnType("bit");

                    b.Property<string>("family_income")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("family_members")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("food_supplement")
                        .HasColumnType("bit");

                    b.Property<string>("frequency_social")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("general_store")
                        .HasColumnType("bit");

                    b.Property<bool>("grains")
                        .HasColumnType("bit");

                    b.Property<bool>("ice_cream")
                        .HasColumnType("bit");

                    b.Property<string>("id_master")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_don_coffee")
                        .HasColumnType("bit");

                    b.Property<bool>("is_feel_happy")
                        .HasColumnType("bit");

                    b.Property<bool>("is_health")
                        .HasColumnType("bit");

                    b.Property<bool>("is_love_coffee")
                        .HasColumnType("bit");

                    b.Property<bool>("is_nutrition")
                        .HasColumnType("bit");

                    b.Property<string>("isexpenses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("medical_food")
                        .HasColumnType("bit");

                    b.Property<bool>("milk_powder")
                        .HasColumnType("bit");

                    b.Property<string>("number_adults")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("number_pets")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("objective_other")
                        .HasColumnType("bit");

                    b.Property<bool>("online_channel")
                        .HasColumnType("bit");

                    b.Property<bool>("pet_products")
                        .HasColumnType("bit");

                    b.Property<string>("pet_type1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_type9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year10")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year3")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year4")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year5")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year6")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year7")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year8")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pet_year9")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("purchase_other")
                        .HasColumnType("bit");

                    b.Property<string>("purchase_others")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("social_other")
                        .HasColumnType("bit");

                    b.Property<bool>("supermarket")
                        .HasColumnType("bit");

                    b.Property<bool>("water")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("tb_RegisterDetail");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_RegisterHeading", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("OTP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RefID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("datesave")
                        .HasColumnType("datetime2");

                    b.Property<string>("district_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("house_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("id_master")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("isstatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lastname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number_of_calls")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("province_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("road")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sex")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sub_district_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("swine")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("village")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zip_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_RegisterHeading");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_age_range", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("age_range")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_age_range");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_animal_type", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("pet_type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_animal_type");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_district", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("district_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("province_id")
                        .HasColumnType("int");

                    b.Property<string>("pvnc_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_district");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_inbound_case", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("case_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("case_open_time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_channel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("inbound_call_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("number_of_calls")
                        .HasColumnType("int");

                    b.Property<string>("service_group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("service_requst_verbatim")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("service_type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("solution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sratus_case")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("surname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_inbound_case");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_logs_inbound", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("aqent_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("case_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("number_of_repeat")
                        .HasColumnType("int");

                    b.Property<string>("status_of_case")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status_of_contact")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_logs_inbound");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_logs_outbound", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("aqent_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("case_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create_date")
                        .HasColumnType("datetime2");

                    b.Property<int>("number_of_repeat")
                        .HasColumnType("int");

                    b.Property<string>("status_of_case")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status_of_contact")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_logs_outbound");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_master_link", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("create_link_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("create_send")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("customer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("random_numbe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_master_link");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_members", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("member")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("tb_members");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_outbound_frist_call", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("callback_customer_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("case_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consurmer_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consurmer_surmer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discount_code_exp_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discount_code_for")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("interested_brand_ambassador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ob_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ob_time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner_mobile_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tellscore_registration_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("use_discount_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_outbound_frist_call");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_outbound_second_call", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("case_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consurmer_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consurmer_surmer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("interested_brand_ambassador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ob_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ob_time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner_mobile_number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("reasons_register")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("regietered_yet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tellscore_registration_status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_outbound_second_call");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_outbound_telesale", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("consurmer_group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consurmer_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("consurmer_surmer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discountcode_exp_date")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("discountcode_sending_status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ob_date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ob_time")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner_mobile_number")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("tb_outbound_telesale");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_province", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("province_name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_province");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_sex", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("sexs")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_sexs");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_sub_district", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("district_id")
                        .HasColumnType("int");

                    b.Property<string>("district_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sub_district_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zip_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_sub_district");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_title", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("sex_title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_title");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_user_login", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("password_")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("project_id")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("user_")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_user_login");
                });

            modelBuilder.Entity("Nestle_service_api.Model.tb_zip_code", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("sub_district_id")
                        .HasColumnType("int");

                    b.Property<string>("sub_district_name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("zip_code")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("tb_zip_code");
                });
#pragma warning restore 612, 618
        }
    }
}
