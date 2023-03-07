/*int valor1;
int valor2;

int resultado;


valor1 = 10;
valor2 = 20;
resultado = valor1 * valor2;
Console.WriteLine(resultado);
*/

/*//Estrutura condicional  (IF/ElSE)

int idadeDoGustavo;
Console.WriteLine("Digite a idade do Gustavo: ");
//A idade do Gustavo vai receber o que o usuário digitar
idadeDoGustavo = int.Parse(Console.ReadLine());

if(idadeDoGustavo >= 18){
    Console.WriteLine("Pode tirar a carteira de motorista");
}else{
    Console.WriteLine("O Gustavo não tem idade suficiente!");
}

Console.ReadKey();
*/
// Atividade valor da mesada para ir no rolê

double mesada;
Console.WriteLine("Digite o valor da sua mesada: ");
mesada = int.Parse(Console.ReadLine());

if(mesada >= 200) {
    Console.WriteLine("Você tem grana pra balada :)");
} else{
    Console.WriteLine("Você só tem dinheiro pro cinema :/");
}

Console.ReadKey();