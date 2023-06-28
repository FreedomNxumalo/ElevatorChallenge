using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorChallenge.Interface
{
    public interface IElevator
    {
        void MoveElevatorToFloor(int floor);
        void AddPeopleToElevator(int count);
        void RemovePeopleOnElevator(int count);
    }
}
