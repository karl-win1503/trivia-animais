using System;					// usar a library System
using System.Collections.Generic;
using System.Text;

namespace TriviasAnimais
{
	class Program
	{
		static void Main(string[] args)
		{
			// Definir uma string chamada "input", para conter
			// o que o usuario escrever
			string input;
			// ...e uma integer chamada "valor", usada depois
			int valor;

			// Varias strings contendo as trivias
			string triviaGato =		 "Gato: Os ouvidos de um gato sao cinco vezes mais sensiveis que o de um humano";
			string triviaCachorro =	 "Cachorro: Um rabo pra cima e reto indica que o cachorro esta focado.";
			string triviaBorboleta = "Borboleta: Borboletas sentem gosto com os pes";
			string triviaAbelha =	 "Abelha: Se a rainha abelha morrer, as outras abelhas dao um mel especial pra uma larva que entao se torna a nova rainha";
			string triviaCoruja =	 "Coruja: As orelhas de uma coruja nao sao simetricas, uma esta acima da outra";
			string triviaTatu =		 "Tatu: As placas de um tatu sao feitas de osso, e conectadas com o seu esqueleto";

			// Um array contendo as strings de trivia
			// Arrays sao uma variavel contendo variaveis, igual
			// uma caixa com caixas dentro
			string[] triviaArray;
			triviaArray = new string[6]{triviaGato, triviaCachorro, triviaBorboleta, triviaAbelha, triviaCoruja, triviaTatu};

			// Aqui é usado o metodo WriteLine da classe Console (importada
			//  da livraria sistema)
			Console.WriteLine("Bem vindas e bem vindos ao Escolhedor de Trivias Animalisticas !!! :)");
			Console.WriteLine("Por favor escreva um numero correspondente ao animal do seu lado");
			Console.WriteLine("para ouvir uma trivia sobre ele, ou 6 para sair.");
			Console.WriteLine(""); // Uma linha vazia para espaçamento
			Console.WriteLine("(0) Gato");
			Console.WriteLine("(1) Cachorro");
			Console.WriteLine("(2) Borboleta");
			Console.WriteLine("(3) Abelha");
			Console.WriteLine("(4) Coruja");
			Console.WriteLine("(5) Tatu");
			Console.WriteLine("(6) Sair do programa");
			Console.Write("... ");

			// A int valor (definida no começo do programa) precisa ser
			// definida pra qualquer numero para que o loop nao der erro
			// (o erro de comparar uma variavel nao-definida)
			valor = 0;
			// Quando o valor for 6, o programa termina
			while (valor != 6) {
				// O construto "try" serve para rodar uma seção de codigo
				// perigosa e, caso a seçao der erro, rodar o codigo dentro
				// do construto "catch", e repetir o que esta dentro do "try"
				try	{
					// Pedir input do usuario e colocar na string input
					input = Console.ReadLine();
					// Converter a string input para uma int, e colocar na
					// int "valor"
					valor = Convert.ToInt32(input);
				}
				catch {
					// Caso a converçao falhe (porque o input não foi um numero)
					// Avisar o usuario e recomeçar o loop
					Console.WriteLine("Parece que voce nao escreveu um numero da lista. Por favor tente de novo");
				}
				// Se o valor estiver entre 0 e 5
				if (valor >= 0 && valor <= 5) {
					// Escrever no console os conteudos da variavel contida
					// no triviaArray, que tiver o index que o usuario especificou
					Console.WriteLine(triviaArray[valor]);
				} else if (valor == 6) {
					// Mas se esse valor for 6, sair do construto if
					return;
				} else {
					// Caso contrario, o numero nao esta na lista
					Console.WriteLine("Parece que voce nao escreveu um numero da lista. Por favor tente de novo");
				}
			}
		}
	}
}
