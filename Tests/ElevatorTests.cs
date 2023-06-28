using ElevatorChallenge.Models;
using ElevatorChallenge.Service;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorChallenge.Tests
{
    [TestFixture]
    public class ElevatorTests
    {
        [Test]
        public void AddPeople_ShouldIncreaseNumberOfPeople()
        {
            // Arrange
            Elevator elevator = new Elevator(10);
            // Act
            elevator.AddPeopleToElevator(5);
            // Assert
            Assert.AreEqual(5, elevator.NumberOfPeople);
        }

        [Test]
        public void RemovePeople_ShouldDecreaseNumberOfPeople()
        {
            // Arrange
            Elevator elevator = new Elevator(10);
            elevator.AddPeopleToElevator(7);
            // Act
            elevator.RemovePeopleOnElevator(3);
            // Assert
            Assert.AreEqual(4, elevator.NumberOfPeople);
        }
        [Test]
        public void CallElevator_ShouldAddPeopleToNearestElevator()
        {
            // Arrange
            ElevatorService elevatorService = new ElevatorService(2, 10);
            // Act
            elevatorService.CallElevator(5, 8);
            // Assert
            Assert.AreEqual(8, elevatorService.GetElevator(0));
        }
    }
}
