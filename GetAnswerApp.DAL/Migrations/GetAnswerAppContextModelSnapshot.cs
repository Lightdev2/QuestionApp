﻿// <auto-generated />
using System;
using GetAnswerApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace GetAnswerApp.DAL.Migrations
{
    [DbContext(typeof(GetAnswerAppContext))]
    partial class GetAnswerAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AchievementUser", b =>
                {
                    b.Property<int>("AchievementsId")
                        .HasColumnType("integer");

                    b.Property<int>("UsersId")
                        .HasColumnType("integer");

                    b.HasKey("AchievementsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("AchievementUser");
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Descr")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsSelectedAsSolution")
                        .HasColumnType("boolean");

                    b.Property<string>("QuestionId")
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.HasIndex("QuestionId");

                    b.ToTable("Answers");
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Notification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("UserId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Notification");
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Question", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("CreatorId")
                        .HasColumnType("integer");

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsSolved")
                        .HasColumnType("boolean");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CreatorId");

                    b.ToTable("Questions", (string)null);
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Desc")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("Email");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("QuestionTag", b =>
                {
                    b.Property<string>("AttachedQuestionsId")
                        .HasColumnType("text");

                    b.Property<int>("TagsId")
                        .HasColumnType("integer");

                    b.HasKey("AttachedQuestionsId", "TagsId");

                    b.HasIndex("TagsId");

                    b.ToTable("QuestionTag");
                });

            modelBuilder.Entity("TagUser", b =>
                {
                    b.Property<int>("AttachedUsersId")
                        .HasColumnType("integer");

                    b.Property<int>("TrackedTagsId")
                        .HasColumnType("integer");

                    b.HasKey("AttachedUsersId", "TrackedTagsId");

                    b.HasIndex("TrackedTagsId");

                    b.ToTable("TagUser");
                });

            modelBuilder.Entity("AchievementUser", b =>
                {
                    b.HasOne("GetAnswerApp.DAL.Entities.Achievement", null)
                        .WithMany()
                        .HasForeignKey("AchievementsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GetAnswerApp.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Answer", b =>
                {
                    b.HasOne("GetAnswerApp.DAL.Entities.User", "Creator")
                        .WithMany("Answers")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GetAnswerApp.DAL.Entities.Question", null)
                        .WithMany("Answers")
                        .HasForeignKey("QuestionId");

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Notification", b =>
                {
                    b.HasOne("GetAnswerApp.DAL.Entities.User", "User")
                        .WithMany("Notifications")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Question", b =>
                {
                    b.HasOne("GetAnswerApp.DAL.Entities.User", "Creator")
                        .WithMany("Questions")
                        .HasForeignKey("CreatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");
                });

            modelBuilder.Entity("QuestionTag", b =>
                {
                    b.HasOne("GetAnswerApp.DAL.Entities.Question", null)
                        .WithMany()
                        .HasForeignKey("AttachedQuestionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GetAnswerApp.DAL.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TagUser", b =>
                {
                    b.HasOne("GetAnswerApp.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("AttachedUsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GetAnswerApp.DAL.Entities.Tag", null)
                        .WithMany()
                        .HasForeignKey("TrackedTagsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.Question", b =>
                {
                    b.Navigation("Answers");
                });

            modelBuilder.Entity("GetAnswerApp.DAL.Entities.User", b =>
                {
                    b.Navigation("Answers");

                    b.Navigation("Notifications");

                    b.Navigation("Questions");
                });
#pragma warning restore 612, 618
        }
    }
}
