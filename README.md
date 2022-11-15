# Proyecto #1 Parseador - Belkis Vásquez 1085273

## Proceso
1. Descargar ANTLR4 plugin para Visual Studio Code
2. Descargar Java JDK versión 11 o mayor
3. Configurar en el settings.json 
4. Crear un proyecto de consola c# en Visual Studio
5. Abrir el proyecto de consola en Visual Studio Code
6. Crear el archivo con extensión .g4 Y añadir la gramatica
- Se generaran los archivos necesarios
7. Incorporar esos archivos en la visualización de la solución de Visual Studio
8. Agregar el NUGGET de ANTLR4.Runtime.Standar 4.9.2 (Porque los archivos estan generados en esa versión)
9. Se crea una nueva clase y esta hereda de `aritmeticaBaseVisitor<int>`
10. Agregar el siguiente codigo en el program.cs
`using Antlr4.Runtime;
using Proyecto1Parseador;

`Console.WriteLine("Hello, World!");`
`string input = "5*6+9*3-1";`
`Console.WriteLine($"Input {input}\n");`
`ICharStream stream = CharStreams.fromString(input);`
`aritmeticaLexer lexer = new aritmeticaLexer(stream);`
`CommonTokenStream tokens = new CommonTokenStream(lexer);`
`aritmeticaParser  parser = new aritmeticaParser(tokens);`
`var tree = parser.aritmetica();`
`Aritmetica aritmetica = new Aritmetica();//La clase que creamos`
`int resultado= aritmetica.Visit(tree);`

11. Se hace override a los metodos **VisitAritmetica, VisitExpresion, VisitFactor, VisitTermino**
12. Se imprime para ver si es correcto.
 **Ejemplo: ** `Console.WriteLine($"Visitando aritmetica: {context.GetText()}");`
