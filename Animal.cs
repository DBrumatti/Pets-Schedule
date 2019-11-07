class Animal{
//Atributos
private string nome;
        
        private string raca;
        private string tipo;
        private string porte;
        private string cor;
        private double idade;
        private double peso;
        private int vida;
        private string temper;
        //Metodos Contrutores é responsavel por instanciar
        public Animal(){}

        public Animal(string nome, string tipo, string raca, string porte, string cor, double idade, double peso, int vida, string temper){

        this.nome = nome;
        this.tipo = tipo;
        this.raca = raca;
        this.porte = porte;
        this.cor = cor;
        this.idade = idade;
        this.peso = peso;
        this.vida = vida;
        this.temper = temper;
        }
            //Métodos acessores
        public void setNome(string names){
       
            this.nome = names;
        }
        public string getNome()
        {
            return this.nome;
        }
         public void setTipo(string tipos){
       
            this.tipo = tipos;
        }
        public string getTipo()
        {
            return this.tipo;
        }
        
        public void setRaca(string rac)
        {
            this.raca = rac;
        }
        public string getRaca()
        {
            return this.raca;
        }
        public void setPorte(string port)
        {
            this.porte = port;
        }
        public string getPorte()
        {
            return this.porte;
        }
        public void setCor(string color)
        {
            this.cor = color;
        }
        public string getCor()
        {
            return this.cor;
        }
        public void setIdade(double idad)
        {
            this.idade = idad;
        }
        public double getIdade()
        {
            return this.idade;
        }
        public void setPeso(double pes)
        {
            this.peso = pes;
        }
        public double getPeso()
        {
            return this.peso;
        }
        public void setVida(int life)
        {
            this.vida = life;
        }
        public int getVida()
        {
            return this.vida;
        }
        public void setTemper(string tempera)
        {
            this.temper = tempera;
        }
        public string getTemper()
        {
            return this.temper;
        }
      
}