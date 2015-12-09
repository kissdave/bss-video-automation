using System;

namespace bss_video_automation.Model
{
    public class Video
    {
        public int VideoID { get; set; }
        public string Filename { get; set; }
        public TimeSpan DurationTime { get; set; }
        public int DurationFrames { get; set; }
        public string Title { get; set; }
        public DateTime MakeDate { get; set; }
        public string Contributors { get; set; }
        public double Rating { get; set; }
        public Category VideoCategory { get; set; }

        public Video()
        {
        }

        public Video(string filename, TimeSpan durationTime, int durationFrames, string title, DateTime makeDate, string contributors, double rating, Category videoCategory)
        {
            Filename = filename;
            DurationTime = durationTime;
            DurationFrames = durationFrames;
            Title = title;
            MakeDate = makeDate;
            Contributors = contributors;
            Rating = rating;
            VideoCategory = videoCategory;
        }

        public Video(string filename, TimeSpan durationTime, int durationFrames, string title, DateTime makeDate, string contributors, double rating, string categoryName)
        {
            Filename = filename;
            DurationTime = durationTime;
            DurationFrames = durationFrames;
            Title = title;
            MakeDate = makeDate;
            Contributors = contributors;
            Rating = rating;
            VideoCategory = new Category(categoryName);
        }

        public override string ToString()
        {
            return this.Title + "(" + this.Filename + ")";
        }
    }
}
