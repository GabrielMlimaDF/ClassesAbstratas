    Projeto de Demonstração: Classes Abstratas em C#

Este é um projeto simples desenvolvido em C# para demonstrar o uso de classes abstratas em uma aplicação de console. O exemplo utiliza uma hierarquia de classes para representar diferentes tipos de veículos, como carros e motos.

Estrutura do Projeto

    Classes

    Veiculo (Classe Abstrata):

Define uma estrutura comum para todos os tipos de veículos.

Contém propriedades compartilhadas como Marca e Modelo.

Possui um método abstrato ExibirInfo que deve ser implementado pelas classes derivadas.

Inclui um método comum LigarMotor para simular o acionamento do motor.

    Carro (Classe Derivada):

Representa um carro com uma propriedade adicional NumeroDePortas.

Implementa o método abstrato ExibirInfo para exibir informações específicas de um carro.

    Moto (Classe Derivada):

Representa uma moto com uma propriedade adicional TemCarroLateral que indica se a moto possui um sidecar.

Implementa o método abstrato ExibirInfo para exibir informações específicas de uma moto.

    Program (Classe Principal):

Cria instâncias das classes Carro e Moto.

Demonstra o uso de polimorfismo e o funcionamento de métodos da classe base e das derivadas.
