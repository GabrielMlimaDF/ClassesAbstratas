class Moto : Veiculo
    {
        public bool TemCarroLateral { get; set; }

//Constructor que implementa Classe Veiculo = Marca e Modelo > : base implementa
//somente o que falta
        public Moto(string marca, string modelo, bool temCarroLateral)
            : base(marca, modelo)
        {
            TemCarroLateral = temCarroLateral;
        }

        public override void ExibirInfo()
        {
            string carroLateral = TemCarroLateral ? "com" : "sem";
            Console.WriteLine($"Moto: {Marca} {Modelo} {carroLateral} carro lateral.");
        }
          public override void LigarMotor()
        {
            Console.WriteLine($"Ligando: {Modelo}");
        }
    }
