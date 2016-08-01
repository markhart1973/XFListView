using System.Diagnostics;
using Xamarin.Forms;

namespace XFListView
{
    class XFListViewPage1 : ContentPage
    {
        public XFListViewPage1()
        {
            var classNames = new[]
            {
                "Building Cross Platform App with Xamarin Part 1",
                "Building Cross Platform App with Xamarin Part 2",
                "Building Google Glass Apps with C# and Xamarin",
                "Android for .NET Developers"
            };

            this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

            var listView = new ListView();
            //listView.ItemsSource = classNames;
            listView.ItemsSource = PluralsightCourse.GetCourseList();

            listView.ItemSelected += (sender, args) =>
            {
                if (args == null)
                {
                    return;
                }
                Debug.WriteLine("Selected: " + args.SelectedItem);
                listView.SelectedItem = null;
            };
            this.Content = listView;
        }
    }
}