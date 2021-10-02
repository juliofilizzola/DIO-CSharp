using System; 

namespace _01_EstruturaDoPrograma {

  public class Pilha {

    Posicao primeiro;

    public void Empilha(object item) {

      primeiro = new Posicao(primeiro, item);

    }

    public object Desempilha() {

      if (primeiro == null) {

        throw new InvalidOperationException("A Pilha está vazia"); 
        // vai lançar o erro, caso não tenha mais nada para ser desempilhado.
      }

      object resultado = primeiro.item;
      primeiro = primeiro.proximo;
      return resultado;

    }

    class Posicao {
      public Posicao proximo;

      public object item;

      public Posicao(Posicao proximo, object item) {

        this.proximo = proximo;
        this.item = item;

      }
    }
  }
}