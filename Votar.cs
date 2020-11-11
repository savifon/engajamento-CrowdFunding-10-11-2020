//Responsavel por calcular e rankear as ideias
using System.Collections.Generic;

class Votar {
	private List<Ideia> ideias;

	public Votar() {
		ideias = new List<Ideia>();
	}

	public void addIdeia(Ideia i){
    ideias.Add(i);
  }

	public string exibeIdeias() {
		string txtIdeias = "";

		for (int i=0; i<ideias.Count; i++) {

			txtIdeias += $"*******************\n***IDEIA {i+1} - {ideias[i].getTitulo()}***\n***DESCRIÇÃO: {ideias[i].getDescricao()}\n***ÁREA DE ATUAÇÃO: {ideias[i].getArea()}\n*******************\n";
		}

		return txtIdeias;
	}

	public Ideia Vencedora(){ 
		Ideia maisVotos = ideias[0];

		for (int i=0; i<ideias.Count; i++){
			if (ideias[i].GetVotos() > maisVotos.GetVotos()) {
				maisVotos = ideias[i];
			}
		}
		
    return maisVotos;
  }
}