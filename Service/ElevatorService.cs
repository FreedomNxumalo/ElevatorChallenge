using ElevatorChallenge.Enum;
using ElevatorChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorChallenge.Service
{
    public class ElevatorService
    {
        private List<Elevator> elevators;
        public ElevatorService(int numberOfElevators, int elevatorCapacity)
        {
            elevators = new List<Elevator>();
            for (int i = 0; i < numberOfElevators; i++)
            {
                var elevator = new Elevator(elevatorCapacity);
                elevators.Add(elevator);
            }
        }
        public void CallElevator(int floor, int NumberOfPeople)
        {
            Elevator nearestElevator = GetNearestAvailableElevator(floor);
            if (nearestElevator != null)
            {
                Console.WriteLine($"Calling elevator to floor {floor}");
                nearestElevator.MoveElevatorToFloor(floor);
                nearestElevator.AddPeopleToElevator(NumberOfPeople);
            }
            else
            {
                Console.WriteLine("No available elevator");
            }
        }
        private Elevator GetNearestAvailableElevator(int floor)
        {
            Elevator nearestElevator = null;
            int minDistance = int.MaxValue;
            foreach (var elevator in elevators)
            {
                if (elevator.CurrentDirection == ElevatorDirection.None)
                {
                    int distance =elevator.CurrentFloor - floor;
                    if (distance < minDistance)
                    {
                        nearestElevator = elevator;
                        minDistance = distance;
                    }
                }
            }
            return nearestElevator;
        }
        public int GetElevator(int elevatorIndex)
        {
            if (elevatorIndex >= 0 && elevatorIndex < elevators.Count)
            {
                return elevators[elevatorIndex].NumberOfPeople;
            }
            return 0;
        }
        public void ElevatorStatus()
        {
            foreach (var elevator in elevators)
            {
                Console.WriteLine($"Elevator at floor {elevator.CurrentFloor} | Direction: {elevator.CurrentDirection} | People Count: {elevator.NumberOfPeople}/{elevator.ElevatorCapacity}");
            }
        }
    }
}
