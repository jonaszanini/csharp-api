using API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public class MockCommanderRepo : ICommanderRepo
    {
        private readonly List<Command> commandList = new List<Command>
            {
                new Command { Id = 0, HowTo = "Boil", Line = "Boil", Platform = "Kettle & Pan" },
                new Command { Id = 1, HowTo = "Cut", Line = "Cut", Platform = "Cut" },
                new Command { Id = 2, HowTo = "Make", Line = "Make", Platform = "Make" }
            };

        public void CreateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteCommand(Command cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Command> GetAllCommands()
        {
            return this.commandList;
        }

        public Command GetCommandById(int Id)
        {
            Command command = new Command();

            command = commandList.Find(command => command.Id == Id);

            return command;
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateCommand(Command cmd)
        {
            throw new NotImplementedException();
        }
    }
}
