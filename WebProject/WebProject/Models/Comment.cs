using System;

namespace WebProject.Models
{
    public class Comment
    {
        public Customer Customer { get; set; }
        public Manifestation Manifestation { get; set; }
        public string Text { get; set; }

        private int rating;

        public int Rating
        {
            get { return rating; }
            set 
            {
                if (value < 1 || value > 5)
                {
                    throw new ArgumentOutOfRangeException("Comment rating must be between 1 and 5.");
                }

                rating = value;
            }
        }

        public Comment(Customer customer, Manifestation manifestation, string text, int rating)
        {
            Customer = customer;
            Manifestation = manifestation;
            Text = text;
            Rating = rating;
        }
    }
}