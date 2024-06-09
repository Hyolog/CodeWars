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

            // �� ����� ����: ���� ��¥�� �������� �����ϵ�, ���� ��¥�� ������ ��� ��¥ �������� ����
            var sortedCustomers = customers
                .Select((customer, index) => new { Index = index, Arrival = customer[0], Departure = customer[1] })
                .OrderBy(customer => customer.Arrival)
                .ThenBy(customer => customer.Departure)
                .ToList();

            // �ּ� ���� ����Ͽ� ���� ��� ���� ������ ����
            var rooms = new List<(int DepartureDay, int RoomNumber)>();

            int roomCount = 0;

            // ���� ��ȸ�ϸ� ���� �Ҵ�
            foreach (var customer in sortedCustomers)
            {
                int arrival = customer.Arrival;
                int departure = customer.Departure;
                int index = customer.Index;

                var availableRoom = rooms.FirstOrDefault(room => room.DepartureDay < arrival);

                if (availableRoom == default)
                {
                    // ��� ������ ������ ������ ���ο� ���� �Ҵ�
                    roomCount++;
                    rooms.Add((departure, roomCount));
                    roomAllocations[index] = roomCount;
                }
                else
                {
                    // ��� ������ ������ ������ �� ������ ����
                    rooms.Remove(availableRoom);
                    rooms.Add((departure, availableRoom.RoomNumber));
                    roomAllocations[index] = availableRoom.RoomNumber;
                }

                // ��� ��¥�� ���� ����� ����
                rooms = rooms.OrderBy(room => room.DepartureDay).ToList();
            }

            return roomAllocations;
        }
    }
}
