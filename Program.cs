//using System.Xml.Serialization;
//using PROJETOS.Models;

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//     Console.Clear();
//     Console.WriteLine("Digite a sua opçao:");
//     Console.WriteLine("1 - Cadastrar Cliente");
//     Console.WriteLine("2 - Buscar Cliente");
//     Console.WriteLine("3 - Apagar Cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch(opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de Cliente");
//             break;
        
//         case "2":
//             Console.WriteLine("Busca de Cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar Cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false;
//             //Environment.Exit(0);
//             break;
        
//         default:
//             Console.WriteLine("Opçao Inválida");
//             break;
//     }
// }

// Console.WriteLine("O programa se encerrou");














































// int soma = 0, numero = 0;

// do
// {
//     Console.WriteLine("Digite um número (0 para parar)");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while(numero != 0);

// Console.WriteLine($"Total da soma dos números digitados é: {soma}");


































// int numero = 5;
// int contador = 1;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador} Execuçao: {numero} x {contador} = {numero * contador}");
//     contador++;

//     if (contador == 6)
//     {
//         break;
//     }    
// }

































// int numero = 5;

// for(int contador = 0; contador <= 10; contador++)
// {
//     Console.WriteLine($"{numero} x {contador} = {numero * contador}");
// }
































// Calculadora calc = new Calculadora();

//  calc.Somar(10, 30);
//  calc.Subtrair(10, 50);
//  calc.Multiplicar(15, 45);
//  calc.Dividir(2, 2);
//  calc.Potencia(3, 3);
//  calc.Seno(30);
//  calc.Coseno(30);
//  calc.Tangente(30);
//  calc.RaizQuadrada(9);

//  int numeroIncremento = 10;

//  Console.WriteLine(numeroIncremento);

//  Console.WriteLine("Incrementando o 10");
//  numero = numero + 1;
//  numeroIncremento++;

//  int numeroDecremento = 20;
//  Console.WriteLine("Decrementando o 20");
//  numeroDecremento--;

//  Console.WriteLine(numeroDecremento);
























//  bool choveu = false;
//  bool estaTarde = false;

//  if (!choveu && !estaTarde)
//  {
//      Console.WriteLine("Pedalar hoje!");
//  }
//  else
//  {
//      Console.WriteLine("Pedalar outro dia!");
//  }































//  bool possuiPresencaMinima = true;
//  double media = 8.5;

//  if (possuiPresencaMinima && media >= 7)
//  {
//      Console.WriteLine("Aprovado!");
//  }
//  else
//  {
//      Console.WriteLine("Reprovado!");
//  }





























//  bool ehMaiorDeIdade = false;
//  bool possuirAutorizacaoDoReponsavel = false;

//  if (ehMaiorDeIdade || possuirAutorizacaoDoReponsavel)
//  {
//      Console.WriteLine("Entrada Liberada!");
//  }
//  else
//  {
//      Console.WriteLine("Entrada não Liberada!");
//  }




























//  Console.WriteLine("Digite uma letra");
//  string letra = Console.ReadLine();

//  switch (letra)
//  {
//      case "a":
//      case "e":
//      case "i":
//      case "o":
//      case "u":
//          Console.WriteLine("Volgal");
//          break;

//      default:
//          Console.WriteLine("Nao é vogal");
//          break;
//  }

























//  if (letra == "a" ||
//      letra == "e" ||
//      letra == "i" ||
//      letra == "o" ||
//      letra == "u")
//  {
//     Console.WriteLine("Vogal");
//  }
//  else
//  {
//      Console.WriteLine("Nao é uma vogal");
//  }






























//  if (letra == "a")
//  {
//      Console.WriteLine("Vogal");
//  }
//  else if (letra == "e")
//  {
//      Console.WriteLine("Vogal");
//  }
//  else if (letra == "i")
//  {
//      Console.WriteLine("Vogal");
//  }
//  else if (letra == "o")
//  {
//      Console.WriteLine("Vogal");
//  }
//  else if (letra == "u")
//  {
//      Console.WriteLine("Vogal");
//  }
//  else
//  {
//      Console.WriteLine("Nao é uma vogal");
//  }

























//  int quantidadeEmEstoque = 3;
//  int quantidadeCompra = 0;
//  bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;


//  Console.WriteLine($"Qunatidade em estoque: {quantidadeEmEstoque}");
//  Console.WriteLine($"Qunatidade compra: {quantidadeCompra}");
//  Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

//  if (quantidadeCompra == 0)
//  {
//      Console.WriteLine("Venda inválida");
//  }
//  else if (possivelVenda)
//  {
//      Console.WriteLine("Venda realizada.");
//  }
//  else
//  {
//      Console.WriteLine("Deculpe. Nao temos a quantidade desejada.");
//  }





























//  string a = "15-";

//  int b = 0;

//  int.TryParse(a, out int b);               //Como converter de uma maneira segura, para que o programa nao interrompa pela metade e rode ate o final.


//  Console.WriteLine(b);
//  Console.WriteLine("Conversao realizada com sucesso");












//  double a = 4  (2 + 2);

//  Console.WriteLine(a);



























//  int a = 5;
//  double b = a;  Redundante usar .ToDouble pois um int cabe no double.

//  long a = long.MaxValue;
//  int b = Convert.ToInt32(a);       nao é possivel fazer o contrario sem fazer a conversao manual.

//  int a = int.MaxValue;
//  long b = a; 

//  Console.WriteLine(b);














//  int inteiro = 5;
//  string a = inteiro.ToString();  Quando for String utilizar o ToString.


//  Console.WriteLine(a);














//  Cast - Casting
//  int a = Convert.ToInt32(null);  //Mais recomendado, por nao dar erro ao entrar um valor nulo.
//  int a = int.Parse(null);



//  Console.WriteLine(a);



























//  int a = 10;
//  int b = 20;

//  int c = a + b;


//  c = 5;

//  Console.WriteLine(c);
















//  DateTime dataAtual = DateTime.Now.AddDays(5);
//  Console.WriteLine(dataAtual.ToString("ddMMyyyy HH:mm"));











//  string apresentacao = "Olá, seja bem vindo";


//  int quantidade = 1;

//  double altura = 1.86;

//  decimal preco = 1.86M;

//  bool condicao = true;



//  Console.WriteLine(apresentacao);
//  Console.WriteLine("Valor da variável quantidade: " + quantidade);
//  Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));
//  Console.WriteLine("Valor da variável preco: " + preco);
//  Console.WriteLine("Valor da variável condicao: " + condicao);





//  Pessoa pessoa1 = new Pessoa();

//  pessoa1.Nome = "Carlos Eduardo";
//  pessoa1.Idade = 20;
//  pessoa1.Apresentar();

//  Pessoa pessoa_FisicaRepresentacao = new Pessoa ();
