using System;

class MainClass {
	public static void Main (string[] args) {
    Console.WriteLine("Seja bem-vindo(a)!");

		Votar campanha = new Votar();

		Usuario novoUsuario = new Usuario();
		novoUsuario.cadastraUsuario(novoUsuario);

		char continuar = 's';
		while (continuar == 's') {
			Ideia novaIdeia = new Ideia();
			novaIdeia.cadastraIdeia(novaIdeia, novoUsuario);

			campanha.addIdeia(novaIdeia);

			Console.Write("Deseja cadastrar mais? s/n >> ");
			continuar = char.Parse(Console.ReadLine());
		}
		
		Console.WriteLine("\n\n{0}", campanha.exibeIdeias());
  }
}