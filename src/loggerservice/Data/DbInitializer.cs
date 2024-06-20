
using Microsoft.EntityFrameworkCore;

namespace loggerservice.Data;

public class DbInitializer
{
    public static void InitDb(WebApplication app){
        using var scope = app.Services.CreateScope();
        SeedData(scope.ServiceProvider.GetService<LoggerDbContext>());
    }

    private static void SeedData(LoggerDbContext? context)
    {
        context.Database.Migrate();
        
        if(context.CustomErrors.Any()){
            Console.WriteLine("Alreadt have data - no need to seed");
            return;
        }

        var CustomErrors = new List<CustomError>{
              new CustomError
                {
                    Id = 1,
                    Message = "Error message 1",
                    StackTrace = "StackTrace for error 1",
                    UserId = 101,
                    AppId = 201,
                    AppAccountId = 301
           
                },
                new CustomError
                {
                    Id = 2,
                    Message = "Error message 2",
                    StackTrace = "StackTrace for error 2",
                    UserId = 102,
                    AppId = 202,
                    AppAccountId = 302
                 
                },
                new CustomError
                {
                    Id = 3,
                    Message = "Error message 3",
                    StackTrace = "StackTrace for error 3",
                    UserId = 103,
                    AppId = 203,
                    AppAccountId = 303
               
                },
                new CustomError
                {
                    Id = 4,
                    Message = "Error message 4",
                    StackTrace = "StackTrace for error 4",
                    UserId = 104,
                    AppId = 204,
                    AppAccountId = 304
             
                },
                new CustomError
                {
                    Id = 5,
                    Message = "Error message 5",
                    StackTrace = "StackTrace for error 5",
                    UserId = 105,
                    AppId = 205,
                    AppAccountId = 305
                },
                new CustomError
                {
                    Id = 6,
                    Message = "Error message 6",
                    StackTrace = "StackTrace for error 6",
                    UserId = 106,
                    AppId = 206,
                    AppAccountId = 306
                },
                new CustomError
                {
                    Id = 7,
                    Message = "Error message 7",
                    StackTrace = "StackTrace for error 7",
                    UserId = 107,
                    AppId = 207,
                    AppAccountId = 307
                },
                new CustomError
                {
                    Id = 8,
                    Message = "Error message 8",
                    StackTrace = "StackTrace for error 8",
                    UserId = 108,
                    AppId = 208,
                    AppAccountId = 308
                },
                new CustomError
                {
                    Id = 9,
                    Message = "Error message 9",
                    StackTrace = "StackTrace for error 9",
                    UserId = 109,
                    AppId = 209,
                    AppAccountId = 309
                },
                new CustomError
                {
                    Id = 10,
                    Message = "Error message 10",
                    StackTrace = "StackTrace for error 10",
                    UserId = 110,
                    AppId = 210,
                    AppAccountId = 310
                },
                new CustomError
                {
                    Id = 11,
                    Message = "Error message 11",
                    StackTrace = "StackTrace for error 11",
                    UserId = 111,
                    AppId = 211,
                    AppAccountId = 311
                },
                new CustomError
                {
                    Id = 12,
                    Message = "Error message 12",
                    StackTrace = "StackTrace for error 12",
                    UserId = 112,
                    AppId = 212,
                    AppAccountId = 312
                },
                new CustomError
                {
                    Id = 13,
                    Message = "Error message 13",
                    StackTrace = "StackTrace for error 13",
                    UserId = 113,
                    AppId = 213,
                    AppAccountId = 313
                },
                new CustomError
                {
                    Id = 14,
                    Message = "Error message 14",
                    StackTrace = "StackTrace for error 14",
                    UserId = 114,
                    AppId = 214,
                    AppAccountId = 314
                },
                new CustomError
                {
                    Id = 15,
                    Message = "Error message 15",
                    StackTrace = "StackTrace for error 15",
                    UserId = 115,
                    AppId = 215,
                    AppAccountId = 315
                },
                new CustomError
                {
                    Id = 16,
                    Message = "Error message 16",
                    StackTrace = "StackTrace for error 16",
                    UserId = 116,
                    AppId = 216,
                    AppAccountId = 316
                },
                new CustomError
                {
                    Id = 17,
                    Message = "Error message 17",
                    StackTrace = "StackTrace for error 17",
                    UserId = 117,
                    AppId = 217,
                    AppAccountId = 317
                },
                new CustomError
                {
                    Id = 18,
                    Message = "Error message 18",
                    StackTrace = "StackTrace for error 18",
                    UserId = 118,
                    AppId = 218,
                    AppAccountId = 318
                },
                new CustomError
                {
                    Id = 19,
                    Message = "Error message 19",
                    StackTrace = "StackTrace for error 19",
                    UserId = 119,
                    AppId = 219,
                    AppAccountId = 319
              
                },
                new CustomError
                {
                    Id = 20,
                    Message = "Error message 20",
                    StackTrace = "StackTrace for error 20",
                    UserId = 120,
                    AppId = 220,
                    AppAccountId = 320
              
                }
        };

        context.AddRange(CustomErrors);
        context.SaveChanges();
    }
}
