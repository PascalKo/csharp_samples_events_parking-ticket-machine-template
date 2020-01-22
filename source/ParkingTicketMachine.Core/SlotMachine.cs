using System;

namespace ParkingTicketMachine.Core
{
    public class SlotMachine
    {
        public event EventHandler<Ticket> LogTicket;
        private DateTime _startTime=DateTime.Parse("08:00");
        private DateTime _endTime=DateTime.Parse("18:00");
        private int _minAmount=50;
        private string _name;
        private int _slot;
        private Ticket _ticket;
        private double _minute = 0;

        public DateTime ValidUntil { get;private set; }



    }
}
