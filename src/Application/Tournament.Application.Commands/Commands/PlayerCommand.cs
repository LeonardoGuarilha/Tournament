using System;

namespace Tournament.Application.Commands.Commands
{
    public class PlayerCommand : BaseCommand
    {
        public string Name { get; set; }

        private Guid? _teamId;
        public Guid? TeamId
        {
            get { return _teamId == Guid.Empty? null : _teamId; }
            set { _teamId = value; }
        }
    }
}