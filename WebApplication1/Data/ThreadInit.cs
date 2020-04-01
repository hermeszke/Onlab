using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public static class ThreadInit
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any movies.
                if (context.Threads.Any())
                {
                    return;   // DB has been seeded
                }

                context.Threads.AddRange(
                    new Thread { ThreadId = 1, ThreadName = "AskScuffed", FirstPostHeadline = "Welcome to our thread", FirstPostContent = "Ask any questions you couldn't elsewhere"},
                new Thread { ThreadId = 2, ThreadName = "Hungary", FirstPostHeadline = "Welcome to our thread", FirstPostContent = "Bojler eladó" },
                new Thread { ThreadId = 3, ThreadName = "sffwe", FirstPostHeadline = "Welcome to our thread", FirstPostContent = "sfwefsfwefwd" }
                );
                context.SaveChanges();
            }
        }

    }
}
