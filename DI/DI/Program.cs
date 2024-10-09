using DI;
using Container = DI.Container;
var container = new Container();

container.Register<ICalculator, Calculator>();

var calculator = container.Resolve<ICalculator>();

var calculate = new Calculate(calculator);

Console.WriteLine(calculate.AddMyNumbers());