using System;

class Ideia {
	private string titulo, descricao, area;
	private int numVotos;
	private double valorDoado;
	private Usuario donoIdeia;

	public Ideia() {
		titulo = "Nova ideia";
		descricao = "Sem descrição";
		area = "Sem área";
		numVotos = 0;
		valorDoado = 0;
	}

	public Ideia (string t, string d, string a, Usuario u) {
		titulo = t;
		descricao = d;
		area = a;
		donoIdeia = u;
	}

	public void cadastraIdeia(Ideia i, Usuario u) {
		string tituloIdeia, descricaoIdeia, areaIdeia;
		
		try {
			Console.Write("Digite o nome da sua ideia >> ");
			tituloIdeia = Console.ReadLine();
			Console.Write("Descreva a sua ideia >> ");
			descricaoIdeia = Console.ReadLine();
			Console.Write("Informe a área de aplicação da sua ideia >> ");
			areaIdeia = Console.ReadLine();

			if (tituloIdeia=="" || descricaoIdeia=="" || areaIdeia=="") {
				throw new ArgumentException();
			}

			i.atualizaIdeia(tituloIdeia, descricaoIdeia, areaIdeia, u);

		} catch (ArgumentException) {
			Console.WriteLine("Você digitou valores em branco. Tente novamente.");
		}
	}

	private void atualizaIdeia(string t, string d, string a, Usuario u) {
		titulo = t;
		descricao = d;
		area = a;
		donoIdeia = u;	
	}

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

	public string getTitulo() {
		return titulo;
	}
	public string getDescricao() {
		return descricao;
	}
	public string getArea() {
		return area;
	}

	public void novaIdeia() {
	}
}