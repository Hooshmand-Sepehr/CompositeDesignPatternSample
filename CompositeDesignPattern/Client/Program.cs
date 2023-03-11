// See https://aka.ms/new-console-template for more information
using CompositeDesignPattern.Infra;
using CompositeDesignPattern.Interface;

Console.WriteLine("********** Asset Price **********");

//Creating Leaf Objects
ICustomComponent cpu = new Leaf("CPU", 10);
ICustomComponent ram = new Leaf("RAM", 10);
ICustomComponent harDisk = new Leaf("Hard Disk", 10);
ICustomComponent mouse = new Leaf("Mouse", 10);
ICustomComponent keyboard = new Leaf("Keyboard", 10);

//Creating Composite Objects
ICustomComponent motherBoard = new Composite("Board");
ICustomComponent cabinet = new Composite("cabinet");
ICustomComponent peripherals = new Composite("Peripherals");

//Whole Device
ICustomComponent computer = new Composite("Computer");

#region Creating Tree Structure

//Adding CPU and RAM in Mother Board
motherBoard.AddComponent(cpu);
motherBoard.AddComponent(ram);
//Adding Mother Board and Hard Disk in Case
cabinet.AddComponent(motherBoard);
cabinet.AddComponent(harDisk);
//Adding Mouse and Keyboard in Peripherals
peripherals.AddComponent(mouse);
peripherals.AddComponent(keyboard);
//Adding Cabinet and Peripherals in Computer
computer.AddComponent(cabinet);
computer.AddComponent(peripherals);

#endregion Creating Tree Structure

//To Sidplat the Perice of the Computer
var price = computer.CalculatePrice();
Console.WriteLine(price.ToString());

Console.ReadKey();