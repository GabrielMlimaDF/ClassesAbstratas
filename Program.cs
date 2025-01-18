   Veiculo carro = new Carro("Toyota", "Corolla", 4);
            Veiculo moto = new Moto("Honda", "CB500", false);

            // Usando métodos da classe base e das derivadas
            carro.LigarMotor();
            carro.ExibirInfo();

            moto.LigarMotor();
            moto.ExibirInfo();

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
