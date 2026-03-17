using apbd_cw1_git_s31225;

Console.WriteLine("Connected communicate from main and feature!");

Console.WriteLine("Conflict from main branch"); // Exercise 1 done

Console.WriteLine("Conflict from feature branch!"); // Exercise 1 done

Console.WriteLine("Starting StatisticsHelper...");
int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
double average = StatisticsHelper.CalculateAverage(array);
Console.WriteLine("Average value: " + average);

Console.WriteLine("Starting CalculateMax...");
double max = StatisticsHelper.CalculateMax(array);
Console.WriteLine("Max value: " + max);

Console.WriteLine("Starting CalculateMin...");
double min = StatisticsHelper.CalculateMin(array);
Console.WriteLine("Max value: " + min);