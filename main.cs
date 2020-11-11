using System;

class MainClass {
	public static void Main (string[] args) {
		int opcao=2;
		Votar campanha = new Votar();

		bool fecha = false;

		Console.Clear();
		Console.WriteLine("*** SEJA BEM-VINDO(A) ***\n\n");

		Usuario novoUsuario = new Usuario();
		novoUsuario.cadastraUsuario(novoUsuario);

		while (!fecha) {
			switch (opcao) {
				case 1: //usuário
					//Usuario novoUsuario = new Usuario();
					novoUsuario.cadastraUsuario(novoUsuario);
					break;

				case 2: //ideia
					Ideia novaIdeia = new Ideia();
					novaIdeia.cadastraIdeia(novaIdeia, novoUsuario);
					campanha.addIdeia(novaIdeia);
					break;

				case 3: //votação
					campanha.exibeIdeias();
					campanha.Votacao();

					Ideia ganhadora = campanha.IdeiaVencedora();
					Console.WriteLine("\n\nA IDEIA VENCEDORA FOI: {0}\n\n", ganhadora.getTitulo());

					novoUsuario.setCarteira(((ganhadora.GetVotos()/campanha.getTotalVotos())^2)*30);

					opcao = 0;
					break;

				case 0: //fecha
					fecha = true;
					break;

				break;
			}

			if (opcao > 0) {
				try {
					Console.WriteLine("*** Escolha uma opção ***\n   1 Cadastro de Usuário\n   2 Cadastro de Ideias\n   3 Iniciar Votação\n   0 Sair");
					opcao = int.Parse(Console.ReadLine());
				} catch (FormatException) {
					Console.WriteLine("Digite uma opção válida!");
				}
				Console.Clear();
			}
		}


  }
}