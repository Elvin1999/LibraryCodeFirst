using CodeFirst.DataAccess;
using CodeFirst.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CodeFirst
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LibraryContext context = new LibraryContext();
        public MainWindow()
        {
            InitializeComponent();

            context.Database.CreateIfNotExists();
            #region CategoryAdd
            //context.Categories.Add(new Category
            //{
            //    Name = "Adventure"

            //});
            //context.Categories.Add(new Category
            //{
            //    Name = "Science"

            //});
            //context.Categories.Add(new Category
            //{
            //    Name = "Programming"

            //});
            //context.SaveChanges();
            #endregion

            #region AuthorAdd
            //context.Authors.Add(new Author
            //{
            //    Firstname = "Linus",
            //    Lastname = "Torvalds",
            //    Age = 35
            //});
            //context.Authors.Add(new Author
            //{
            //    Firstname = "Leyla",
            //    Lastname = "Mammadova",
            //    Age = 22
            //});
            //context.Authors.Add(new Author
            //{
            //    Firstname = "Axmed",
            //    Lastname = "Axmedli",
            //    Age = 18
            //});
            //context.SaveChanges();
            #endregion

            #region BookAdd
            //context.Books.Add(new Book
            //{
            //    AuthorId = 1,
            //    CategoryId = 1,
            //    Name = "C++ Programming",
            //    Pages = 750
            //});
            //context.Books.Add(new Book
            //{
            //    AuthorId = 2,
            //    CategoryId = 1,
            //    Name = "C# Programming",
            //    Pages = 1200
            //});
            //context.Books.Add(new Book
            //{
            //    AuthorId = 1,
            //    CategoryId = 2,
            //    Name = "Rich Dad Poor Dad",
            //    Pages = 200
            //});
            //context.Books.Add(new Book
            //{
            //    AuthorId = 2,
            //    CategoryId = 2,
            //    Name = "My Best Book",
            //    Pages = 750
            //});
            //context.Books.Add(new Book
            //{
            //    AuthorId = 2,
            //    CategoryId = 3,
            //    Name = "Clean Code",
            //    Pages = 750
            //});
            //context.Books.Add(new Book
            //{
            //    AuthorId = 3,
            //    CategoryId = 2,
            //    Name = "Design Patterns",
            //    Pages = 750
            //});

            //context.SaveChanges();
            #endregion

            //context.Books.Add(new Book
            //{
            //     AuthorId=2,
            //      CategoryId=2,
            //       Pages=100,
            //       Name="MyBestBest Book"
            //});
            //context.SaveChanges();
            context.Categories.Add(new Category
            {
                 Name="Okayyy"
            });
            context.SaveChanges();


            var categories = context.Categories.ToList();         
                categoryDataGrid.ItemsSource = categories;
            var authors = context.Authors.ToList();
            authorDataGrid.ItemsSource = authors;
            var books = context.Books.ToList();
            bookDataGrid.ItemsSource = books;

        }

       
        private void categoryDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = categoryDataGrid.SelectedItem as Category;
            if (item != null)
            {
            var books = item.Books.ToList();
            bookDataGrid.ItemsSource = books;
            }

        }

        private void bookDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = bookDataGrid.SelectedItem as Book;
            if (item != null)
            {
            var author = item.Author;
            var list = new List<Author> { author };
            authorDataGrid.ItemsSource = list;
            }
        }
    }
}
