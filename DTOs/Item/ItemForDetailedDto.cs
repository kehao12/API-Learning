using System.Collections.Generic;
using Learning.API.DTOs.File;

namespace Learning.API.DTOs.Item
{
    public class ItemForDetailedDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int LessonId { get; set; }
        public FileForDetailedDto Files { get; set; }
                public int FileId { get; set; }
        public double? Duration {get; set;}
               public int Status { get; set; }
                       public int Preview { get; set; }


    }
}