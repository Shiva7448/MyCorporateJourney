using System;
using System.Collections.Generic;

namespace MyCorporateJourney.Models
{
    public class JourneyEvent
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public string Description { get; set; }
        public string? SecDescription { get; set; }
        public string? TerDescription { get; set; }
        public DateTime EventDate { get; set; }
        public string? AltField { get; set; }
        public List<JourneyEventImage>? Images { get; set; }
        public List<JourneyEventAction>? Actions { get; set; }
    }

    public class JourneyEventImage
    {
        public string? Src { get; set; }
    }
    public class JourneyEventAction
    {
        public string? Text { get; set; }
        public string? Url { get; set; }
    }


}