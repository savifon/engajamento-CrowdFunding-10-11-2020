using System;

class MainClass {
	public static void Main (string[] args) {
    Console.WriteLine("Seja bem-vindo(a)!");

		Votar campanha = new Votar();

		Usuario novoUsuario = new Usuario();
		bool cadastrou = false;
		while (!cadastrou) {
			string nomeUsuario;
			int idadeUsuario;
			try {
				Console.Write("Digite o seu nome >> ");
				nomeUsuario = Console.ReadLine();
				Console.Write("Digite a sua idade >> ");
				idadeUsuario = int.Parse(Console.ReadLine());
				novoUsuario.atualizarUsuario(nomeUsuario, idadeUsuario);
				cadastrou = true;
			} catch (FormatException) {
				Console.WriteLine("Você digitou um texto onde deveria ser número. Tente novamente.");
			}
		}

		char continuar = 's';
		while (continuar == 's') {
			string tituloIdeia, descricaoIdeia, areaIdeia;
			
			Console.Write("Digite o nome da sua ideia >> ");
			tituloIdeia = Console.ReadLine();
			Console.Write("Descreva a sua ideia >> ");
			descricaoIdeia = Console.ReadLine();
			Console.Write("Informe a área de aplicação da sua idea >> ");
			areaIdeia = Console.ReadLine();

			Ideia novaIdeia = new Ideia(tituloIdeia, descricaoIdeia, areaIdeia, novoUsuario);

			Console.Write("Deseja cadastrar mais? s/n >> ");
			continuar = char.Parse(Console.ReadLine());

			campanha.addIdeia(novaIdeia);
		}

		Console.WriteLine("\n\n{0}", campanha.exibeIdeias());
  }
}