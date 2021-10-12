﻿// <auto-generated />
using System;
using EnglishBuddy.Application.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace EnglishBuddy.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20211010090658_Init")]
    partial class Init
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Activity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<int?>("DifficultyLevel")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<int?>("LessonId")
                        .HasColumnType("integer");

                    b.Property<string>("ModelAnswer")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WordLimit")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Activities");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ActivityComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ActivityId")
                        .HasColumnType("integer");

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("text");

                    b.Property<int>("Sentiment")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.ToTable("ActivityComments");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ActivityResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("ActivityId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("ApplicationUserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("ArticulationRate")
                        .HasColumnType("double precision");

                    b.Property<double>("ComprehensivenessScore")
                        .HasColumnType("double precision");

                    b.Property<int>("EssayScore")
                        .HasColumnType("integer");

                    b.Property<double>("GrammarScore")
                        .HasColumnType("double precision");

                    b.Property<string>("MispronouncedPhonemes")
                        .HasColumnType("text");

                    b.Property<string>("MispronouncedWords")
                        .HasColumnType("text");

                    b.Property<string>("ModelAnswer")
                        .HasColumnType("text");

                    b.Property<double>("ObjectivityScore")
                        .HasColumnType("double precision");

                    b.Property<int>("OverallScore")
                        .HasColumnType("integer");

                    b.Property<double>("PolarityScore")
                        .HasColumnType("double precision");

                    b.Property<double>("PronunciationLevel")
                        .HasColumnType("double precision");

                    b.Property<double>("Ratio")
                        .HasColumnType("double precision");

                    b.Property<double>("SimilarityScore")
                        .HasColumnType("double precision");

                    b.Property<double>("SpeakingRate")
                        .HasColumnType("double precision");

                    b.Property<string>("SpellingGrammarMistakes")
                        .HasColumnType("text");

                    b.Property<double>("SpellingScore")
                        .HasColumnType("double precision");

                    b.Property<string>("StudentAnswer")
                        .HasColumnType("text");

                    b.Property<double>("SubjectivityScore")
                        .HasColumnType("double precision");

                    b.Property<string>("Suggestions")
                        .HasColumnType("text");

                    b.Property<int>("WordCount")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ActivityId");

                    b.HasIndex("ApplicationUserId");

                    b.ToTable("ActivityResults");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("Age")
                        .HasColumnType("integer");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<int>("Coins")
                        .HasColumnType("integer");

                    b.Property<int>("CourseCount")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Gender")
                        .HasColumnType("text");

                    b.Property<int>("Grammar")
                        .HasColumnType("integer");

                    b.Property<string>("Language")
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<string>("ProfilePictureUrl")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Rank")
                        .HasColumnType("integer");

                    b.Property<string>("Resident")
                        .HasColumnType("text");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Speaking")
                        .HasColumnType("integer");

                    b.Property<int>("Spelling")
                        .HasColumnType("integer");

                    b.Property<int>("Writing")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("ApplicationUsers");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ApplicationUserCourse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("text");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCompletedIntroduction")
                        .HasColumnType("boolean");

                    b.Property<int>("Result")
                        .HasColumnType("integer");

                    b.Property<int>("Sate")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserId");

                    b.HasIndex("CourseId");

                    b.ToTable("ApplicationUserCourses");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ApplicationUserCourseLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicationUserCourseId")
                        .HasColumnType("integer");

                    b.Property<int>("LessonId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserCourseId");

                    b.HasIndex("LessonId");

                    b.ToTable("ApplicationUserCourseLessons");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int?>("CourseCategoryId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int?>("CourseTypeId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Difficulty")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("text");

                    b.Property<string>("Introduction")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsBestSeller")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("text");

                    b.Property<float>("Rating")
                        .HasColumnType("real");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CourseCategoryId");

                    b.HasIndex("CourseTypeId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.CourseCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CourseCategories");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.CourseComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("CourseComments");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.CourseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("CourseTypes");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Example", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Answers")
                        .HasColumnType("text");

                    b.Property<int?>("LessonId")
                        .HasColumnType("integer");

                    b.Property<string>("Questions")
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Examples");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ExtraLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("text");

                    b.Property<string>("Html")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LessonId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("ExtraLessons");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CreatedUserId")
                        .HasColumnType("text");

                    b.Property<string>("Html")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedUserId")
                        .HasColumnType("text");

                    b.Property<int>("Rating")
                        .HasColumnType("integer");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.LessonComment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("text");

                    b.Property<int>("LessonId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("LessonComments");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.UserActivity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicationUserCourseId")
                        .HasColumnType("integer");

                    b.Property<int>("LastResult")
                        .HasColumnType("integer");

                    b.Property<int>("PresentedCount")
                        .HasColumnType("integer");

                    b.Property<int>("RecommendActivityId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("RecommendActivityId");

                    b.ToTable("UserActivities");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.UserLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicationUserCourseId")
                        .HasColumnType("integer");

                    b.Property<int>("LastResult")
                        .HasColumnType("integer");

                    b.Property<int>("PresentedCount")
                        .HasColumnType("integer");

                    b.Property<int>("RecommendLessonId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserCourseId");

                    b.ToTable("UserLessons");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.UserSampleQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ApplicationUserCourseId")
                        .HasColumnType("integer");

                    b.Property<int>("LastResult")
                        .HasColumnType("integer");

                    b.Property<int>("PresentedCount")
                        .HasColumnType("integer");

                    b.Property<int>("SamplesQuestionId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("ApplicationUserCourseId");

                    b.ToTable("UserSampleQuestions");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Activity", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Lesson", null)
                        .WithMany("Activities")
                        .HasForeignKey("LessonId");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ActivityComment", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Activity", null)
                        .WithMany("ActivityComments")
                        .HasForeignKey("ActivityId");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ActivityResult", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Activity", "Activity")
                        .WithMany()
                        .HasForeignKey("ActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishBuddy.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Activity");

                    b.Navigation("ApplicationUser");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ApplicationUserCourse", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.ApplicationUser", "ApplicationUser")
                        .WithMany()
                        .HasForeignKey("ApplicationUserId");

                    b.HasOne("EnglishBuddy.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUser");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ApplicationUserCourseLesson", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.ApplicationUserCourse", "ApplicationUserCourse")
                        .WithMany("ApplicationUserCourseLessons")
                        .HasForeignKey("ApplicationUserCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishBuddy.Domain.Entities.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("ApplicationUserCourse");

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Course", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.CourseCategory", "CourseCategory")
                        .WithMany()
                        .HasForeignKey("CourseCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EnglishBuddy.Domain.Entities.CourseType", "CourseType")
                        .WithMany()
                        .HasForeignKey("CourseTypeId");

                    b.Navigation("CourseCategory");

                    b.Navigation("CourseType");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.CourseComment", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Example", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Lesson", null)
                        .WithMany("SamplesQuestions")
                        .HasForeignKey("LessonId");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ExtraLesson", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Lesson", "Lesson")
                        .WithMany("ExtraLessons")
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Lesson", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Course", "Course")
                        .WithMany("Lessons")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.LessonComment", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Lesson", "Lesson")
                        .WithMany()
                        .HasForeignKey("LessonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.UserActivity", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.Activity", "RecommendActivity")
                        .WithMany()
                        .HasForeignKey("RecommendActivityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RecommendActivity");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.UserLesson", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.ApplicationUserCourse", "ApplicationUserCourse")
                        .WithMany()
                        .HasForeignKey("ApplicationUserCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUserCourse");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.UserSampleQuestion", b =>
                {
                    b.HasOne("EnglishBuddy.Domain.Entities.ApplicationUserCourse", "ApplicationUserCourse")
                        .WithMany()
                        .HasForeignKey("ApplicationUserCourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ApplicationUserCourse");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Activity", b =>
                {
                    b.Navigation("ActivityComments");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.ApplicationUserCourse", b =>
                {
                    b.Navigation("ApplicationUserCourseLessons");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Course", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("EnglishBuddy.Domain.Entities.Lesson", b =>
                {
                    b.Navigation("Activities");

                    b.Navigation("ExtraLessons");

                    b.Navigation("SamplesQuestions");
                });
#pragma warning restore 612, 618
        }
    }
}
