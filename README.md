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
public partial class Form1 : Form
{
    int startingMileage;
    int endingMileage;
    double milesTraveled;
    double reimburseRate = .39;
    double amountOwed;
    public Form1() {
    InitializeComponent();
    }
    private void button1_Click(object sender, EventArgs e){
        startingMileage = (int) numericUpDown1.Value;
        endingMileage = (int)numericUpDown2.Value;
        if (startingMileage <= endingMileage){
            milesTraveled = endingMileage -= startingMileage;
            amountOwed = milesTraveled *= reimburseRate;
            label4.Text = “$” + amountOwed;
        } else {
            MessageBox.Show( 
            “The starting mileage must be less than the ending mileage”, 
            “Cannot Calculate Mileage”);
        } 
    }
}
```