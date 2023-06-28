using ElevatorChallenge.Enum;
using ElevatorChallenge.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorChallenge.Models
{
    public class Elevator: IElevator
    {
        public int CurrentFloor { get; set; }
        public ElevatorDirection CurrentDirection { get; set; }
        public int ElevatorCapacity { get; set; }
        public int NumberOfPeople { get; set; }

        public Elevator(int capacity)
        {
            CurrentFloor = 1;
            CurrentDirection = ElevatorDirection.None;
            ElevatorCapacity = capacity;
            NumberOfPeople = 0;
        }

        public void MoveElevatorToFloor(int floor)
        {
            CurrentDirection = floor > CurrentFloor ? ElevatorDirection.Up : ElevatorDirection.Down;
            Console.WriteLine($"Elevator moving {CurrentDirection} from floor {CurrentFloor} to floor {floor}");
            CurrentFloor = floor;
            Console.WriteLine($"Elevator arrived at floor {CurrentFloor}");
        }

        public void AddPeopleToElevator(int count)
        {
            if (NumberOfPeople + count <= ElevatorCapacity)
            {
                NumberOfPeople += count;
                Console.WriteLine($"{count} people entered the elevator");
            }
            else
            {
                Console.WriteLine($"Cannot accommodate {count} people. Elevator is full.");
            }
        }
        public void RemovePeopleOnElevator(int count)
        {
            if (NumberOfPeople - count >= 0)
            {
                NumberOfPeople -= count;
                Console.WriteLine($"{count} people exited the elevator");
            }
            else
            {
                Console.WriteLine($"Invalid operation. Trying to remove {count} people, but elevator has only {NumberOfPeople} people.");
            }
        }
    }
}
