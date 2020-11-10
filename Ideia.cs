class Ideia {
	private string titulo, descricao, area;
	private int numVotos;
	private double valorDoado;
	private Usuario donoIdeia;

	public void SetVotos(int n) {
		numVotos += n;
	}
	public int GetVotos() {
		return numVotos;
	}

	public void SetDoacao(int d) {
		valorDoado += d;
	}
	public double GetDoacao() {
		return valorDoado;
	}

	public void SetDono(Usuario u) {
		donoIdeia = u;
	}
	public Usuario getDono() {
		return donoIdeia;
	}

	public string GetTitulo() {
		return titulo;
	}
	public string GetDescricao() {
		return descricao;
	}
	public string GetArea() {
		return area;
	}

	public Ideia() {
		titulo = "Nova ideia";
		descricao = "Sem descrição";
		area = "Sem área";
		numVotos = 0;
		valorDoado = 0;
	}

	public Ideia (string t, string d, string a) {
		titulo = t;
		descricao = d;
		area = a;
	}
}