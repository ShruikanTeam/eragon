using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EragonStructure.Interfaces
{
    public interface IUserInput // Interaction with Win Forms
    {
        event EventHandler OnRightPressed;
        event EventHandler OnLeftPressed;
        event EventHandler OnUpPressed;
        event EventHandler OnDownPressed;
        event EventHandler OnSpacePressed; // If our character is going to attack with space for example
    }
}
