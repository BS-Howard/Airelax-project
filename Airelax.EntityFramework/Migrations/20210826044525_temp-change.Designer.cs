﻿// <auto-generated />
using System;
using Airelax.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Airelax.EntityFramework.Migrations
{
    [DbContext(typeof(AirelaxContext))]
    [Migration("20210826044525_temp-change")]
    partial class tempchange
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Airelax.Domain.Comments.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("CommentTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Content")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("HouseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("LastModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("OrderId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ReceiverId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("HouseId");

                    b.HasIndex("OrderId")
                        .IsUnique()
                        .HasFilter("[OrderId] IS NOT NULL");

                    b.HasIndex("ReceiverId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("Airelax.Domain.Comments.Star", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccuracyScore")
                        .HasColumnType("int");

                    b.Property<int>("CheapScore")
                        .HasColumnType("int");

                    b.Property<int>("CleanScore")
                        .HasColumnType("int");

                    b.Property<int>("CommunicationScore")
                        .HasColumnType("int");

                    b.Property<int>("ExperienceScore")
                        .HasColumnType("int");

                    b.Property<int>("LocationScore")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Stars");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.BedroomDetail", b =>
                {
                    b.Property<string>("Temp")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("BedCount")
                        .HasColumnType("int");

                    b.Property<int>("BedType")
                        .HasColumnType("int");

                    b.Property<bool>("HasIndependentBath")
                        .HasColumnType("bit");

                    b.Property<string>("SpaceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Temp");

                    b.HasIndex("SpaceId");

                    b.ToTable("BedroomDetails");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.House", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CreateState")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerNumber")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotProvideFacilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OwnerId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProvideFacilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ReservationDates")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Houses");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.HouseCategory", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int?>("HouseType")
                        .HasColumnType("int");

                    b.Property<int?>("RoomCategory")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("HouseCategories");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.HouseDescription", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("GuestPermission")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int?>("HouseHighlight")
                        .HasColumnType("int");

                    b.Property<string>("Others")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("SpaceDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("HouseDescriptions");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.HouseLocation", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressDetail")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("Latitude")
                        .HasColumnType("float");

                    b.Property<string>("LocationDescription")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<double?>("Longitude")
                        .HasColumnType("float");

                    b.Property<string>("Town")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("TrafficDescription")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("ZipCode")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Id");

                    b.ToTable("HouseLocations");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.HouseRule", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool?>("AllowBaby")
                        .HasColumnType("bit");

                    b.Property<bool?>("AllowChild")
                        .HasColumnType("bit");

                    b.Property<bool?>("AllowParty")
                        .HasColumnType("bit");

                    b.Property<bool?>("AllowPet")
                        .HasColumnType("bit");

                    b.Property<bool?>("AllowSmoke")
                        .HasColumnType("bit");

                    b.Property<string>("Other")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.HasKey("Id");

                    b.ToTable("HouseRules");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Photo", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("HouseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<byte[]>("Image")
                        .IsRequired()
                        .HasColumnType("image");

                    b.Property<string>("SpaceId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.HasIndex("SpaceId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Policy", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("CanRealTime")
                        .HasColumnType("bit");

                    b.Property<int>("CancelPolicy")
                        .HasColumnType("int");

                    b.Property<decimal?>("CashPledge")
                        .HasColumnType("money");

                    b.Property<DateTime>("CheckinTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CheckoutTime")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Policies");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Price.HousePrice", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PerNight")
                        .HasColumnType("money");

                    b.Property<decimal?>("PerWeekNight")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("HousePrices");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.ReservationRule", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int?>("AvailableTime")
                        .HasColumnType("int");

                    b.Property<DateTime>("LastReservationTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MaxNight")
                        .HasColumnType("int");

                    b.Property<int>("MinNight")
                        .HasColumnType("int");

                    b.Property<int?>("PrepareTime")
                        .HasColumnType("int");

                    b.Property<int?>("RejectDate")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("ReservationRules");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Space", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HouseId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("IsShared")
                        .HasColumnType("bit");

                    b.Property<int>("SpaceType")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("HouseId");

                    b.ToTable("Spaces");
                });

            modelBuilder.Entity("Airelax.Domain.Members.EmergencyContact", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("EmergencyContact");
                });

            modelBuilder.Entity("Airelax.Domain.Members.Member", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AddressDetail")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<byte[]>("Cover")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEmailVerified")
                        .HasColumnType("bit");

                    b.Property<bool>("IsPhoneVerified")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Phone")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("RegisterTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2021, 8, 26, 12, 45, 24, 780, DateTimeKind.Local).AddTicks(5726));

                    b.Property<string>("Town")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("Airelax.Domain.Members.MemberInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("About")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("WorkTime")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MemberInfos");
                });

            modelBuilder.Entity("Airelax.Domain.Members.MemberLoginInfo", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Account")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("LoginType")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("RefreshToken")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ThirdPartyRefreshToken")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("ThirdPartyToken")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<string>("Token")
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.HasKey("Id");

                    b.ToTable("MemberLoginInfos");
                });

            modelBuilder.Entity("Airelax.Domain.Members.WishList", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<byte[]>("Cover")
                        .HasColumnType("image");

                    b.Property<string>("Houses")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("MemberId");

                    b.ToTable("WishLists");
                });

            modelBuilder.Entity("Airelax.Domain.Orders.Order", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("HouseId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("LastModifyTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("HouseId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Airelax.Domain.Orders.OrderDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Adult")
                        .HasColumnType("int");

                    b.Property<int>("Baby")
                        .HasColumnType("int");

                    b.Property<int>("Child")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("Airelax.Domain.Orders.OrderPriceDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Discount")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Fee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePerNight")
                        .HasColumnType("money");

                    b.Property<decimal>("Total")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("OrderPriceDetails");
                });

            modelBuilder.Entity("Airelax.Domain.Orders.Payment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PayState")
                        .HasColumnType("int");

                    b.Property<int>("PayType")
                        .HasColumnType("int");

                    b.Property<decimal?>("Refund")
                        .HasColumnType("money");

                    b.HasKey("Id");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Airelax.Domain.Comments.Comment", b =>
                {
                    b.HasOne("Airelax.Domain.Members.Member", null)
                        .WithMany()
                        .HasForeignKey("AuthorId");

                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithMany("Comments")
                        .HasForeignKey("HouseId");

                    b.HasOne("Airelax.Domain.Orders.Order", null)
                        .WithOne()
                        .HasForeignKey("Airelax.Domain.Comments.Comment", "OrderId");

                    b.HasOne("Airelax.Domain.Members.Member", null)
                        .WithMany()
                        .HasForeignKey("ReceiverId");
                });

            modelBuilder.Entity("Airelax.Domain.Comments.Star", b =>
                {
                    b.HasOne("Airelax.Domain.Comments.Comment", null)
                        .WithOne("Star")
                        .HasForeignKey("Airelax.Domain.Comments.Star", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Houses.BedroomDetail", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.Space", null)
                        .WithMany("BedroomDetails")
                        .HasForeignKey("SpaceId");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.House", b =>
                {
                    b.HasOne("Airelax.Domain.Members.Member", "Member")
                        .WithMany("Houses")
                        .HasForeignKey("OwnerId");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.HouseCategory", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithOne("HouseCategory")
                        .HasForeignKey("Airelax.Domain.Houses.HouseCategory", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Houses.HouseDescription", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithOne("HouseDescription")
                        .HasForeignKey("Airelax.Domain.Houses.HouseDescription", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Houses.HouseLocation", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithOne("HouseLocation")
                        .HasForeignKey("Airelax.Domain.Houses.HouseLocation", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Houses.HouseRule", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithOne("HouseRule")
                        .HasForeignKey("Airelax.Domain.Houses.HouseRule", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Photo", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithMany("Photos")
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airelax.Domain.Houses.Space", null)
                        .WithMany()
                        .HasForeignKey("SpaceId");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Policy", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithOne("Policy")
                        .HasForeignKey("Airelax.Domain.Houses.Policy", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Price.HousePrice", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithOne("HousePrice")
                        .HasForeignKey("Airelax.Domain.Houses.Price.HousePrice", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Houses.ReservationRule", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithOne("ReservationRule")
                        .HasForeignKey("Airelax.Domain.Houses.ReservationRule", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Space", b =>
                {
                    b.HasOne("Airelax.Domain.Houses.House", null)
                        .WithMany("Spaces")
                        .HasForeignKey("HouseId");
                });

            modelBuilder.Entity("Airelax.Domain.Members.EmergencyContact", b =>
                {
                    b.HasOne("Airelax.Domain.Members.Member", null)
                        .WithOne("EmergencyContact")
                        .HasForeignKey("Airelax.Domain.Members.EmergencyContact", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Members.MemberInfo", b =>
                {
                    b.HasOne("Airelax.Domain.Members.Member", null)
                        .WithOne("MemberInfo")
                        .HasForeignKey("Airelax.Domain.Members.MemberInfo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Members.MemberLoginInfo", b =>
                {
                    b.HasOne("Airelax.Domain.Members.Member", null)
                        .WithOne("MemberLoginInfo")
                        .HasForeignKey("Airelax.Domain.Members.MemberLoginInfo", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Members.WishList", b =>
                {
                    b.HasOne("Airelax.Domain.Members.Member", null)
                        .WithMany("WishLists")
                        .HasForeignKey("MemberId");
                });

            modelBuilder.Entity("Airelax.Domain.Orders.Order", b =>
                {
                    b.HasOne("Airelax.Domain.Members.Member", "Member")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Airelax.Domain.Houses.House", "House")
                        .WithMany()
                        .HasForeignKey("HouseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("House");

                    b.Navigation("Member");
                });

            modelBuilder.Entity("Airelax.Domain.Orders.OrderDetail", b =>
                {
                    b.HasOne("Airelax.Domain.Orders.Order", null)
                        .WithOne("OrderDetail")
                        .HasForeignKey("Airelax.Domain.Orders.OrderDetail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Orders.OrderPriceDetail", b =>
                {
                    b.HasOne("Airelax.Domain.Orders.Order", null)
                        .WithOne("OrderPriceDetail")
                        .HasForeignKey("Airelax.Domain.Orders.OrderPriceDetail", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Orders.Payment", b =>
                {
                    b.HasOne("Airelax.Domain.Orders.Order", null)
                        .WithOne("Payment")
                        .HasForeignKey("Airelax.Domain.Orders.Payment", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Airelax.Domain.Comments.Comment", b =>
                {
                    b.Navigation("Star");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.House", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("HouseCategory");

                    b.Navigation("HouseDescription");

                    b.Navigation("HouseLocation");

                    b.Navigation("HousePrice");

                    b.Navigation("HouseRule");

                    b.Navigation("Photos");

                    b.Navigation("Policy");

                    b.Navigation("ReservationRule");

                    b.Navigation("Spaces");
                });

            modelBuilder.Entity("Airelax.Domain.Houses.Space", b =>
                {
                    b.Navigation("BedroomDetails");
                });

            modelBuilder.Entity("Airelax.Domain.Members.Member", b =>
                {
                    b.Navigation("EmergencyContact");

                    b.Navigation("Houses");

                    b.Navigation("MemberInfo");

                    b.Navigation("MemberLoginInfo");

                    b.Navigation("Orders");

                    b.Navigation("WishLists");
                });

            modelBuilder.Entity("Airelax.Domain.Orders.Order", b =>
                {
                    b.Navigation("OrderDetail");

                    b.Navigation("OrderPriceDetail");

                    b.Navigation("Payment");
                });
#pragma warning restore 612, 618
        }
    }
}
