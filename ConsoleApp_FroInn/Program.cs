using System;
using System.Collections.Generic;
using System.IO; 


namespace ConsoleApp_GenInn
{
    class Program
    {
        public static int n = 0;
        public static Random rnd = new Random();
        private static string response;


        static void Main(string[] a)
        {
            Console.WriteLine("Hi! Welcom GenInn");
            Console.WriteLine("------------------------\n");

            do
            {
                if (n == 5)
                {
                    Console.WriteLine("\n --------------------------");
                    Console.WriteLine("|  You failed! Goodbye =)  |");
                    Console.WriteLine(" --------------------------\n");
                    break;
                }
                else
                {
                    Make_a_choice();
                }

                if (response == "G" || response == "S" || response == "E")
                {
                    switch (response)
                    {
                        case "G":
                            Gen_Inn_and_write();
                            break;

                        case "S":
                            Create_file_is_no();
                            StreamReader r = new StreamReader("test.txt", true);
                            string list = r.ReadToEnd();
                            if (list.Length != 0)
                            {
                                Console.WriteLine("\nBegin list_________________________________________________");
                                Console.WriteLine("\n" + list);
                                Console.WriteLine("End list___________________________________________________");
                            }
                            else
                            {
                                Console.WriteLine("\n ---------------------------------------------");
                                Console.WriteLine("| Sorry, the list is blank. Generate new inn |");
                                Console.WriteLine(" ---------------------------------------------\n");
                            }
                            r.Close();
                            break;

                        case "E":
                            Console.WriteLine("\n --------------------------");
                            Console.WriteLine(" |  Have a good day! Bye! |");
                            Console.WriteLine(" --------------------------\n");
                            break;
                        }
                    }

                else
                {
                    Console.WriteLine("\n --------------------------");
                    Console.WriteLine("|Invalid character entered |");
                    Console.WriteLine("|Try again...              |");
                    Console.WriteLine(" --------------------------\n");
                }
                    n++;
            }          
            while (response != "E");
            Console.ReadLine();
        }
        
        /// <summary>
        /// из контекстного меню выбрать какой инн сгенерировать юл или фл, при генерации инн проверяется есть ли инн в реестре
        /// </summary>
        public static void Gen_Inn_and_write()
        {
            do
            {
                Console.WriteLine("\n\nHow number you want gen? Juridical or individual");
                Console.WriteLine("\nChoose an option from the following list:");
                Console.WriteLine("\tJ - Juridical");
                Console.WriteLine("\tI - Individual");
                Console.WriteLine("\nYour option? ");
                string form = Console.ReadLine();
                form = form.ToUpper();
                int number_next = Lenght_of_records_in_file();
                if (form == "J" || form == "I")
                { 
                    switch (form)
                    {
                        case "J":
                            string H = Verification_for_Juridical();

                            if (Is_Inn_in_file(H)) 
                            {
                                goto case "J";
                            }
                            {
                                StreamWriter w = new StreamWriter("test.txt", true);
                                Console.WriteLine("\n --------------------------");
                                Console.WriteLine($"| Your result:  {H} |");
                                Console.WriteLine(" --------------------------\n");
                                w.WriteLine(number_next + "\t" + H + "\t" + DateTime.Now + "\t" + "Juridical" + ";");
                                w.Close();
                                n = 5;
                                break;
                            }
                        case "I":
                            string I = Verification_for_Individual();
                            if (Is_Inn_in_file(I)) 
                            {
                                goto case "I";
                            }
                            {
                                StreamWriter w = new StreamWriter("test.txt", true);
                                Console.WriteLine("\n ----------------------------");
                                Console.WriteLine($"| Your result:  {I} |");
                                Console.WriteLine(" ----------------------------\n");
                                w.WriteLine(number_next + "\t" + I + "\t" + DateTime.Now + "\t" + "Individual" + ";");
                                w.Close();
                                n = 5;
                                break;
                            }
                    }
                }
                else if (n == 4)
                {
                    Console.WriteLine("\n --------------------------");
                    Console.WriteLine("|  You failed! Goodbye =)  |");
                    Console.WriteLine(" --------------------------\n");
                    //Console.WriteLine(n+"else if");
                    break;
                }
                else //if (n < 5)
                {
                    Console.WriteLine("\n --------------------------");
                    Console.WriteLine("|Invalid character entered |");
                    Console.WriteLine("|Try again...              |");
                    Console.WriteLine(" --------------------------\n");
                    //Console.WriteLine(n + "else");
                    n++;
                }
               
            }
            while (n < 5);
        }

        /// <summary>
        /// выбрать из предложенных вариантов сгенерировать , просмотреть, выйти 
        /// </summary>
        public static void Make_a_choice()
        {
            Console.WriteLine("\n\nDo you want to generate, to see list or to go out?");
            Console.WriteLine("\tG - Generate");
            Console.WriteLine("\tS - See list");
            Console.WriteLine("\tE - Exit");
            response = Console.ReadLine();
            response = response.ToUpper();
        }

