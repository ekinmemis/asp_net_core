#region Fixed window limiter
//1 pencere içersinde 12 saniyede maksimum 4 request kabul eder.
// using Microsoft.AspNetCore.RateLimiting;
// using System.Threading.RateLimiting;

// var builder = WebApplication.CreateBuilder(args);

// builder.Services.AddRateLimiter(_ => _
//     .AddFixedWindowLimiter(policyName: "fixed", options =>
//     {
//         options.PermitLimit = 4;
//         options.Window = TimeSpan.FromSeconds(12);
//         options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
//         options.QueueLimit = 2;
//     }));

// var app = builder.Build();

// app.UseRateLimiter();

// static string GetTicks() => (DateTime.Now.Ticks & 0x11111).ToString("00000");

// app.MapGet("/", () => Results.Ok($"Hello {GetTicks()}"))
//                         .RequireRateLimiting("fixed");

// app.Run();

#endregion

#region Fixed window limiter - 2

// using System.Threading.RateLimiting;
// using Microsoft.AspNetCore.RateLimiting;
// using rate_limiting_middleware.Models;

// var builder = WebApplication.CreateBuilder(args);
// builder.Services.Configure<MyRateLimitOptions>(
//     builder.Configuration.GetSection(MyRateLimitOptions.MyRateLimit));

// var myOptions = new MyRateLimitOptions();
// builder.Configuration.GetSection(MyRateLimitOptions.MyRateLimit).Bind(myOptions);
// var fixedPolicy = "fixed";

// builder.Services.AddRateLimiter(_ => _
//     .AddFixedWindowLimiter(policyName: fixedPolicy, options =>
//     {
//         options.PermitLimit = myOptions.PermitLimit;
//         options.Window = TimeSpan.FromSeconds(myOptions.Window);
//         options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
//         options.QueueLimit = myOptions.QueueLimit;
//     }));

// var app = builder.Build();

// app.UseRateLimiter();

// static string GetTicks() => (DateTime.Now.Ticks & 0x11111).ToString("00000");

// app.MapGet("/", () => Results.Ok($"Fixed Window Limiter {GetTicks()}"))
//                            .RequireRateLimiting(fixedPolicy);

// app.Run();

#endregion

#region Sliding window limiter

// using Microsoft.AspNetCore.RateLimiting;
// using rate_limiting_middleware.Models;
// using System.Threading.RateLimiting;

// var builder = WebApplication.CreateBuilder(args);

// var myOptions = new MyRateLimitOptions();
// builder.Configuration.GetSection(MyRateLimitOptions.MyRateLimit).Bind(myOptions);
// var slidingPolicy = "sliding";

// builder.Services.AddRateLimiter(_ => _
//     .AddSlidingWindowLimiter(policyName: slidingPolicy, options =>
//     {
//         options.PermitLimit = myOptions.PermitLimit;
//         options.Window = TimeSpan.FromSeconds(myOptions.Window);
//         options.SegmentsPerWindow = myOptions.SegmentsPerWindow;
//         options.QueueProcessingOrder = QueueProcessingOrder.OldestFirst;
//         options.QueueLimit = myOptions.QueueLimit;
//     }));

// var app = builder.Build();

// app.UseRateLimiter();

// static string GetTicks() => (DateTime.Now.Ticks & 0x11111).ToString("00000");

// app.MapGet("/", () => Results.Ok($"Sliding Window Limiter {GetTicks()}"))
//                            .RequireRateLimiting(slidingPolicy);

// app.Run();

#endregion