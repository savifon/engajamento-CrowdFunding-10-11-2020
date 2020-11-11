using System;
using System.Collections.Generic;

//Responsavel por calcular e rankear as ideias
class Votar {
	private List<Ideia> ideias;
	private Ideia ideiaUm, ideiaDois, ideiaTres;
	private int totalVotos;

	public Votar() {
		ideias = new List<Ideia>();
	}

	public void addIdeia(Ideia i){
    ideias.Add(i);
  }

	public int getTotalVotos() {
		return totalVotos;
	}

	public string exibeIdeias() {
		string txtIdeias = "";

		for (int i=0; i<ideias.Count; i++) {
			txtIdeias += $"*******************\n***IDEIA [{i+1}] - {ideias[i].getTitulo()}***\n***DESCRIÇÃO: {ideias[i].getDescricao()}\n***ÁREA DE ATUAÇÃO: {ideias[i].getArea()}\n*******************\n";
		}

		return txtIdeias;
	}

	private string exibeVotosIdeias() {
		string txtIdeias = "";

		for (int i=0; i<ideias.Count; i++) {

			txtIdeias += $"*******************\n***IDEIA [{i+1}] - {ideias[i].GetVotos()} votos\n*******************\n";
		}

		return txtIdeias;
	}

	public void Votacao() {
		int voto=1;
		while (voto >= 1) {
			try {
				Console.Write("Digite o número da ideia que deseja votar ou 0 para visualizar o resultado >> ");
				voto = int.Parse(Console.ReadLine());

				if (voto == 0) {
					throw new ArgumentException();
				}

				ideias[voto-1].SetVotos(1);
				Console.WriteLine(exibeVotosIdeias());

				totalVotos += 1;

			} catch (FormatException) {
				Console.WriteLine("Você digitou um texto onde deveria ser número. Tente novamente.");
			} catch (ArgumentOutOfRangeException) {
				Console.WriteLine("Você digitou o número de uma ideia inexistente. Tente novamente.");
			} catch (ArgumentException) {
				Console.WriteLine("Votação encerrada!");
			}
		}
	}

	/*public Ideia tresIdeias() {
			ideiaUm =  ideias[0];
			ideiaDois =  ideias[0];
			ideiaTres =  ideias[0];

			for (int i=0; i<ideias.Count; i++){
				if (ideias[i].GetVotos() > maisVotos.GetVotos()) {
					ideiaUm = ideias[i];
				}
			}
			
			return maisVotos;
		}
	}*/

	public Ideia IdeiaVencedora() {
		Ideia maisVotos = ideias[0];

		for (int i=0; i<ideias.Count; i++){
			if (ideias[i].GetVotos() > maisVotos.GetVotos()) {
				maisVotos = ideias[i];
			}
		}
		
    return maisVotos;
  }
}