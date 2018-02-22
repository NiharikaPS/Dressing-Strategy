using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pajamas
{
    public class Command
    {
        public Command()
        {
           
        }
        public int Id { get; set; }
        public string Description { get; set; }
        public string HotResponse { get; set; }
        public string ColdResponse { get; set; }


        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            var command = obj as Command;
            return command.Id == Id
               && command.Description == Description
               && command.HotResponse == HotResponse
               && command.ColdResponse == ColdResponse;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
