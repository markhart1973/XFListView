using Xamarin.Forms;

namespace XFListView
{
    class XFListViewPage2 : ContentPage
    {
        public XFListViewPage2()
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

            var cell = new DataTemplate(typeof(TextCell));
            //cell.SetBinding(TextCell.TextProperty, new Binding("."));
            cell.SetBinding(TextCell.TextProperty, new Binding("Title"));
            cell.SetBinding(TextCell.DetailProperty, new Binding("Author"));
            cell.SetValue(TextCell.TextColorProperty, Color.Red);
            cell.SetValue(TextCell.DetailColorProperty, Color.Yellow);

            listView.ItemTemplate = cell;

            this.Content = listView;
        }
    }
}