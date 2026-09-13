
// ============================================================
// C# Variables, Data Types and Operators Practice
// ============================================================


// ============================================================
// 1. VARIABLES AND DATA TYPES
// ============================================================

string name = "Anand";
int age = 25;
double salary = 60000.75;
bool isDeveloper = true;
char grade = 'A';

Console.WriteLine("===== Variables and Data Types =====");

Console.WriteLine("Name: " + name);
Console.WriteLine("Age: " + age);
Console.WriteLine("Salary: " + salary);
Console.WriteLine("Is Developer: " + isDeveloper);
Console.WriteLine("Grade: " + grade);

/*
OUTPUT:

===== Variables and Data Types =====
Name: Anand
Age: 25
Salary: 60000.75
Is Developer: True
Grade: A
*/


Console.WriteLine();


// ============================================================
// 2. VARIABLE VALUE CHANGE
// ============================================================

age = 26;
salary = 65000.50;

Console.WriteLine("===== Variable Value Change =====");

Console.WriteLine("Updated Age: " + age);
Console.WriteLine("Updated Salary: " + salary);

/*
OUTPUT:

===== Variable Value Change =====
Updated Age: 26
Updated Salary: 65000.5
*/


Console.WriteLine();


// ============================================================
// 3. VAR
// ============================================================

var city = "Delhi";
var experience = 3;

Console.WriteLine("===== var =====");

Console.WriteLine("City: " + city);
Console.WriteLine("Experience: " + experience);

/*
OUTPUT:

===== var =====
City: Delhi
Experience: 3
*/


Console.WriteLine();


// ============================================================
// 4. CONST
// ============================================================

const string country = "India";

Console.WriteLine("===== const =====");

Console.WriteLine("Country: " + country);

/*
OUTPUT:

===== const =====
Country: India
*/


Console.WriteLine();


// ============================================================
// 5. USER INPUT + TYPE CONVERSION
// ============================================================

Console.WriteLine("===== User Input =====");

Console.Write("Enter your name: ");
string userName = Console.ReadLine();

Console.Write("Enter your age: ");
int userAge = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("User Name: " + userName);
Console.WriteLine("User Age: " + userAge);

/*
EXAMPLE INPUT:

Enter your name: Anand
Enter your age: 25

OUTPUT:

User Name: Anand
User Age: 25
*/


Console.WriteLine();


// ============================================================
// 6. ARITHMETIC OPERATORS
// ============================================================

int num1 = 10;
int num2 = 20;

Console.WriteLine("===== Arithmetic Operators =====");

Console.WriteLine("Addition: " + (num1 + num2));
Console.WriteLine("Subtraction: " + (num1 - num2));
Console.WriteLine("Multiplication: " + (num1 * num2));
Console.WriteLine("Division: " + (num1 / num2));
Console.WriteLine("Remainder: " + (num1 % num2));

/*
OUTPUT:

===== Arithmetic Operators =====
Addition: 30
Subtraction: -10
Multiplication: 200
Division: 0
Remainder: 10

NOTE:
Both num1 and num2 are int.
Therefore, 10 / 20 gives 0 because of integer division.
*/


Console.WriteLine();


// ============================================================
// 7. COMPARISON OPERATORS
// ============================================================

Console.WriteLine("===== Comparison Operators =====");

Console.WriteLine("Age > 18: " + (userAge > 18));
Console.WriteLine("Age == 25: " + (userAge == 25));
Console.WriteLine("Age != 30: " + (userAge != 30));

/*
If user enters age = 25:

OUTPUT:

===== Comparison Operators =====
Age > 18: True
Age == 25: True
Age != 30: True
*/


Console.WriteLine();


// ============================================================
// 8. ASSIGNMENT OPERATORS
// ============================================================

int employeeSalary = 50000;

employeeSalary += 10000;  // 60000
employeeSalary -= 5000;   // 55000
employeeSalary *= 2;      // 110000
employeeSalary /= 2;      // 55000

Console.WriteLine("===== Assignment Operators =====");

Console.WriteLine("Final Salary: " + employeeSalary);

/*
OUTPUT:

===== Assignment Operators =====
Final Salary: 55000
*/


// ============================================================
// END
// ============================================================

