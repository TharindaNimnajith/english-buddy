﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AG.Recommender;
using EnglishBuddy.Application.Persistence;
using EnglishBuddy.Domain.Entities;

namespace EnglishBuddy.Application.Services
{
    public class UserRecommendations
    {
        private readonly AppDbContext _appDbContext;

        public UserRecommendations(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public int GetCurrentState(int state, int result)
        {
            return new Recommender().Run(state, result).Actions[0];
        }


        public async Task<RecommendationResponse> GetLessonRecommendation(int state, int result, Lesson lesson)
        {
            var recommenderRet = new Recommender().Run(state, result);

            var response = new RecommendationResponse
            {
                Steps = recommenderRet.Actions,
                TypeName = lesson.Course.CourseType.Name
            };

            // set recommendation
            for (var i = 0; i < recommenderRet.Actions.Length; i++)
            {
                Random rnd = new Random();

                var difficultyLevels = lesson.Activities.Select(x => x.DifficultyLevel).Distinct().ToList();

                var difficultyLevel = 0;


                switch (recommenderRet.Actions[i])
                {
                    case (int)Recommender.GetAction.Activity1:

                        while (true)
                        {
                            var random = rnd.Next(difficultyLevels.Count());
                            difficultyLevel = difficultyLevels[random] == null ? 0 : difficultyLevels[random].Value;
                            if (difficultyLevel <= 5) break;
                        }



                        response.Activity1 = lesson.Activities?.ToList()
                            .OrderBy(x => x.Rating)
                            .FirstOrDefault(x => x.DifficultyLevel == difficultyLevel);
                        if (response.Activity1 != null)
                        {
                            response.Activity1.State = state;
                        }

                        break;

                    // return response;

                    case (int)Recommender.GetAction.Activity2:

                        while (true)
                        {
                            var random = rnd.Next(difficultyLevels.Count());
                            difficultyLevel = difficultyLevels[random] == null ? 0 : difficultyLevels[random].Value;
                            if (difficultyLevel >= 6) break;
                        }

                        response.Activity2 = lesson.Activities?.ToList().OrderBy(x => x.Rating)
                            .FirstOrDefault(x => x.DifficultyLevel == difficultyLevel);
                        if (response.Activity2 != null)
                        {
                            response.Activity2.State = state;
                        }

                        break;

                    //return response;

                    case (int)Recommender.GetAction.Examples:
                        var randomId = new Random().Next(lesson.SamplesQuestions.Count);
                        if (randomId > 0)
                            response.Example = lesson.SamplesQuestions.OrderBy(x => x.Rating).ToList()[randomId];
                        else
                        {
                            response.Example = lesson.SamplesQuestions.FirstOrDefault() ?? new Example();
                        }

                        break;
                    // return response;

                    case (int)Recommender.GetAction.ExtraLessons:
                        var extraLessonRandomId = new Random().Next(lesson.ExtraLessons.Count);
                        if (extraLessonRandomId > 0)
                            response.ExtraLesson =
                                lesson.ExtraLessons.OrderBy(x => x.Rating).ToList()[extraLessonRandomId];
                        else
                        {
                            response.ExtraLesson = lesson.ExtraLessons.OrderBy(x => x.Rating).FirstOrDefault() ??
                                                   new ExtraLesson();
                        }

                       
                        // return response;
                        break;
                }
            }

            Console.WriteLine("OK");
            
            if(response.ExtraLesson != null) response.ExtraLesson.Lesson = null;
            return response;
        }


        public async Task<RecommendationResponse> GetAsync(int state, int result, Course course)
        {
            try
            {
                Recommender recommender = new Recommender();
                RecommendationResponse response = new RecommendationResponse { Introduction = course.Introduction };

                var recommenderRes = recommender.Run(state, result);

                switch (state)
                {
                    case 0:
                        response.Message = "Hi please complete your introduction lesson and do activity 1";
                        break;
                }


                // can implement a algo to get average of user activities

                response.Steps = recommenderRes.Actions;
                response.TypeName = course.CourseType.Name;
                for (int i = 0; i < recommenderRes.Actions.Length; i++)
                {
                    response = GetRecommendationResponse(recommenderRes.Actions[i], course, response);
                }

                // await AddNewRecommendations(response, userCourseId);


                return response;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        
        private RecommendationResponse GetRecommendationResponse(
            int state,
            Course course,
            RecommendationResponse response)
        {
            // Random rnd = new Random();
            // switch (state)
            // {
            //     case (int)Recommender.GetAction.Activity1:
            //          response.Activity1 = ((course.Activities?.ToList()) ?? throw new InvalidOperationException())
            //             .FirstOrDefault(x => x.DifficultyLevel == rnd.Next(1, 2));
            //          if (response.Activity1 != null) {response.Activity1.Course = null;
            //              response.Activity1.State = state;
            //          }
            //          return response;
            //         
            //     case (int)Recommender.GetAction.Activity2:    
            //         response.Activity2 = ((course.Activities?.ToList()) ?? throw new InvalidOperationException())
            //             .FirstOrDefault(x => x.DifficultyLevel == 3);
            //         if (response.Activity2 != null) {response.Activity2.Course = null;
            //             response.Activity2.State = state;
            //         }
            //         return response;
            //
            //     case (int)Recommender.GetAction.Examples:
            //         var randomId = new Random().Next(0,course.SamplesQuestions.Count-1);
            //         if (randomId > 0)
            //             response.SamplesQuestion = course.SamplesQuestions.ToList()[randomId];
            //         else
            //         {
            //             response.SamplesQuestion = course.SamplesQuestions.FirstOrDefault() ?? new SamplesQuestion();
            //         }
            //
            //         return response;
            //     
            //     case (int)Recommender.GetAction.ExtraLessons:
            //         response.ExtraLesson = ((course.CourseCategory?.Lessons?.ToList()) ?? throw new InvalidOperationException())
            //             .Where(x=> x.Rating == rnd.Next(1, 5))
            //             .OrderByDescending(x=>x.Rating)
            //             .FirstOrDefault();
            //
            //
            //         if (response.ExtraLesson == null)
            //         {
            //             response.ExtraLesson = ((course.CourseCategory?.Lessons?.ToList()) ?? throw new InvalidOperationException())
            //                 .OrderByDescending(x=>x.Rating)
            //                 .FirstOrDefault() ?? new Lesson();
            //         }
            //
            //
            //         return response;
            //     
            //      default:
            //          return response;
            //         
            // }
            return response;
        }

        // private async Task AddNewRecommendations(RecommendationResponse response, int userCourseId)
        // {
        //     if (response.Activity1 != null)
        //     {
        //       var res =  await _appDbContext.UserActivities.FirstOrDefaultAsync(x =>
        //             x.RecommendActivityId == response.Activity1.Id);
        //       
        //       if(res == null)
        //       {
        //           await _appDbContext.UserActivities
        //               .AddAsync(new UserActivity
        //               {
        //                   ApplicationUserCourseId = userCourseId,
        //                   RecommendActivityId = response.Activity1.Id
        //               });
        //       }
        //       else
        //       {
        //           res.PresentedCount += res.PresentedCount;
        //           _appDbContext.Update(res);
        //       }
        //     }
        //     
        //     if (response.Activity2 != null)
        //     {
        //         var res =  await _appDbContext.UserActivities.FirstOrDefaultAsync(x =>
        //             x.RecommendActivityId == response.Activity2.Id);
        //       
        //         if(res == null)
        //         {
        //             await _appDbContext.UserActivities
        //                 .AddAsync(new UserActivity
        //                 {
        //                     ApplicationUserCourseId = userCourseId,
        //                     RecommendActivityId = response.Activity2.Id
        //                 });
        //         }
        //         else
        //         {
        //             res.PresentedCount += res.PresentedCount;
        //             _appDbContext.Update(res);
        //         }
        //     }
        //     
        //     if (response.SamplesQuestion != null)
        //     {
        //         var res =  await _appDbContext.UserSampleQuestions
        //             .FirstOrDefaultAsync(x => x.SamplesQuestionId == response.SamplesQuestion.Id);
        //       
        //         if(res == null)
        //         {
        //             await _appDbContext.UserSampleQuestions
        //                 .AddAsync(new UserSampleQuestion
        //                 {
        //                     ApplicationUserCourseId = userCourseId,
        //                     SamplesQuestionId = response.SamplesQuestion.Id
        //                 });
        //         }
        //         else
        //         {
        //             res.PresentedCount += res.PresentedCount;
        //             _appDbContext.Update(res);
        //         }
        //     }
        //     
        //     
        //     await _appDbContext.SaveChangesAsync();
        // }
    }

    public class RecommendationResponse
    {
        public string Introduction { get; set; }

        public string TypeName { get; set; }
        public Activity Activity1 { get; set; }
        public Activity Activity2 { get; set; }
        public Example Example { get; set; }
        public ExtraLesson ExtraLesson { get; set; }

        public List<Activity> Activities { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<Example> SampleQuestions { get; set; }

        public int[] Steps { get; set; }

        public string Message { get; set; }
    }
}