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

	public void atualizarUsuario(string n, int i) {
		nome = n;
		idade = i;
	}
}