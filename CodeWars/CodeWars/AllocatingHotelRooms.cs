using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    /// <see cref="https://www.codewars.com/kata/6638277786032a014d3e0072/train/csharp"/>
    [TestClass]
    public class AllocatingHotelRooms
    {
        [TestMethod]
        public void Test()
        {

        }

        public static int[] AllocateRooms(int[][] customers)
        {
            int n = customers.Length;

            int[] roomAllocations = new int[n];

            // 고객 목록을 정렬: 도착 날짜를 기준으로 정렬하되, 도착 날짜가 같으면 출발 날짜 기준으로 정렬
            var sortedCustomers = customers
                .Select((customer, index) => new { Index = index, Arrival = customer[0], Departure = customer[1] })
                .OrderBy(customer => customer.Arrival)
                .ThenBy(customer => customer.Departure)
                .ToList();

            // 최소 힙을 사용하여 현재 사용 중인 객실을 추적
            var rooms = new List<(int DepartureDay, int RoomNumber)>();

            int roomCount = 0;

            // 고객을 순회하며 객실 할당
            foreach (var customer in sortedCustomers)
            {
                int arrival = customer.Arrival;
                int departure = customer.Departure;
                int index = customer.Index;

                var availableRoom = rooms.FirstOrDefault(room => room.DepartureDay < arrival);

                if (availableRoom == default)
                {
                    // 사용 가능한 객실이 없으면 새로운 객실 할당
                    roomCount++;
                    rooms.Add((departure, roomCount));
                    roomAllocations[index] = roomCount;
                }
                else
                {
                    // 사용 가능한 객실이 있으면 그 객실을 재사용
                    rooms.Remove(availableRoom);
                    rooms.Add((departure, availableRoom.RoomNumber));
                    roomAllocations[index] = availableRoom.RoomNumber;
                }

                // 출발 날짜로 객실 목록을 정렬
                rooms = rooms.OrderBy(room => room.DepartureDay).ToList();
            }

            return roomAllocations;
        }
    }
}
