using System.Collections.Generic;

namespace XFListView
{
    class PluralsightCourse
    {
        public string Author { get; set; }
        public string Title { get; set; }

        public static List<PluralsightCourse> GetCourseList()
        {
            var courseList = new List<PluralsightCourse>
            {
                new PluralsightCourse
                {
                    Title = "Building Cross Platform Apps with Xamarin Part 1",
                    Author = "Jim Wilson"
                },
                new PluralsightCourse
                {
                    Title = "Building Cross Platform Apps with Xamarin Part 2",
                    Author = "Jim Wilson"
                },
                new PluralsightCourse
                {
                    Title = "Building Google Glass Apps with C# and Xamarin",
                    Author = "Jim Wilson"
                },
                new PluralsightCourse
                {
                    Title = "Android for .NET Developers",
                    Author = "Jim Wilson"
                }
            };
            return courseList;
        }
    }
}