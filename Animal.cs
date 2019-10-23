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
  private string temper;
  

  public Animal(){}

  public Animal(string nome,string tipo,string raca,string porte,string cor,double idade,double peso,int tempo_vida,string temper){}

      public void setNome(string nome){
      this.nome = nome;
      }
      public string getNome(){
        return this.nome;
      }
      public void setTipo(string tipo){
        this.tipo = tipo;
      }
      public string getTipo(){
        return this.tipo;
      }
      public void setRaca(string raca){
        this.raca = raca;
      }
      public string getRaca(){
        return this.raca;
      }
      public void setPorte(string porte){
        this.porte = porte;
      }
      public string getPorte(){
        return this.porte;
      }
      public void setCor(string cor){
        this.cor = cor;
      }
      public string getCor(){
        return this.cor;
      }
      public void setIdade(double idade){
        this.idade = idade;
      }
      public double getIdade(){
        return this.idade;
      }
      public void setPeso
      (double peso){
        this.peso = peso;
      }
      public double getPeso(){
        return this.peso;
      }
      public void setExpec_vida(int expec_vida){
        this.expec_vida = expec_vida;
      }
      public int getExpec_vida(){
        return this.expec_vida;
      }
      public void setTemper(string temper){
        this.temper = temper;
      }
      public string getTemper(){
        return this.temper;
      }
  
  
  
}