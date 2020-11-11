using System;

class Usuario {
	private string nome;
	private int idade;

	public Usuario() {
		nome = "Novo usuário";
		idade = 0;
	}
	
	public Usuario (string n, int i) {
		nome = n;
		idade = i;
	}

	private void atualizarUsuario(string n, int i) {
		nome = n;
		idade = i;
	}

	public void cadastraUsuario(Usuario u) {
		bool cadastrou = false;
		while (!cadastrou) {
			string nomeUsuario;
			int idadeUsuario;
			try {
				Console.Write("Digite o seu nome >> ");
				nomeUsuario = Console.ReadLine();
				Console.Write("Digite a sua idade >> ");
				idadeUsuario = int.Parse(Console.ReadLine());
				if (nomeUsuario=="") {
					throw new ArgumentException();
				}
				u.atualizarUsuario(nomeUsuario, idadeUsuario);
				cadastrou = true;
			} catch (FormatException) {
				Console.WriteLine("Você digitou um texto onde deveria ser número. Tente novamente.");
			} catch (ArgumentException) {
				Console.WriteLine("Você digitou valores em branco. Tente novamente.");
			}
		}
	}
}