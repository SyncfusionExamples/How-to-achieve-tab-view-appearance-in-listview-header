using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Header_Footer
{
    public class BookInfoRepository1
    {
        private ObservableCollection<BookInfo> bookInfo;

        #region Properties

        public ObservableCollection<BookInfo> BookInfo1
        {
            get { return bookInfo; }
            set { this.bookInfo = value; }
        }
        
        #endregion

        #region Constructor

        public BookInfoRepository1()
        {
            GenerateBookInfo();
        }

        #endregion

        #region Properties

        internal void GenerateBookInfo()
        {
            bookInfo = new ObservableCollection<BookInfo>();
            bookInfo.Add(new BookInfo() { BookName = "Xamarin.Forms", BookDescription = "1000 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Windows Store Apps", BookDescription = "330 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Agile Software Development", BookDescription = "760 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Assembly Language", BookDescription = "470 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Cryptography in .NET", BookDescription = "850 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Entity Framework Code First", BookDescription = "500 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Localization for .NET", BookDescription = "700 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "380 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "270 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "600 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Neural Networks Using C#", BookDescription = "390 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Visual Studio Code", BookDescription = "400 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Android Programming", BookDescription = "650 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "iOS Succinctly", BookDescription = "250 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Visual Studio 2015", BookDescription = "200 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Xamarin.Forms", BookDescription = "800 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Windows Store Apps", BookDescription = "480 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Agile Software Development", BookDescription = "270 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Assembly Language", BookDescription = "830 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Cryptography in .NET", BookDescription = "390 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Entity Framework Code First", BookDescription = "130 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Localization for .NET", BookDescription = "830 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Object-Oriented Programming in C#", BookDescription = "520" });
            bookInfo.Add(new BookInfo() { BookName = "C# Code Contracts", BookDescription = "490 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Machine Learning Using C#", BookDescription = "950 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Neural Networks Using C#", BookDescription = "590 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Visual Studio Code", BookDescription = "650 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Android Programming", BookDescription = "350 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "iOS Succinctly", BookDescription = "750 Books sold" });
            bookInfo.Add(new BookInfo() { BookName = "Visual Studio 2015", BookDescription = "360 Books sold" });
        }

        #endregion
    }
}
