namespace UserVoice.Data.Migrations
{
    using Microsoft.AspNet.Identity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using UserVoice.Data.Models;

    public sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            var hasher = new PasswordHasher();

            var user = new User
            {
                Email = "user1@site.com",
                UserName = "user1@site.com",
                PasswordHash = hasher.HashPassword("user1")
            };

            if (!context.Users.Any())
            {
                context.Users.Add(user);
                context.SaveChanges();
            }

            var vote = new Vote
            {
                VotePoints = 3
            };

            context.Votes.Add(vote);
            context.SaveChanges();

            if (!context.Ideas.Any())
            {
                this.GenerateIdea(context, user, "Xna Comment", "XNA 5", @"Please continue to work on XNA. It's a great way for indie game developers 
                                    like myself to make games and give them to the world. XNA gave us the ability
                                    to put our games, easily, on the most popular platforms, and to just dump XNA would 
                                    be therefor heartbreaking... I implore you to keep working on XNA so we C# developers 
                                    can still make amazing games!");

                this.GenerateIdea(context, user, ".Net Games comment", "Allow .NET games on Xbox One", @"Yesterday was announced that Xbox One will allow indie developer to easily publish games on Xbox One.
                                    Lots of indie developers and small game company are using .NET to develop games.Today, we are able to easily target several Windows 
                                    platforms(Windows Desktop, Windows RT and Windows Phone 8) as well as other platforms thanks to Mono from Xamarin.
                                    As we don't know yet the details about this indie developer program for Xbox One, we would love to use .NET on this platform - with
                                    everything accessible, from latest 4.5 with async, to unsafe code and native code access through DLLImport (and not only through WinRT components)
                                    Please make .NET a compelling game development alternative on Xbox One!");

                this.GenerateIdea(context, user, "Support web.config style comment", "Support web.config style Transforms on any file in any project type", @"Web.config Transforms offer a great way to handle environment-specific settings. XML and other files
                                    frequently warrant similar changes when building for development (Debug), SIT, UAT, and production (Release).
                                    It is easy to create additional build configurations to support multiple environments via transforms. Unfortunately, not everything
                                    can be handled in web.config files many settings need to be changed in xml or other 'config' files.
                                    Also, this functionality is needed in other project types - most notably SharePoint 2010 projects.");

                this.GenerateIdea(context, user, "macros comment", "Bring back macros", @"I am amazed you've decided to remove Macros from Visual Studio. Not only are they useful for general programming, but they're a great way to be introduced to the Visual Studio APIs.
                                                                                            If you are unwilling to put in the development time towards them, please release the source code and let the community maintain it as an extension.");

                this.GenerateIdea(context, user, "silverlight comment", "Open source Silverlight", @"Blog post at http://davidburela.wordpress.com/2013/11/22/is-it-time-to-open-source-silverlight/
                                                                                                    For all intents and purposes Microsoft now views Silverlight as “Done”. While it is no longer in active development it is still being “supported” through to 2021 (source).
                                                                                                    However there is still a section of the .Net community that would like to see further development done on the Silverlight framework. A quick look at some common request lists brings up the following stats:
                                                                                                    * 5,720+ votes to release Silverlight 6 https://visualstudio.uservoice.com/forums/121579-visual-studio/suggestions/3556619-silverlight-6 
                                                                                                    * Feature requests for Silverlight http://dotnet.uservoice.com/forums/4325-silverlight-feature-suggestions 
                                                                                                    * Microsoft connect list of active Silverlight feature requests: http://connect.microsoft.com/VisualStudio/SearchResults.aspx?KeywordSearchIn=2&SearchQuery=%22silverlight%22&FeedbackType=2&Status=1&Scope=0&SortOrder=10&TabView=1 
                                                                                                    Rather than letting Silverlight decay in a locked up source control in the Microsoft vaults, I call on them to instead release it into the hands of the community to see what they can build with it. Microsoft may no longer have a long term vision for it, but the community itself may find ways to extend it in ways Microsoft didn’t envision. 
                                                                                                    Earlier this year Microsoft open sourced RIA Services on Outer Curve http://www.outercurve.org/Galleries/ASPNETOpenSourceGallery/OpenRIAServices, it would be great to see this extended to the entire Silverlight framework.");

                this.GenerateIdea(context, user, "DirectX 11 comment", "Native DirectX 11 support for WPF", @"in 2013 WPF still work on DX9, and this have a lot of inconvenience. First of all it is almost impossible to make interaction with native DX11 C++ and WPF. Axisting D3DImage class support only DX 9, but not higher and for now it is a lot of pain to attach DX 11 engine to WPF.
                                                                                                                Please, make nativa support for DX 11 in WOF by default and update D3DImage class to have possibility to work with nativa C++ DX 11 engine and make render directly to WPF control (controls) without pain with C++ dll.");

                this.GenerateIdea(context, user, "WPF comment", "Make WPF open-source and accept pull-requests from the community", @"Please follow the footsteps of the ASP .NET team and make WPF open-source with the source code on GitHub, and accept pull-requests from the community.");

                this.GenerateIdea(context, user, "Fix 260 chars comment", "Fix 260 character file name length limitation", @"Same description as here:
                                                                                                                            http://visualstudio.uservoice.com/forums/121579-visual-studio/suggestions/2156195-fix-260-character-file-name-length-limitation");

                this.GenerateIdea(context, user, "ES6 modules comment", "Support for ES6 modules", @"Add support for the new JavaScript ES6 module syntax, including module definition and imports.");

                this.GenerateIdea(context, user, "remnansts comment visual studio", "Create a 'remove all remnants of Visual Studio from your system' program.", @"I'm writing this on behalf of the thousands of other Visual Studio users out there who have had nightmares trying to uninstall previous versions of VS. Thus cumulatively losing hundreds of thousands of productive work hours.

                                                                                                                    During this year, I had installed the following programs/components on my system: 
                                                                                                                    * Visual Studio 2012 Express for Desktop 
                                                                                                                    * Visual Studio 2012 Express for Web 
                                                                                                                    * Team Foundation Server Express 
                                                                                                                    * SQL Server Express 
                                                                                                                    * SQL Server Data Tools 
                                                                                                                    * LightSwitch 2011 trial (which created a VS 2010 installation) 
                                                                                                                    * Visual Studio 2010 Tools for SQL Server Compact 3.5 SP2 
                                                                                                                    * Entity Framework Designer for Visual Studio 2012 
                                                                                                                    * Visual Studio Tools for Applications 
                                                                                                                    * Visual Studio Tools for Office 
                                                                                                                    * F# Tools for Visual Studio Express 2012 for Web

                                                                                                                    Two weeks ago I discovered that third-party controls can't be added to the Express versions of VS. I'm disabled and live on a fixed income, so spending $500 for the Professional version, in order to continue my hobby programming with a third-party control, was a tough decision. But I bought it.

                                                                                                                    When it arrived, I figured it would take an hour or two to remove the above programs and then I could install the Pro version. I wanted to have a clean file system and Registry for the new install of VS Pro.

                                                                                                                    It's now SIX DAYS later, and my spending 12-14 hours a day working on this alone. Removing these programs was the biggest nightmare I have ever faced with Microsoft products in my 30 years of being a Microsoft customer. Each one of these products automatically installed 5, 10 or more additional components, along with many thousands of files and individual Registry entries.");

                this.GenerateIdea(context, user, "support .net builds comment", "Support .NET Builds without requiring Visual Studio on the server", @"To build certain PCL libraries and libraries for Windows 8 RT requires having Visual Studio on the server.

                                                                                    Nick Berardi writes about a workaround that allows running a build server without VS, but it's really just a workaround for functionality that should be easy.

                                                                                    Not to mention there's probably licensing considerations we're just ignoring by doing that.

                                                                                    http://nickberardi.com/a-net-build-server-without-visual-studio/

                                                                                    Please make it easy (and legal) to build .NET projects on a server without requiring a Visual Studio installation (or license) on that server.");

                this.GenerateIdea(context, user, "VS IDE should support file patterns in project files", "VS IDE should support file patterns in project files", @"Patterns should be preserved and unmodified when working with *proj files. If I specify a pattern with something like **/*.cs for my code files. If I add a new .cs file that fits that pattern the .csproj file should not be modified.

                                                                                                            MSBuild already respects this, but the IDE will always modify the project file.

                                                                                                            For numerous scenarios this could simplify the diff / merge process.");

                this.GenerateIdea(context, user, "Improve WPF performance comment", "Improve WPF performance", @"I have a high end PC and still WPF is not always fluent. Just compare it with QT 4.6 QML (Declarative UI) it is sooo FAST!");

                this.GenerateIdea(context, user, "some comment", "T4 editing", @"T4 is no longer just a tool used internally by VS, but is being increasingly used by developers for code generation. It would be great to have syntax highlighting, intellisense etc. out of the box.

                                                                                    I appreciate this is probably more of a Visual Studio feature request than an ASP.NET one, but as T4 is used a lot within ASP.NET projects, particularly MVC ones, I figure it's worth a mention.");

                this.GenerateIdea(context, user, "comment", "Visual Studio for Mac Os x", @"Dear Madam and sir;

                                                                We need Full Version of Visual Studio for Mac Os x. 
                                                                And language of programming such as:

                                                                -C 
                                                                -C++ 
                                                                -C# 
                                                                -VB 
                                                                -F# 
                                                                -HTML 
                                                                -MHTML

                                                                Thanks,");

            }
        }

        private void GenerateIdea(ApplicationDbContext context, User user, string commentMessage, string title, string description)
        {
            var comments = this.GenerateComments(context, commentMessage + " ", user);
            var votes = this.GenerateVotes(context);

            var firstIdea = new Idea
            {
                Title = title,
                Description = description,
                User = user,
                AuthorIp = user.Id,
                Comments = comments,
                Votes = votes
            };

            context.Ideas.Add(firstIdea);
            context.SaveChanges();
        }

        private IList<Comment> GenerateComments(ApplicationDbContext context, string message, User user)
        {
            var comments = new List<Comment>();

            for (int i = 1; i <= 10; i++)
            {
                var newComment = new Comment
                {
                    Content = message + i,
                    AuthorEmail = user.Email,
                    AuthorIp = user.Id
                };

                comments.Add(newComment);
                context.Comments.Add(newComment);
            }

            context.SaveChanges();

            return comments;
        }

        private IList<Vote> GenerateVotes(ApplicationDbContext context)
        {
            var votes = new List<Vote>();
            var rand = new Random();

            for (int i = 1; i <= 100; i++)
            {
                int votePoints = rand.Next(1, 4);
                string ip = "192.168." + rand.Next(0, 200) + "." + rand.Next(0, 400);

                var newVote = new Vote
                {
                    VotePoints = votePoints,
                    AuthorIp = ip
                };

                votes.Add(newVote);
                context.Votes.Add(newVote);
            }

            context.SaveChanges();

            return votes;
        }
    }
}
