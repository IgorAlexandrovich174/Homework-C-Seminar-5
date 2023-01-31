//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//
//[3 7 22 2 78] -> 76



//Метод генерации случайных вещественных чисел
double[] arrayGeneration (int size, int leftRange, int rightRange) {

    double[] arrayOfRandomNumbers = new double[size];
    Random random = new Random();
    for (int i = 0; i < arrayOfRandomNumbers.Length; i++) {
        arrayOfRandomNumbers[i] = Math.Round(random.Next(leftRange,rightRange) + random.NextDouble(), 3);
    }
    return arrayOfRandomNumbers;
}


//Метод поиска разницы между минимальным и максимальным элементами
double DifferenceCalculation(double[] array) {
    
    double min = array[0];
    double max = 0;

    for (int i = 0; i < array.Length; i++) {
            if(min > array[i]){
                min = array[i];
            }
            if(max < array[i]) {
                max = array[i];
            }
    }
    double result = Math.Round(max - min,3);
    System.Console.WriteLine("Минимальный элемент: " + min);
    System.Console.WriteLine("Максимальный элемент: " + max);
    System.Console.WriteLine("Разница между минимальным и максимальным элементами: " + result);
    return result;
}



double[] array = arrayGeneration(5,-5,5);
DifferenceCalculation(array);