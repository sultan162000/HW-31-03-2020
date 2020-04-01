using System;

namespace HW_31_03
{
    class Program
    {
        static void ToInvert(int[] number){
            for(int i = number.Length-1; i>=0;i--){
                System.Console.Write(number[i]+" ");
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            /////////////////// Задание 2
            System.Console.Write("Введите размер массива: ");
            int N = int.Parse(Console.ReadLine());
            int[] nums = new int[N];
            Random r = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = r.Next(1,100);
            }

            int max = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if(max<nums[i])max=nums[i];
            }
            System.Console.WriteLine($"Наибольшее значение массива: {max}");

            int min = nums[0];
            for (int i = 0; i < nums.Length; i++)
            {
                if(min>nums[i])min=nums[i];
            }
            System.Console.WriteLine($"Наименьшее значение массива: {min}");

            int sum = 0;
            for (int i = 0; i < nums.Length; sum += nums[i],i++);
            System.Console.WriteLine("Сумма всех чисел: "+sum);
            
            double middle = (double)sum/nums.Length;
            System.Console.WriteLine("Среднее значение: "+middle);

            System.Console.Write("Нечетные элементы: ");
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]%2!=0)System.Console.Write(nums[i]+" ");
            }
            System.Console.WriteLine();

            ///////////////// Задание 3
            ToInvert(nums);



            ///////////////// Задание 4
            Console.Write("Введите размер массива: ");
            int N1 = int.Parse(Console.ReadLine());
            int[] number = new int[N1];
            for (int i = 0; i < number.Length; i++)
            {
                number[i] = r.Next(1,100);
            }

            foreach (int item in number)
            {
                Console.Write(item+" "); 
            }
            System.Console.WriteLine();

            Console.Write("Размер нового массива: ");
            int count = int.Parse(Console.ReadLine());
            Console.Write("Введите позицию: ");
            int index = int.Parse(Console.ReadLine());
            int[] newArr = new int[count];
            for (int i = 0; i < count; i++)
            {
                
                 newArr[i]=1;
                 newArr[i]=number[index++];
            }
            foreach (int item in newArr)
            {
                System.Console.Write(item + " ");
            }

        }
        
    }
}
