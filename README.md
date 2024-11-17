# Documentação do Projeto EvotechGS

## Visão Geral
O projeto EvotechGS é uma aplicação para cadastro e controle de usuários e dispositivos, focando no gerenciamento do consumo de energia. Através desta aplicação, é possível registrar novos usuários e dispositivos, facilitando o monitoramento e o controle do consumo energético.

## Estrutura do Projeto

### Modelos

#### Usuário
A classe `UsuarioModel` representa os usuários cadastrados no sistema. Cada usuário possui as seguintes propriedades:

- **id_usuario**: Identificador único do usuário.
- **nm_usuario**: Nome do usuário. (Obrigatório)
- **email**: Email do usuário.
- **senha**: Senha do usuário. (Obrigatório)
- **telefone**: Telefone do usuário.
- **dt_cadastro**: Data de cadastro do usuário.
- **genero**: Gênero do usuário.

#### Dispositivo
A classe `DispositivoModel` representa os dispositivos cadastrados no sistema. Cada dispositivo possui as seguintes propriedades:

- **id_dispositivo**: Identificador único do dispositivo.
- **nm_dispositivo**: Nome do dispositivo. (Obrigatório)
- **potencia**: Potência do dispositivo em watts.

## Funcionalidades

- **Cadastro de Usuários**: Permite o registro de novos usuários no sistema com informações como nome, email, senha, telefone, data de cadastro e gênero.
- **Cadastro de Dispositivos**: Permite o registro de novos dispositivos no sistema com informações como nome do dispositivo e sua potência.

## Requisitos

- .NET Core SDK
- Banco de dados SQL Server

## Configuração

1. **Clonar o Repositório**:
   ```sh
   git clone https://github.com/WillDant/Evotech-csharp-GS/

2. Navegar até o Diretório do Projeto:
cd Evotechgs

3. Configurar a String de Conexão: No arquivo ApplicationContext, configure a string de conexão com o seu banco de dados de acordo com o desejado

4. Aplicar Migrações e Atualizar o Banco de Dados: No Package Manager Console, execute os seguintes comandos:
Add-Migration
Update-Database

5. Executar a Aplicação: No Visual Studio, pressione F5 para compilar e rodar a aplicação.

5. Aplicar Migrações e Atualizar o Banco de Dados: No Package Manager Console, execute os seguintes comandos:





