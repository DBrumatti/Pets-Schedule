class CLV{//foi criada um vetor de serviços,e add entre chaves tipos dos serviços executados 
  private string[]servicos = new string[]{"banhotosa","vacina","exame","vermifugação"};
  private double[]servicos = new double[]{100.0,30.0,15.0,20.0};
  private  List<Animal> animais = new List<Animal>();
  
  public void cadastrar (Animal x) {
    animais.Add(x);
  }


}