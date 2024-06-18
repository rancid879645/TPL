using TPL_example;

var noTPL = new NoTPL();
var TPL = new TPL();

Console.WriteLine("Hello, World! it's TPL :)");

Console.WriteLine("without TPL:");
noTPL.Request();

Console.WriteLine("with TPL:");
TPL.Request();



