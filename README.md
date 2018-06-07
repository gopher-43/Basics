# Basics
## New
``` cs
byte days = 365; //сколько дней в году
int hours = 24; // часов в дне
bool isDone = yes;

short rpm = 33;

short y = 10000;

string months = "12";

int lUnderTheSea = 20000;
```

``` csharp
public class Form1
{
    int startingMileage;
    int endingMileage;
    double milesTraveled;
    double reimburseRate = .39;
    double amountOwed;

    private void Compute(){
        startingMileage = System.Console.ReadLine();
        endingMileage = System.Console.ReadLine();
        if (startingMileage <= endingMileage){
            milesTraveled = endingMileage -= startingMileage;
            amountOwed = milesTraveled *= reimburseRate;
            Console.WriteLine(“$” + amountOwed);
        } else {
            System.Console.WritrLine(“The starting mileage must be less than
            the ending mileage, Cannot Calculate Mileage”);
        } 
    }
}
```
