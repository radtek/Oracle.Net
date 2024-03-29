﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Oracle.Net.Data;

namespace Oracle.Net.Migrations
{
    [DbContext(typeof(OracleContext))]
    [Migration("20181110132436_ZX")]
    partial class ZX
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Oracle.Net.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Quesid");

                    b.Property<string>("Reply");

                    b.Property<int>("Replyerid");

                    b.Property<string>("Replyername");

                    b.Property<DateTime>("Replytime");

                    b.HasKey("Id");

                    b.ToTable("Answer");
                });

            modelBuilder.Entity("Oracle.Net.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Answerid");

                    b.Property<string>("Message");

                    b.Property<int>("Senderid");

                    b.Property<string>("Sendername");

                    b.HasKey("Id");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Oracle.Net.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<int>("Fromid");

                    b.Property<string>("Fromname");

                    b.Property<string>("Info");

                    b.Property<DateTime>("Time");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Oracle.Net.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Info");

                    b.Property<string>("Picture");

                    b.Property<int>("Querid");

                    b.Property<string>("Quesname");

                    b.Property<DateTime>("Subtime");

                    b.HasKey("Id");

                    b.ToTable("Question");
                });

            modelBuilder.Entity("Oracle.Net.Models.Scenetest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Info");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Scenetest");
                });

            modelBuilder.Entity("Oracle.Net.Models.Score", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("Scene");

                    b.Property<int?>("Term");

                    b.Property<int>("Testid");

                    b.Property<string>("Testname");

                    b.Property<int>("Testscore");

                    b.Property<DateTime>("Testtime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Score");
                });

            modelBuilder.Entity("Oracle.Net.Models.Test", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answ");

                    b.Property<string>("Info");

                    b.Property<int>("Mark");

                    b.Property<string>("Op1");

                    b.Property<string>("Op2");

                    b.Property<string>("Op3");

                    b.Property<string>("Op4");

                    b.Property<string>("Question");

                    b.Property<int>("Testid");

                    b.HasKey("Id");

                    b.ToTable("Test");
                });

            modelBuilder.Entity("Oracle.Net.Models.Testlist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Info");

                    b.Property<int>("Scene");

                    b.Property<string>("Testname");

                    b.HasKey("Id");

                    b.ToTable("Testlist");
                });

            modelBuilder.Entity("Oracle.Net.Models.Upload", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Info");

                    b.Property<string>("Name");

                    b.Property<string>("Path");

                    b.Property<string>("Size");

                    b.HasKey("Id");

                    b.ToTable("Upload");
                });

            modelBuilder.Entity("Oracle.Net.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Class");

                    b.Property<string>("Name");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("Role");

                    b.Property<int?>("Term");

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
