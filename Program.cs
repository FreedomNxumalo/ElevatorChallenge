using ElevatorChallenge.Service;
using System;

namespace ElevatorChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ElevatorService elevatorController = new ElevatorService(2, 10);
            // Call elevator to floor 5 with 8 people
            elevatorController.CallElevator(5, 8);
            // Display elevator status
            elevatorController.ElevatorStatus();
            // Call elevator to floor 3 with 6 people
            elevatorController.CallElevator(3, 6);
            // Display elevator status
            elevatorController.ElevatorStatus();
            // Call elevator to floor 2 with 5 people
            elevatorController.CallElevator(2, 5);
            // Display elevator status
            elevatorController.ElevatorStatus();
            Console.ReadLine();
        }
    }
}
