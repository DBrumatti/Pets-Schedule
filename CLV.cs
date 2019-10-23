class CLV{//foi criada um vetor de serviços,e add entre chaves tipos dos serviços executados 
  private string[]servicos = new string[]{"banhotosa","vacina","exame","vermifugação"};
  private double[]servicos = new double[]{100.0,30,15,20};
  private  List <Animal> animais = new List<Animal>();
  private List<Animal> nomeanimais = new List<Animal>();
  
  public void cadastrar (Animal tipo) {
    animais.Add(tipo);//Duvidas para adcionar tipos de animais na lista.

    Aniamal Tipo = new AnimalTipo();
    Animal Nome = new AnimalNome();
    Animal Raca = new AnimalRaca();
    Animal Idade = new AnimalIdade();
    Animal Temper = new AnimalTemper();

    animais.Add(Tipo);
    animais.Add(Nome);
    animais.Add(Raca);
    animais.Add(Idade);
    animais.Add(Temper);
  }
 /*  public void cadastro (Animal nome){
    nomeanimais.Add(nome);
   }
  */
  


}