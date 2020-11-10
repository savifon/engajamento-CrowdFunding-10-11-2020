class Usuario {
	private string nome;
	private int idade;
	private string email;

	public Usuario() {
		nome = "Novo usuário";
		idade = 0;
		email = "novo@usuario";
	}
	
	public Usuario (string n, int i, string e) {
		nome = n;
		idade = i;
		email = e;
	}
}