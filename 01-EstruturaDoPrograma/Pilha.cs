using System; 

namespace _01_EstruturaDoPrograma {
  public class Pilha {
    Posicao primeiro;

    public void Empilha(object item) {
      primeiro = new Posicao(primeiro, item);
    }

    public object Desempilha() {

    }
  }
}