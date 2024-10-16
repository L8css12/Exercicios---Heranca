using Atv___05;

//Instanciando a classe Funcionario
Funcionario func1 = new Funcionario { Nome = "Lucas 1", Idade = 18 };
Funcionario func2 = new Funcionario { Nome = "Lucas 2", Idade = 20 };
Funcionario func3 = new Funcionario { Nome = "Lucas 3", Idade = 25 };
Funcionario func4 = new Funcionario { Nome = "Lucas 4", Idade = 40 };
Funcionario func5 = new Funcionario { Nome = "Lucas 5", Idade = 45 };



//Chamando o método Envelhecer
func1.Envelhecer(10); //SOmar a idade que voce passou para a variavel func1 + 10
func2.Envelhecer(10); //SOmar a idade que voce passou para a variavel func1 + 10
func3.Envelhecer(10); //SOmar a idade que voce passou para a variavel func1 + 10
func4.Envelhecer(10); //SOmar a idade que voce passou para a variavel func1 + 10
func5.Envelhecer(10); //SOmar a idade que voce passou para a variavel func1 + 10



//Exibindo as informações dos funcionarios

Console.WriteLine($"Nome : {func1.Nome}, Idade: {func1.Idade}");
Console.WriteLine($"Nome : {func2.Nome}, Idade: {func2.Idade}");
Console.WriteLine($"Nome : {func3.Nome}, Idade: {func3.Idade}");
Console.WriteLine($"Nome : {func4.Nome}, Idade: {func4.Idade}");
Console.WriteLine($"Nome : {func5.Nome}, Idade: {func5.Idade}");


func1.Rejuvelhecer(5); //SOmar a idade que voce passou para a variavel func1 + 10
func2.Rejuvelhecer(5); //SOmar a idade que voce passou para a variavel func1 + 10
func3.Rejuvelhecer(5); //SOmar a idade que voce passou para a variavel func1 + 10
func4.Rejuvelhecer(5); //SOmar a idade que voce passou para a variavel func1 + 10
func5.Rejuvelhecer(5); //SOmar a idade que voce passou para a variavel func1 + 10


Console.WriteLine($"\nRejuvelhecendo as idades");
Console.WriteLine("\n");



Console.WriteLine($"Nome : {func1.Nome}, Idade: {func1.Idade}");
Console.WriteLine($"Nome : {func2.Nome}, Idade: {func2.Idade}");
Console.WriteLine($"Nome : {func3.Nome}, Idade: {func3.Idade}");
Console.WriteLine($"Nome : {func4.Nome}, Idade: {func4.Idade}");
Console.WriteLine($"Nome : {func5.Nome}, Idade: {func5.Idade}");







Console.WriteLine("Pressione qualquer tecla para sair");

Console.ReadKey();