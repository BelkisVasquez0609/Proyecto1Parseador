using Antlr4.Runtime;
using Proyecto1Parseador;

Console.WriteLine("Hello, World!");

string input = "5*6+9*3-1";
Console.WriteLine($"Input {input}\n");
ICharStream stream = CharStreams.fromString(input);
aritmeticaLexer lexer = new aritmeticaLexer(stream);
CommonTokenStream tokens = new CommonTokenStream(lexer);
aritmeticaParser  parser = new aritmeticaParser(tokens);
var tree = parser.aritmetica();
Aritmetica aritmetica = new Aritmetica();//La clase que creamos
int resultado= aritmetica.Visit(tree);