        /// <summary>
        /// 1. создается массив в который по индексам записывается рандомный код, чтобы можно было взять каждую цифру отдельно. 2. в листе вычислятся контрольная цифра. 3. проверка , если контрольнаЯ цифра = 10. 4. из листа в переменную string 5. складывается все в одну переменную
        /// <returns>возвращает инн для юл </returns>
        public static string Verification_for_Juridical()
        {
            string endstr = null;
            string first_numb = Take_rnd_code_from_file();
            int control_J;

            int[] arrayNum = new int[2];
            arrayNum[0] = first_numb[0] - '0';
            arrayNum[1] = first_numb[1] - '0';

            List<int> numbers = new List<int>();

            for (int i = 0; i < 7; i++)
            {
                numbers.Add(rnd.Next(0, 10));
            }
            control_J = arrayNum[0] * 2 + arrayNum[1] * 4 + numbers[0] * 10 + numbers[1] * 3 + numbers[2] * 5 + numbers[3] * 9 + numbers[4] * 4 + numbers[5] * 6 + numbers[6] * 8;
            control_J = control_J % 11;
            if (control_J == 10)
            {
                control_J = 0;
            }
            foreach (int element in numbers)
            {

                endstr = endstr + element;
            }
            endstr = first_numb + endstr + control_J;

            return endstr;
        }

        /// <summary>
        /// 1. создается массив в который по индексам записывается рандомный код, чтобы можно было взять каждую цифру отдельно. 2. в листе вычислятся контрольная цифра. 3. проверка , если контрольнаЯ цифра = 10. 4. из листа в переменную string 5. складывается все в одну переменную
        /// </summary>
        /// <returns>возвращает инн для фл</returns>
        private static string Verification_for_Individual()
        {
            string endstr = null;
            string first_numb = Take_rnd_code_from_file();
            int[] arrayNum = new int[2];
            arrayNum[0] = first_numb[0] - '0';
            arrayNum[1] = first_numb[1] - '0';

            int control_1;
            int control_2;

            List<int> numbers = new List<int>();

            for (int i = 0; i < 8; i++)
            {
                numbers.Add(rnd.Next(0, 10));
            }

            control_1 = arrayNum[0] * 7 + arrayNum[1] * 2 + numbers[0] * 4 + numbers[1] * 10 + numbers[2] * 3 + numbers[3] * 5 + numbers[4] * 9 + numbers[5] * 4 + numbers[6] * 6 + numbers[7] * 8;
            control_1 = control_1 % 11;
            control_2 = arrayNum[0] * 3 + arrayNum[1] * 7 + numbers[0] * 2 + numbers[1] * 4 + numbers[2] * 10 + numbers[3] * 3 + numbers[4] * 5 + numbers[5] * 9 + numbers[6] * 4 + numbers[7] * 6 + control_1 * 8;
            control_2 = control_2 % 11;

            if (control_1 == 10)
            {
                control_1 = 0;
            }

            if (control_2 == 10)
            {
                control_2 = 0;
            }

            foreach (int element in numbers)
            {

                endstr = endstr + element;
            }

            endstr = first_numb + endstr + control_1 + control_2;

            return endstr;
        }

        /// <summary>
        /// заполняет массив кодами регионов из файла и берет рандомный. заранее надо знать размер массива и генерировать рандомную цифру в пределах массива 
        /// </summary>
        /// <returns>возвращает рандомный код из файлика кодов в string</returns>
        private static string Take_rnd_code_from_file()
        {
            string[] list = File.ReadAllLines("codes.txt");
            n = rnd.Next(1, 9);
            return list[n];
        }

        /// <summary>
        /// определеет количество строк в файле для дальнейшей нумерации 
        /// </summary>
        /// <returns> возвращает число = количество строк + 1 </returns>
        public static int Lenght_of_records_in_file()
        {
            Create_file_is_no();
            StreamReader r = new StreamReader("test.txt", true);
            string[] text = r.ReadToEnd().Split(';');
            int a = text.Length;
            r.Close();

            return a;
        }

        /// <summary>
        /// делает проверку по файлу. определяет есть ли переменная в этом файле. (contains принимает стринг)
        /// </summary>
        /// <param name="a">параметр, в который нужно подставить только что сгенерированный инн</param>
        /// <returns> булевская переменная возвращает правда ложь</returns>
        public static bool Is_Inn_in_file(string a)
        {
            Create_file_is_no();
            StreamReader r = new StreamReader("test.txt", true);
            string text = r.ReadToEnd();
            r.Close();
            return text.Contains(a);
        }

        /// <summary>
        /// если файл не создан - создать.
        /// </summary>
        public static void Create_file_is_no()
        {
            if (!File.Exists("test.txt"))
                File.Create("test.txt").Close();
        }
    }
}

 






