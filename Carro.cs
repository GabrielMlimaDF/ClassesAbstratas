class Carro : Veiculo
    {
        public int NumeroDePortas { get; set; }


//Constructor que implementa Classe Veiculo = Marca e Modelo> : base implementa
//somente o que falta
        public Carro(string marca, string modelo, int numeroDePortas)
            : base(marca, modelo)
        {
            NumeroDePortas = numeroDePortas;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Carro: {Marca} {Modelo} com {NumeroDePortas} portas.");
        }
         public override void LigarMotor()
        {
            Console.WriteLine($"Ligando:{Modelo}");
        }
    }
