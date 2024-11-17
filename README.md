# Documentação do Projeto EvotechGS

## Visão Geral
O projeto EvotechGS é uma aplicação para cadastro e controle de usuários e dispositivos, focando no gerenciamento do consumo de energia. Através desta aplicação, é possível registrar novos usuários e dispositivos, facilitando o monitoramento e o controle do consumo energético.

## Estrutura do Projeto

### Modelos

#### Usuário
A classe `UsuarioModel` representa os usuários cadastrados no sistema. Cada usuário possui as seguintes propriedades:

id_usuario: Identificador único do usuário.
nm_usuario: Nome do usuário. (Obrigatório)
email: Email do usuário.
senha: Senha do usuário. (Obrigatório)
telefone: Telefone do usuário.
dt_cadastro: Data de cadastro do usuário.
genero: Gênero do usuário.

####Dispositivo
A classe DispositivoModel representa os dispositivos cadastrados no sistema. Cada dispositivo possui as seguintes propriedades:

id_dispositivo: Identificador único do dispositivo.
nm_dispositivo: Nome do dispositivo. (Obrigatório)
potencia: Potência do dispositivo em watts.


##Funcionalidades
Cadastro de Usuários: Permite o registro de novos usuários no sistema com informações como nome, email, senha, telefone, data de cadastro e gênero.
Cadastro de Dispositivos: Permite o registro de novos dispositivos no sistema com informações como nome do dispositivo e sua potência.

###Requisitos
.NET Core SDK
Banco de dados SQL Server
Configuração
Clonar o Repositório:


####Copiar código:
git clone https://github.com/seu-usuario/evotechgs.git
Navegar até o Diretório do Projeto:

sh
Copiar código:

cd Evotechgs
Configurar a String de Conexão: No arquivo ApplicationContext, configure a string de conexão com o seu banco de dados, subtituindo o User e ID para o desejado:


Aplicar Migrações e Atualizar o Banco de Dados: No Package Manager Console, execute os seguintes comandos:

sh
Copiar código
Add-Migration
Update-Database
Executar a Aplicação: No Visual Studio, pressione F5 para compilar e rodar a aplicação.
