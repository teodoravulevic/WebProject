using System;
using WebProject.Models.Enums;

namespace WebProject.Models
{
    public class Ticket
    {
        public string Id { get; set; }
        public Manifestation Manifestation { get; set; }
        public DateTime EventDateTime { get; set; }
        public double Price { get; set; }
        public Customer Customer { get; set; }
        public StatusEnum Status { get; set; }
        public TicketTypeEnum Type { get; set; }

        public Ticket(Manifestation manifestation, Customer customer, TicketTypeEnum type)
        {
            Id = Guid.NewGuid().ToString("N").Substring(0, 10);
            Manifestation = manifestation;
            EventDateTime = Manifestation.DateTime;
            switch (type)
            {
                case TicketTypeEnum.REGULAR:
                    break;
                case TicketTypeEnum.VIP:
                    break;
                case TicketTypeEnum.FANPIT:
                    break;
            }
            Status = StatusEnum.RESERVED;
        }
    }
}