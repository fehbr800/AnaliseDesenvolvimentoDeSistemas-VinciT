//Laços de repetição 

/*int contador;

for(contador = 0; contador < 10; contador++){
    Console.WriteLine("Matheus");
    Console.WriteLine(contador);
}
*/

//Quantas vezes voce quer imprimir seu nome


/*int quantidade;
Console.WriteLine("Informe a quantidade de vezes: ");
quantidade = int.Parse(Console.ReadLine());

while (quantidade > 0)
{
    Console.WriteLine("Matheus");
    Console.WriteLine(quantidade);
    quantidade--;

}
*/

//Laço Repita ... até

int opcao;
do{
    Console.WriteLine("Seja bem vindo ao Sistema X-Shark");
    Console.WriteLine("-------------------------------------------------");
    Console.WriteLine("01 - Cadastro de Clientes"); 
    Console.WriteLine("02 - Cadastro de Produtos"); 
    Console.WriteLine("03 - Cadastro de Fornecedores"); 
    Console.WriteLine("----------------------------------------------------------");
    Console.WriteLine("99 - Sair do programa."); 

    opcao = int.Parse(Console.ReadLine());

    if(opcao == 1){
        Console.Clear(); // Limpa tela
        Console.WriteLine("Bem vindo ao cadastro de clientes!");
        Console.WriteLine("Digite seu nome...");
        Console.ReadKey();
    }
   if(opcao == 2){
         Console.Clear(); // Limpa tela
        Console.WriteLine("Bem vindo ao cadastro de Produtos!");
        Console.WriteLine("Digite o nome do produto...");
        Console.ReadKey();
    }
  if(opcao == 3){
         Console.Clear(); // Limpa tela
        Console.WriteLine("Bem vindo ao cadastro de Fornecedores!");
        Console.WriteLine("Digite o nome do Fornecedor...");
        Console.ReadKey();
    }
    else{
        Console.WriteLine("Tchaau brigado");
    }
}while(opcao != 99);

Console.ReadKey();