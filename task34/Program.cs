//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//
//[345, 897, 568, 234] -> 2


//Метод генерации массива со случайными числами.
int[] arrayGeneration (int size, int leftRange, int rightRange) {

    int[] arrayOfRandomNumbers = new int[size];
    Random random = new Random();
    for (int i = 0; i < arrayOfRandomNumbers.Length; i++) {
        arrayOfRandomNumbers[i] = random.Next(leftRange,rightRange);
    }
    return arrayOfRandomNumbers;
}


// Метод поиска четного числа в массиве
int FindEvenNumberInArray(int[] array){
    int evenNumberCounter = 0;
    for (int i = 0; i < array.Length; i++) {
        if(array[i] % 2 == 0){
            evenNumberCounter++;
        };
    }
    System.Console.WriteLine(evenNumberCounter);
    return evenNumberCounter;
}



int[] array = arrayGeneration(5,99,1000);
FindEvenNumberInArray(array);
