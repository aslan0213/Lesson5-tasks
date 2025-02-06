using System.Collections.Immutable;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace lesson5_dechode_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Sual 1
            Console.WriteLine("Sual 1: ");
            Console.Write("Fiska sayini daxil edin: ");
            int number_of_chips = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{number_of_chips} dene eded daxil edin: ");
            int[] numbers_on_chips = new int[number_of_chips];
            Point0:
            try
            {
                string[] user_input = Console.ReadLine().Split(' ');
                for (int i = 0; i < number_of_chips; i++)
                {
                    numbers_on_chips[i] = Convert.ToInt32(user_input[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Edeler duzgun daxil olunmayib ve ya fiskalarin sayi qeder eded daxil etmemisiniz!");
                Console.Write("Yeniden cehd edin: ");
                goto Point0;
            }
            Console.Write("K ededini daxil edin: ");
            int k = Convert.ToInt32(Console.ReadLine());
            double number_of_chips_derrived_by_k = 0;
            for (int i = 0; i < number_of_chips; i++)
            {
                if (numbers_on_chips[i] % k == 0)
                {
                    number_of_chips_derrived_by_k++;
                }
            }
            Console.WriteLine($"K ya bolunenlerin sayi: {number_of_chips_derrived_by_k}");
            double percent = number_of_chips_derrived_by_k * 100 / number_of_chips;
            Console.WriteLine($"Teskil etdiyi faiz: {percent.ToString("F2")}");
            #endregion






            #region Sual 2
            Console.WriteLine("\n\n\n Sual 2: ");
            Console.Write("Massivin uzunlugunu daxil edin: ");
            int number_of_elements = Convert.ToInt32(Console.ReadLine());
            Console.Write($"{number_of_elements} dene eded daxil edin: ");
            double[] nums = new double[number_of_elements];
            Point:
            try
            {
                string[] user_input = Console.ReadLine().Split(' ');
                for (int i = 0; i < number_of_elements; i++)
                {
                    nums[i] = Convert.ToDouble(user_input[i]);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Edeler duzgun daxil olunmayib ve ya elementlerin sayi kifayet deyil!");
                Console.Write("Yeniden cehd edin: ");
                goto Point;
            }
            double minvalue = nums[0];
            double maxvalue = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > maxvalue)
                {
                    maxvalue = nums[i];
                }
                else if (nums[i] < minvalue)
                {
                    minvalue = nums[i];
                }
            }
            Console.WriteLine($"Maksimum element: {maxvalue}");
            Console.WriteLine($"Minimum value: {minvalue}");
            double difference = (maxvalue + minvalue) / (maxvalue - minvalue);
            Console.WriteLine(difference.ToString("F2"));
            #endregion




            #region Sual 3
            Console.WriteLine("\n\n\nSual 3:  ");
            point1:
            Console.Write("Qruplarin sayi (tek eded): ");
            int num_of_groups = Convert.ToInt32(Console.ReadLine());
            if (num_of_groups % 2 == 0)
            {
                Console.WriteLine("Zehmet olmasa tek eded daxil edin!");
                goto point1;
            }
            Console.Write("Her qrupun tehvil verdiyi makulatura cekisi(kg): ");
            double[] weight_of_paper = new double[num_of_groups];
            point2:
            try
            {
                string[] user_input = Console.ReadLine().Split(" ");
                for (int i = 0; i < num_of_groups; i++)
                {
                    weight_of_paper[i] = Convert.ToDouble(user_input[i]);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("elementler duzgun daxil olunmayib ve ya elementlerin sayi kifayet deyil.");
                Console.WriteLine("Yeniden cehd edin!: ");
                goto point2;
            }
            for (int i = 0; i<weight_of_paper.Length; i++)
            {
                for (int j = 1; j<weight_of_paper.Length; j++)
                {
                    if (weight_of_paper[i] > weight_of_paper[j])
                    {
                        weight_of_paper[i] = weight_of_paper[i] + weight_of_paper[j];
                        weight_of_paper[j] = weight_of_paper[i] - weight_of_paper[j];
                        weight_of_paper[i] = weight_of_paper[i] - weight_of_paper[j];
                    }
                }
            }
            int index_of_median = weight_of_paper.Length / 2 + 1;
            Console.WriteLine($"Orta ceki: {weight_of_paper[index_of_median].ToString("F2")}");
            #endregion




            #region Lesson 3, task 1 (correct answer)
            Console.WriteLine("\n\n\nTask1(lesson 3), correct answer: ");
            int[] nums_task1 = { 6, 3, 2, 9, 5, 2, 6, 7, 8, 2, 3 };
            point:
            Console.Write("Enter index of the first number form which you want to start: ");

            int index1 = int.Parse(Console.ReadLine());
            Console.Write("Enter index of the second number to which you want to sum: ");
            int index2 = int.Parse(Console.ReadLine());
            if (index1 >= nums_task1.Length || index2 >= nums_task1.Length || index1 < 1 || index2 < 1 || index1>index2)
            {
                Console.WriteLine($"Please enter index from 1 to {nums_task1.Length} correctly");
                goto point;
            }
            else
            {
                int sum = 0;
                for (int i = index1; i <= index2; i++)
                {
                    sum += nums_task1[i - 1];
                }
                Console.WriteLine($"sum of elements in array from {index1}th to {index2}th is {sum}");
            }
            #endregion
        }
    }
}
