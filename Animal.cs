class Animal{
 // armazenar as informações que descrevem os animais, fazemos isso declarando variáveis 
//dentro da classe, essas variáveis são os atributos
  private string nome;
  private string tipo;
  private string raca;
  private string porte;
  private string cor;
  private double idade;
  private double peso;
  private int expec_vida;
  private string temperamento;
  

  public Animal(){}

  public Animal(string nome,string tipo,string raca,string porte,string cor,double idade,double peso,int tempo_vida,string temperamento){
    
    this.nome = nome;
    this.tipo = tipo;
    this.raca = raca;
    this.porte = porte;
    this. cor = cor;
    this.idade = idade;
        this.peso = peso;
        this.tempo_vida - tempo_vida = tempo_vida;
        this.temperamento = temperamento;

  }
  public void comer(double Kg)//Métodos,os parametros dos métodos estão dentro dos parêntesses
    {
        this.comer = kg;
    }
    public void passeio(string Lazer)
    {
        this.passeio = Lazer;
    }
    public void BanhoeTosa(string cuidado)
    {
        this.BanhoeTosa = cuidado;
    }
}