using System;

namespace BlazorCrudModel
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public DateTime ReleaseData { get; set; }
    }
}
