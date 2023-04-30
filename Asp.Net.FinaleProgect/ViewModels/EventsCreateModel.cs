using Asp.Net.FinaleProgect.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Asp.Net.FinaleProgect.ViewModels
{
    public class EventsCreateModel
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public string ImgUrl { get; set; }

        public DateTime Date { get; set; }
    }
}
