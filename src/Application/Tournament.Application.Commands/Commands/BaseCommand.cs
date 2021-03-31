using System;

namespace Tournament.Application.Commands.Commands
{
    public class BaseCommand
    {
        private Guid? _id;
        public Guid? Id
        {
            get { return _id == Guid.Empty ? null : _id; }
            set { _id = value; }
        }   
    }
}