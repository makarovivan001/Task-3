using System;
using HomeWork_Makarov_Ivan_number_3;
using HomeWork_Makarov_Ivan_number_3._1;

class program
{
    static void Main(string[] args)
    {
        bool personGet;
        IBaseArray[] arrays = new IBaseArray[3];
        Console.WriteLine("Вы введёте массив с клавиатуры?:  да/нет");
        personGet = personChoose();
        static bool personChoose()
        {
            bool personschoose = false;
            bool correct_or_incorrect_answer_is_incorrect = true;
            string input;
            while (correct_or_incorrect_answer_is_incorrect)
            {
                input = Console.ReadLine();
                if (input == "да")
                {
                    personschoose = true;
                    correct_or_incorrect_answer_is_incorrect = false;
                }
                else if (input == "нет")
                {
                    personschoose = false;
                    correct_or_incorrect_answer_is_incorrect = false;
                }
                else
                {
                    Console.WriteLine("Ответ некорректен, ответьте по-другому");
                }
            }
            return personschoose;
        }
        arrays[0] = new OneDimensionalArray(personGet);
        arrays[1] = new TwoDimensionalArray(personGet);
        arrays[2] = new SteppedArray(personGet);
        for (int i = 0; i < arrays.Length; i++)
        {
           
            Console.WriteLine("Напечатанный массив: ");
            arrays[i].Print();
            Console.WriteLine("Среднее значение элементов массива: ");
            Console.WriteLine(arrays[i].GetAverage());

        }

        
        
        Week week = new Week();
        IPrinter printer_4 = week;
        

        OneDimensionalArray oneDimensionalArray = new OneDimensionalArray(personGet);
        IBaseArray baseArray = oneDimensionalArray;
        IPrinter printer = oneDimensionalArray;
        

        
        TwoDimensionalArray twoDimensionalArray = new TwoDimensionalArray(personGet);
        IBaseArray baseArray_1 = twoDimensionalArray;
        IPrinter printer_1 = twoDimensionalArray;
        
        SteppedArray steppedArray = new SteppedArray(personGet);
        IBaseArray baseArray_2 = steppedArray;
        IPrinter printer_2 = steppedArray;

        IPrinter[] days = new IPrinter[4];
        days[0] = week;
        days[1] = oneDimensionalArray;
        days[2] = twoDimensionalArray;
        days[3] = steppedArray;
        for (int i = 0; i < days.Length; i++)
        {
            days[i].Print();

        }





        Console.ReadKey();

    }
}