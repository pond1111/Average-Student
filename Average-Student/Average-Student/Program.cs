using System;

namespace StudentWeight
{
    class Program
    {
        static void Main(string[] args)
        {
            // ประกาศตัวแปรสำหรับเก็บชื่อและน้ำหนักของนักศึกษา 5 คน
            string[] names = new string[5];
            float[] weights = new float[5];

            // รับข้อมูลชื่อและน้ำหนักของนักศึกษา 5 คน
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter name of student {0}: ", i + 1);
                names[i] = Console.ReadLine();
                Console.Write("Enter weight of student {0} in kg: ", i + 1);
                weights[i] = float.Parse(Console.ReadLine());
            }

            // แสดงค่าเฉลี่ยน้ำหนักของนักศึกษาทั้งหมด
            float sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum += weights[i];
            }
            float average = sum / 5;
            Console.WriteLine("Average weight of all students is {0:F2} kg.", average);

            // หานักศึกษาที่มีน้ำหนักมากที่สุด
            float maxWeight = float.MinValue;
            string maxName = "";
            for (int i = 0; i < 5; i++)
            {
                if (weights[i] > maxWeight)
                {
                    maxWeight = weights[i];
                    maxName = names[i];
                }
            }
            Console.WriteLine("{0} has the highest weight of {1:F2} kg.", maxName, maxWeight);

            // หานักศึกษาที่มีน้ำหนักน้อยที่สุด
            float minWeight = float.MaxValue;
            string minName = "";
            for (int i = 0; i < 5; i++)
            {
                if (weights[i] < minWeight)
                {
                    minWeight = weights[i];
                    minName = names[i];
                }
            }
            Console.WriteLine("{0} has the lowest weight of {1:F2} kg.", minName, minWeight);

            // แสดงชื่อ รหัส ของผู้พัฒนาโปรแกรม
            Console.WriteLine("Developed by [Aphun Doungchunkloi] (Student ID: [643450092-1])");
        }
    }
}