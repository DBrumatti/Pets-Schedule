using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    // Cria um objeto da classe Animal chamado docato.
    // Inicialmente o objeto é criado sem nenhuma informação.
    // As informações são adicionadas pelos métodos set.
    Animal docato = new Animal();
    docato.setNome("Charles Braw");

    docato.setRaca("Bensaji");
    docato.setTipo("Cachorro");
    docato.setPorte("Médio");
    docato.setCor("Laranja e Branco");
    docato.setIdade(1.0);
    docato.setPeso(12.0);
    docato.setVida(16);
    docato.setTemper(" Inteligente, Independente, Ativo, Curioso, Obstinado, Reservado");

    // Vamos exibir os valores na tela. Para isso usaremos
    // os métodos get.
    Console.WriteLine("Nome.: " + docato.getNome());

    Console.WriteLine("Raça: " + docato.getRaca());
    Console.WriteLine("Tipo: " + docato.getTipo());
    Console.WriteLine("Porte: " + docato.getPorte());
    Console.WriteLine("Cor: " + docato.getCor());
    Console.WriteLine("Idade: " + docato.getIdade());Console.WriteLine("Peso: " + docato.getPeso());
    Console.WriteLine("Vida: " + docato.getVida());
    Console.WriteLine("Temper: " + docato.getTemper());

    Console.WriteLine();    
    Console.WriteLine();       

    //Classe Dono
    Dono animal = new Dono();
    animal.setNome("Tarzan");
    animal.setCel(999999999);
    animal.setEnd("Selva Brasileira nº 2019");
    animal.setCidade("Brasil Semdono");

    Console.WriteLine("Nome: " + animal.getNome());
    Console.WriteLine("Cel: " + animal.getCel());
    Console.WriteLine("End: " + animal.getEnd());
    Console.WriteLine("Cidade: " + animal.getCidade());

    Console.WriteLine("--------------------------------------");
    

                   
    // Criando a lista CLV.
    List<CLV> vet = new List<CLV>();

    // Add valores para a lista.
    vet.Add(new CLV() {CLV_Service ="Banhon&Tosa", CLV_Valor = 80.0f});
    vet.Add(new CLV() {CLV_Service = "Vacina", CLV_Valor = 30.0f });
    vet.Add(new CLV() {CLV_Service ="Exemes", CLV_Valor = 100.0f});
    vet.Add(new CLV() { CLV_Service = "Vermifugação", CLV_Valor = 50.0f });
    vet.Add(new CLV() { CLV_Service = "Acessorios apartir", CLV_Valor = 10.0f });

    foreach (CLV aCLV in vet)
    {
      Console.WriteLine(aCLV);
    }

   
  }
}