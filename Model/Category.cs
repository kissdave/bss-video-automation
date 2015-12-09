using System;

namespace bss_video_automation.Model
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public Category()
        {
        }

        public Category(string name)
        {
            this.CategoryName = name;
        }
    }
}