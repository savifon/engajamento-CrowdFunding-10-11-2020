using System;

class MainClass {
	public static void Main (string[] args) {
    Console.WriteLine("\n\nSeja bem-vindo(a)!\n\n");

		Votar campanha = new Votar();

		Usuario novoUsuario = new Usuario();
		novoUsuario.cadastraUsuario(novoUsuario);

		char continuar = 's';
		while (continuar == 's') {
			try {
				Ideia novaIdeia = new Ideia();
				novaIdeia.cadastraIdeia(novaIdeia, novoUsuario);

				campanha.addIdeia(novaIdeia);

				Console.Write("\n\nDeseja cadastrar mais? s/n >> ");
				continuar = char.Parse(Console.ReadLine());
			} catch (FormatException) {
				Console.WriteLine("Digite uma opção válida (s/n)");
			}
		}
		
		Console.WriteLine("\n\n{0}", campanha.exibeIdeias());

		campanha.Votacao();

		Ideia ganhadora = campanha.IdeiaVencedora();
		Console.WriteLine("\n\nA IDEIA VENCEDORA FOI: {0}\n\n", ganhadora.getTitulo());

		novoUsuario.setCarteira(((ganhadora.GetVotos()/campanha.getTotalVotos())^2)*30);

  }
}