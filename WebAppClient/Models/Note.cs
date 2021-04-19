using System;

namespace WebAppClient.Models
{
    public class Note
    {
        public int Id { get; set; }
        public int BarberId { get; set; }
        public int ConsumerId { get; set; }
        public int? HaircutId { get; set; }
        public DateTime DateVisit { get; set; }
    }
}