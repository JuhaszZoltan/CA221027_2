using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA221027_2
{
    internal class Book
    {
        private string author;
        private string title;
        private int yearOfPublication;
        private float price;

        public string Author
        {
            get => author;
            set
            {
                if (value.Length < 3 || value.Length > 50)
                    throw new Exception("error");
                author = value;
            }
        }
        public string Title
        {
            get => title;
            set
            {
                if (value.Length < 3 || value.Length > 50)
                    throw new Exception("error");
                title = value;
            }
        }
        public int YearOfPublication
        {
            get => yearOfPublication;
            set
            {
                if (value < 1910 || value > DateTime.Today.Year)
                    throw new Exception("error");
                yearOfPublication = value;
            }
        }
        public float Price
        {
            get => price;
            set
            {
                if (value < 0 || value > 15000)
                    throw new Exception("error");
                if (value % 5 != 0)
                    throw new Exception("error");
                price = value;
            }
        }

        public Genre Genre { get; set; }
    }

    internal enum Genre
    {
        Action,
        Childrens,
        Dystopian,
        Fantasy,
        HistoricalFiction,
        Horror,
        MagicalRealism,
        Mystery,
        Romance,
        ScienceFiction,
        Thriller,
        YoungAdult,
    }
}
