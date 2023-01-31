//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//
//[3, 7, 23, 12] -> 19
//
//[-4, -6, 89, 6] -> 0


//Метод генерации массива случайных чисел
int[] arrayGeneration (int size, int leftRange, int rightRange) {

    int[] arrayOfRandomNumbers = new int[size];
    Random random = new Random();
    for (int i = 0; i < arrayOfRandomNumbers.Length; i++) {
        arrayOfRandomNumbers[i] = random.Next(leftRange,rightRange);
    }
    return arrayOfRandomNumbers;
}


// Метод поиска нечетных чисел
int FindingOddNumbers(int[] array){
    int oddNumbersCounter = 0;
    for (int i = 0; i < array.Length; i++) {
        if(array[i] % 2 != 0){
            oddNumbersCounter++;
        };
    }
    System.Console.WriteLine(oddNumbersCounter);
    return oddNumbersCounter;
}



int[] arrayRandomNumbers = arrayGeneration(5, -10, 10);
FindingOddNumbers(arrayRandomNumbers);