class Dono{
  private string nome;
  private int cel;
  private string end;
  private string cidade;

   public Dono() { }

    public Dono(string nome, int cel, string end, string cidade){
        
        this.nome = nome;
        this.cel = cel;
        this.end = end;
        this.cidade = cidade;

        }
        public void setNome(string valor)
        {
            this.nome = valor;
        }
        public string getNome()
        {
            return this.nome;
        }
        public void setCel(int num)
        {
            this.cel = num;
        }
        public int getCel()
        {
            return this.cel;
        }
        public void setEnd(string local)
        {
            this.end = local;
        }
        public string getEnd()
        {
            return this.end;
        }
        public void setCidade(string local)
        {
            this.cidade = local;
        }
        public string getCidade()
        {
            return this.cidade;
        }
}