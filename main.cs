using System;

class MainClass {
  public static void Main (string[] args) {
    Animal docato = new Animal();
        docato.setNome("Charles Braw");
        docato.setTipo("Cachorro");
        docato.setRaca("Bensaji");
        docato.setPorte("Médio");
       docato.setCor("Laranja e Branco");
        docato.setIdade(01);
        docato.setPeso(12);
        docato.setExpec_vida(16);
        docato.setTemper(" Inteligente, Independente, Ativo, Curioso, Obstinado, Reservado");

      Dono animal = new Dono();
      animal.setNome("Tarzan");
      animal.setCel(999999999);
      animal.setEnd("Selva Brasileira nº 2019");
      animal.setCidade("Brasil Semdono");
  
       //Imprimindo a lista CLV.
    animais = new List<Animal>();  
    animais.Add(new Animal("cachorro"));
    animais.Add(new Animal("Charles Braw"));
    animais.Add(new Animal("Bensaji"));
    animais.Add(new Animal(02));
    animais.Add(new Animal("Inteligente, Independente, Ativo, Curioso, Obstinado, Reservado"));
    foreach (Animal v in animais){
      Console.WriteLine(v.Tipo + " " + v.Nome " " + v.Raca " " + v.Idade + v.setTemper);
    }
    Console.ReadKey(); 
       
  
  }


}