using Syncfusion.ListView.XForms;
using Syncfusion.ListView.XForms.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Header_Footer
{
	public partial class MainPage : ContentPage
	{
        BookInfoRepository viewModel = new BookInfoRepository();
        BookInfoRepository1 viewModel1 = new BookInfoRepository1();
        EmployeeViewModel viewModel2 = new EmployeeViewModel();

        public MainPage()
		{
            InitializeComponent();
            this.listView.ItemsSource = viewModel.BookInfo;
        }

        public void InfoTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            this.listView.ItemsSource = viewModel.BookInfo;
            this.listView.ItemTemplate = this.Resources["template"] as DataTemplate;
        }

        public void StatusTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            this.listView.ItemsSource = viewModel1.BookInfo1;
            this.listView.ItemTemplate = this.Resources["template"] as DataTemplate;
        }

        public void ContactsTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            this.listView.ItemsSource = viewModel2.EmployeeInfo;
            InitializeTemplate();
        }

        private void InitializeTemplate()
        {
            listView.ItemTemplate = new DataTemplate(() => { return CreateItemTemplate(); });
            listView.ItemSize = 70;
            listView.GroupHeaderSize = 60;
            listView.IsStickyGroupHeader = true;
            listView.AllowGroupExpandCollapse = true;
            listView.ItemSpacing = new Thickness(0, 0, 5, 0);
            listView.IsStickyHeader = true;
            listView.GroupHeaderTemplate = new DataTemplate(() =>
            {
                var grid = new Grid { BackgroundColor = Color.FromHex("#E4E4E4") };
                var label = new Label
                {
                    FontAttributes = FontAttributes.Bold,
                    FontSize = 22,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Start,
                    Margin = new Thickness(20, 0, 0, 0),
                };
                label.SetBinding(Label.TextProperty, new Binding("Key"));
                grid.Children.Add(label);
                return grid;
            });
        }

        private Grid CreateItemTemplate()
        {
            var gridView = new Grid();
            gridView.RowSpacing = 1;
            var row0 = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
            var row1 = new RowDefinition { Height = 1 };
            gridView.RowDefinitions.Add(row0);
            gridView.RowDefinitions.Add(row1);

            var grid = new Grid();

            var column0 = new ColumnDefinition { Width = 50 };
            var column1 = new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) };
            var column2 = new ColumnDefinition { Width = 70 };
            grid.ColumnDefinitions.Add(column0);
            grid.ColumnDefinitions.Add(column1);
            grid.ColumnDefinitions.Add(column2);

            var contactimage = new Image();
            contactimage.SetBinding(Image.SourceProperty, new Binding("EmployeeImage"));
            contactimage.HeightRequest = 50;
            contactimage.VerticalOptions = LayoutOptions.Center;
            contactimage.HorizontalOptions = LayoutOptions.Center;

            var gridview = new Grid();

            gridview.RowSpacing = 1;
            gridview.Padding = new Thickness(10, 0, 0, 0);
            gridview.VerticalOptions = LayoutOptions.Center;
            var rowdefinition0 = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
            var rowdefinition1 = new RowDefinition { Height = new GridLength(1, GridUnitType.Star) };
            gridview.RowDefinitions.Add(rowdefinition0);
            gridview.RowDefinitions.Add(rowdefinition1);

            var contactName = new Label();
            contactName.SetBinding(Label.TextProperty, new Binding("EmployeeName"));
            contactName.LineBreakMode = LineBreakMode.NoWrap;
            contactName.TextColor = Color.FromHex("#474747");
            contactName.FontSize = 20;

            var contactNumber = new Label();
            contactNumber.FontAttributes = FontAttributes.None;
            contactNumber.FontSize = 18;
            contactNumber.LineBreakMode = LineBreakMode.NoWrap;
            contactNumber.SetBinding(Label.TextProperty, new Binding("ContactNumber"));
            contactNumber.TextColor = Color.FromHex("#474747");

            var contactType = new Label();
            contactType.Margin = new Thickness(5);
            contactType.FontAttributes = FontAttributes.None;
            contactType.LineBreakMode = LineBreakMode.NoWrap;
            contactType.VerticalOptions = LayoutOptions.End;
            contactType.VerticalTextAlignment = TextAlignment.End;
            contactType.HorizontalOptions = LayoutOptions.End;
            contactType.SetBinding(Label.TextProperty, new Binding("Designation"));
            contactType.TextColor = Color.FromHex("#474747");
            contactType.FontSize = 12;

            var stackLayout = new StackLayout();
            stackLayout.HeightRequest = 1;
            stackLayout.BackgroundColor = Color.Gray;

            gridview.Children.Add(contactName, 0, 0);
            gridview.Children.Add(contactNumber, 0, 1);

            grid.Children.Add(contactimage);
            grid.Children.Add(gridview, 1, 0);

            gridView.Children.Add(grid);
            gridView.Children.Add(stackLayout, 0, 1);

            return gridView;
        }
    }
}
