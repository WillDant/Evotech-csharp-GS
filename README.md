# Documentação do Projeto EvotechGS

## Visão Geral
O projeto EvotechGS é uma aplicação para cadastro e controle de usuários e dispositivos, focando no gerenciamento do consumo de energia. Através desta aplicação, é possível registrar novos usuários e dispositivos, facilitando o monitoramento e o controle do consumo energético.

## Estrutura do Projeto

### Modelos

#### Usuário

A classe `UsuarioModel` representa os usuários cadastrados no sistema. Cada usuário possui as seguintes propriedades:

```csharp
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvotechGS.Models
{
    [Table("tb_usuario")]
    public class UsuarioModel
    {
        [Key]
        public int id_usuario { get; set; }

        [Required(ErrorMessage = "Nome do usuário é obrigatório")]
        public string nm_usuario { get; set; }

        public string email { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string senha { get; set; }

        public string telefone { get; set; }

        public DateTime dt_cadastro { get; set; }

        public string genero { get; set; }
    }
}
id_usuario: Identificador único do usuário.
nm_usuario: Nome do usuário. (Obrigatório)
email: Email do usuário.
senha: Senha do usuário. (Obrigatório)
telefone: Telefone do usuário.
dt_cadastro: Data de cadastro do usuário.
genero: Gênero do usuário.
Dispositivo
A classe DispositivoModel representa os dispositivos cadastrados no sistema. Cada dispositivo possui as seguintes propriedades:

csharp
Copiar código
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EvotechGS.Models
{
    [Table("tb_dispositivo")]
    public class DispositivoModel
    {
        [Key]
        public int id_dispositivo { get; set; }

        [Display(Name = "Nome do Dispositivo")]
        [Required(ErrorMessage = "O campo Nome do Dispositivo é obrigatório")]
        public string nm_dispositivo { get; set; }

        public float potencia { get; set; }
    }
}
id_dispositivo: Identificador único do dispositivo.
nm_dispositivo: Nome do dispositivo. (Obrigatório)
potencia: Potência do dispositivo em watts.
Funcionalidades
Cadastro de Usuários: Permite o registro de novos usuários no sistema com informações como nome, email, senha, telefone, data de cadastro e gênero.
Cadastro de Dispositivos: Permite o registro de novos dispositivos no sistema com informações como nome do dispositivo e sua potência.
Requisitos
.NET Core SDK
Banco de dados SQL Server
Configuração
Clonar o Repositório:

sh
Copiar código
git clone https://github.com/seu-usuario/evotechgs.git
Navegar até o Diretório do Projeto:

sh
Copiar código
cd evotechgs
Configurar a String de Conexão: No arquivo appsettings.json, configure a string de conexão com o seu banco de dados:

json
Copiar código
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=EvotechGSDB;Trusted_Connection=True;MultipleActiveResultSets=true"
  }
}
Aplicar Migrações e Atualizar o Banco de Dados: No Package Manager Console, execute os seguintes comandos:

sh
Copiar código
Add-Migration InitialCreate
Update-Database
Executar a Aplicação: No Visual Studio, pressione F5 para compilar e rodar a aplicação.

Contribuições
Contribuições são bem-vindas! Por favor, siga os passos abaixo para contribuir:

Faça um fork do projeto.
Crie uma branch para sua feature (git checkout -b feature/nova-feature).
Commite suas mudanças (git commit -am 'Adicionei uma nova feature').
Faça push para a branch (git push origin feature/nova-feature).
Crie um novo Pull Request.
