using System;
using ForPractise15.Util.Extention;
using ForPractise15.Util.Enum;

namespace ForPractise15
{
    class Program
    {
        
        static void Main(string[] args)
        {
            TryAgain:

            Console.WriteLine("Please choise \n1 for Odd \n2 for Even \n3 for ContainDigit \n4 for Capitalize method \n5 for Get index");
            int input = CheckOut();

            switch (input)
            {
                case (int)Enums.Check.Odd:
                    ForOdd();
                    goto TryAgain;
                case (int)Enums.Check.Even:
                    ForEven();
                    goto TryAgain;
                case (int)Enums.Check.ContainDigit:
                    ForContainDigit();
                    goto TryAgain;
                case (int)Enums.Check.Capitalize:
                    ForCapitalize();
                    goto TryAgain;
                case (int)Enums.Check.GetIndex:
                    ForGetIndex();
                    goto TryAgain;
                default:
                    Console.WriteLine("Invalid input \nPlease try Again !");
                    goto TryAgain;
            }


        }

        /// <summary>
        /// ededin odd olub olmadiqini yoxlayir
        /// </summary>
        public static void ForOdd()
        {
            Console.Clear();
            Console.Write("Please enter number : ");
            int num = CheckOut();

            if (num.IsOdd())
            {
                Console.WriteLine($"{num} is odd number !\n");
            }
            else
            {
                Console.WriteLine($"{num} is not odd number !\n");
            }
        }

        /// <summary>
        /// ededin Even olub olmadiqini yoxlayir !
        /// </summary>
        public static void ForEven()
        {
            Console.Clear();
            Console.Write("Please enter number : ");
            int num = CheckOut();

            if (num.IsEven())
            {
                Console.WriteLine($"{num} is even number !\n");
            }
            else
            {
                Console.WriteLine($"{num} is not Even number !\n");
            }
        }

        /// <summary>
        /// string daxilinde reqem olub olmadiqini yoxlayir !
        /// </summary>
        public static void ForContainDigit()
        {
            Console.Clear();
            Console.Write("Please enter wordset : ");
            string str = Console.ReadLine();

            if (str.IsContainsDigit())
            {
                Console.WriteLine("There is digit charactre in this wordset ");
            }
            else
            {
                Console.WriteLine("There is not digit charactre in this wordset");
            }
        }

        /// <summary>
        /// Capitalize methodunun costom versiyasi
        /// </summary>
        public static void ForCapitalize()
        {
            Console.Clear();
            Console.Write("Please enter wordset : ");
            string str = Console.ReadLine();

            Console.WriteLine(str.IsCaptalize());

        }

        /// <summary>
        /// gonderilen char -in stringde hansi indexlerde yerlewdiyini gosterir
        /// </summary>
        public static void ForGetIndex()
        {
            Console.Clear();
            Console.Write("Please enter wordset : ");
            string str = Console.ReadLine();
            Console.Write("Please enter charackter :");
            char chr = Convert.ToChar(Console.ReadLine());

            int[] array = str.GetValueIndex(chr);

            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " , ");

            }
            Console.Write("}\n");

        }

        /// <summary>
        /// int type bir numberi conver prosesini try catch daxilinde aparir
        /// </summary>
        /// <returns>int type xetasiz convert olunan ededi qaytarir !</returns>
        public static int CheckOut()
        {
            int number;
            TryAgain:
            try
            {
                number = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("Invalid input \nplease try again !\n");
                goto TryAgain;
            }

            return number;
        }
    }
}
