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
                Console.WriteLine("Ededler duzgun daxil olunmayib ve ya fiskalarin sayi qeder eded daxil etmemisiniz!");
                Console.Write("Yeniden cehd edin: ");
                goto Point0;
            }

            Console.Write("K ededini daxil edin: ");
        point0_1:
            try
            {
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
            }
            catch (Exception)
            {
                Console.Write("K ededini duzgun daxil edin: ");
            }

            #endregion





            #region Sual 2
            Console.WriteLine("\n\n\nSual 2: ");
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
            catch (Exception e)
            {
                Console.WriteLine("elementler duzgun daxil olunmayib ve ya elementlerin sayi kifayet deyil.");
                Console.WriteLine("Yeniden cehd edin!: ");
                goto point2;
            }
            for (int i = 0; i < weight_of_paper.Length; i++)
            {
                for (int j = 1; j < weight_of_paper.Length; j++)
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






            #region Sual 4
            Console.WriteLine("\n\n\nSual 4: ");
            Console.Write("Matrisin setirlerinin ve sutunlarinin sayini ardicil olaraq daxil edin (meselen \" 1 2 \"): ");
        Point4:
            try
            {
                string[] user_input_rows = Console.ReadLine().Split(' ');
                int rows = Convert.ToInt32(user_input_rows[0]);
                int columns = Convert.ToInt32(user_input_rows[1]);
                int[,] matrix = new int[rows, columns];
                Console.WriteLine("Matrisin ededlerini daxil edin: ");
            Point4_1:
                try
                {
                    if (rows == 2)
                    {
                        string[] user_input_row1 = Console.ReadLine().Split(' ');
                        string[] user_input_row2 = Console.ReadLine().Split(' ');
                        for (int i = 0; i < matrix.GetLength(1); i++)
                        {
                            matrix[0, i] = int.Parse(user_input_row1[i]);
                            matrix[1, i] = int.Parse(user_input_row2[i]);

                        }
                        int determinant = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
                        Console.WriteLine($"Determinant beraberdir {determinant}");
                    }
                    else if (rows == 3)
                    {
                        string[] user_input_row1 = Console.ReadLine().Split(' ');
                        string[] user_input_row2 = Console.ReadLine().Split(' ');
                        string[] user_input_row3 = Console.ReadLine().Split(' ');
                        for (int i = 0; i < matrix.GetLength(1); i++)
                        {
                            matrix[0, i] = int.Parse(user_input_row1[i]);
                            matrix[1, i] = int.Parse(user_input_row2[i]);
                            matrix[2, i] = int.Parse(user_input_row3[i]);
                        }
                        int determinant = matrix[0, 0] * matrix[1, 1] * matrix[2, 2] + matrix[0, 1] * matrix[1, 2] * matrix[2, 0] + matrix[1, 0] * matrix[2, 1] * matrix[0, 2] - matrix[0, 2] * matrix[1, 1] * matrix[2, 0] - matrix[0, 0] * matrix[2, 1] * matrix[1, 2] - matrix[0, 1] * matrix[1, 0] * matrix[2, 2];
                        Console.WriteLine($"Determinant beraberdir {determinant}");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Duzgun daxil etmemisiniz. Yeniden cehd edin: ");
                    goto Point4_1;
                }
            }
            catch (Exception)
            {
                Console.Write("Duzgun daxil etmemisiniz. Yeniden cehd edin: ");
                goto Point4;
            }
            #endregion




            #region Sual 5
            Console.WriteLine("\n\n\nSual 5: ");
            Console.Write("Ateslerin sayi: ");
        point_Sual5:
            try
            {
                int n = int.Parse(Console.ReadLine());
                int[,] oyuncu_xallari = new int[4, n];
                Console.WriteLine("Her oyuncunun xallarini ardicil olaraq daxil edin: ");
            point_Sual5_2:
                try
                {
                    Console.Write("Aslan: ");
                    string[] user_input_Aslan = Console.ReadLine().Split(' ');
                    Console.Write("Adil: ");
                    string[] user_input_Adil = Console.ReadLine().Split(' ');
                    Console.Write("Nurlan: ");
                    string[] user_input_Nurlan = Console.ReadLine().Split(' ');
                    Console.Write("Sahin: ");
                    string[] user_input_Sahin = Console.ReadLine().Split(' ');
                    for (int i = 0; i < oyuncu_xallari.GetLength(1); i++)
                    {
                        oyuncu_xallari[0, i] = int.Parse(user_input_Aslan[i]);
                        oyuncu_xallari[1, i] = int.Parse(user_input_Adil[i]);
                        oyuncu_xallari[2, i] = int.Parse(user_input_Nurlan[i]);
                        oyuncu_xallari[3, i] = int.Parse(user_input_Sahin[i]);
                    }
                    int[] toplam_xallar = new int[4];
                    int[] hedef_sayi = new int[4];
                    for (int i = 0; i < oyuncu_xallari.GetLength(1); i++)
                    {
                        toplam_xallar[0] += oyuncu_xallari[0, i];
                        if (oyuncu_xallari[0, i] == 50)
                        {
                            hedef_sayi[0]++;
                        }
                        toplam_xallar[1] += oyuncu_xallari[1, i];
                        if (oyuncu_xallari[1, i] == 50)
                        {
                            hedef_sayi[1]++;
                        }
                        toplam_xallar[2] += oyuncu_xallari[2, i];
                        if (oyuncu_xallari[2, i] == 50)
                        {
                            hedef_sayi[2]++;
                        }
                        toplam_xallar[3] += oyuncu_xallari[3, i];
                        if (oyuncu_xallari[3, i] == 50)
                        {
                            hedef_sayi[3]++;
                        }
                    }
                    int max_xal = toplam_xallar[0];
                    int max_xal_index = 0;
                    int max_hedef = 0;
                    int max_hedef_index = 0;
                    for (int i = 0; i < toplam_xallar.Length; i++)
                    {
                        if (toplam_xallar[i] > max_xal)
                        {
                            max_xal = toplam_xallar[i];
                            max_xal_index = i;
                        }
                        if (hedef_sayi[i] > max_hedef)
                        {
                            max_hedef = hedef_sayi[i];
                            max_hedef_index = i;
                        }

                    }
                    switch (max_xal_index)
                    {
                        case 0:
                            Console.WriteLine($"Aslan umumi xallar uzre qalibdir: {max_xal}");
                            break;
                        case 1:
                            Console.WriteLine($"Adil umumi xallar uzre qalibdir: {max_xal}");
                            break;
                        case 2:
                            Console.WriteLine($"Nurlan umumi xallar uzre qalibdir: {max_xal}");
                            break;
                        case 3:
                            Console.WriteLine($"Sahin umumi xallar uzre qalibdir: {max_xal}");
                            break;
                    }
                    switch (max_hedef_index)
                    {
                        case 0:
                            Console.WriteLine($"Aslan hedefe deyme uzre qalibdir: {max_hedef} ({max_hedef} defe 50 xal qazanib).");
                            break;
                        case 1:
                            Console.WriteLine($"Adil hedefe deyme uzre qalibdir: {max_hedef} ({max_hedef} defe 50 xal qazanib).");
                            break;
                        case 2:
                            Console.WriteLine($"Nurlan hedefe deyme uzre qalibdir: {max_hedef} ({max_hedef} defe 50 xal qazanib).");
                            break;
                        case 3:
                            Console.WriteLine($"Sahin hedefe deyme uzre qalibdir: {max_hedef} ({max_hedef} defe 50 xal qazanib).");
                            break;
                    }

                }
                catch (Exception)
                {
                    Console.WriteLine("Duzgun daxil etmemisiniz. Yeniden cehd edin: ");
                    goto point_Sual5_2;
                }
            }
            catch (Exception)
            {
                Console.Write("Duzgun daxil etmemisiniz. Yeniden cehd edin: ");
                goto point_Sual5;
            }
            #endregion



            #region Sual 6
            Console.WriteLine("\n\n\nSual 6: ");
            Console.Write("Heftelerin sayini daxil edin: ");
        point_sual6:
            try
            {
                int number_of_weeks = int.Parse(Console.ReadLine());
                int[,] first_group = new int[number_of_weeks, 7];
                int[,] second_group = new int[number_of_weeks, 7];
                int[,] total_of_groups = new int[number_of_weeks, 7];

                Console.WriteLine("Her qrupun cedvelini daxil edin: ");
            point_sual6_2:
                try
                {

                    for (int i = 0; i < first_group.GetLength(0); i++)
                    {
                        string[] fg_user_input = Console.ReadLine().Split(' '); //fg - first group
                        for (int j = 0; j < first_group.GetLength(1); j++)
                        {
                            first_group[i, j] = int.Parse(fg_user_input[j]);
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < second_group.GetLength(0); i++)
                    {
                        string[] sg_user_input = Console.ReadLine().Split(' '); //sg - second group
                        for (int j = 0; j < second_group.GetLength(1); j++)
                        {
                            second_group[i, j] = int.Parse(sg_user_input[j]);
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Duzgun daxil etmemisiniz. Yeniden cehd edin: ");
                    goto point_sual6_2;
                }
                Console.WriteLine("\nBu qruplarin gundelik birlikdə islemesinden alinan cedvel: \n");
                for (int i = 0; i < total_of_groups.GetLength(0); i++)
                {
                    for (int j = 0; j < total_of_groups.GetLength(1); j++)
                    {
                        total_of_groups[i, j] = first_group[i, j] + second_group[i, j];
                        Console.Write(total_of_groups[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception)
            {
                Console.Write("Duzgun daxil etmemisiniz. Yeniden cehd edin: ");
                goto point_sual6;
            }

            #endregion



            #region Lesson 3, task 1 (correct answer)
            Console.WriteLine("\n\n\nTask1(lesson 3), correct answer: ");
            int[] nums_task1 = { 6, 3, 2, 9, 5, 2, 6, 7, 8, 2, 3 };
        point:
            Console.Write("Enter index of the first number form which you want to start: ");

            int index1 = int.Parse(Console.ReadLine());
            Console.Write("Enter index of the second number to which you want to sum: ");
            int index2 = int.Parse(Console.ReadLine());
            if (index1 >= nums_task1.Length || index2 >= nums_task1.Length || index1 < 1 || index2 < 1 || index1 > index2)
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
