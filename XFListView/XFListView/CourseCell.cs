using System.Linq.Expressions;
using Xamarin.Forms;

namespace XFListView
{
    public class CourseCell :
        ViewCell
    {
        public CourseCell()
        {
            var titleLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                FontAttributes = FontAttributes.Bold
            };
            titleLabel.SetBinding(Label.TextProperty, new Binding("Title"));


            var authLabel = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                HorizontalTextAlignment = TextAlignment.End,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            authLabel.SetBinding(Label.TextProperty, new Binding("Author"));

            this.View = new StackLayout
            {
                Children = {titleLabel, authLabel},
                Orientation = StackOrientation.Horizontal
            };
        }
    }
}