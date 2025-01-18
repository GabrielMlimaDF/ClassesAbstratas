   abstract class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Veiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        //deve ser implementado pelas classes derivadas
        public abstract void ExibirInfo();

        // Método comum que pode ser implementdo para todas as subclasses
        public abstract void LigarMotor();
       
    }