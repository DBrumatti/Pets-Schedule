class CLV : Animal{
//Atributos
  public string CLV_Service { get; set; }
  public float CLV_Valor { get; set; }
  public override string ToString()
  {
    return "Serviços: " + CLV_Service + "   Valor: " + CLV_Valor;
  }
}