Application to manage logs, it's very usefull while you working with logs in debug mode and there is a lot of function like:
- Logs management, you can create, edit, vizualize and remove the logs.
- DataBase to save the logs.
- Choise of what to save about the log, for example you can choose only the name and date information of the log.
- Projects selection, you can select the project that you want to work with the logs.
- IA implemented, when you have a error log you can use the assistance of ChatGPT to help you to find a way to solve this problem.

How to install the Doomsday Logs
- Use the link https://drive.google.com/drive/folders/1WMLCvbOl8jaAoVEfkmzlv2174kuKBCHT?usp=sharing to download the zip file containing the Setup.exe and the DLL:
- Extract the files.
- Execute the Setup.exe.
- Choise the installation settings that you want and install the Doomsday Logs.
- When the tool is installed you need to access the install folder, open the the folder "DoomsdayLogs.DataBase\CurrentDataBase", open the properties of the databases and give 
  permission to all the users and admin accounts.
- Now you can already open Doomsday Logs, But to use the management, we have to set up the DLL.
- Open the Visual Studio as administrator because Doomsday Logs uses the Registry editor to get some informations.
- Getting bakc to the download path, you need to reference the DLL on your project to be able to see the logs options in your code.
- Open the Manage Nuget Packages of you application and install the following packages.
  - Microsoft.Bcl.AsyncInterfaces
  - Microsoft.Extensions.Primitives
  - Microsoft.Data.SqlClient
  - System.ComponentModel.Annotations
  - System.Drawing.Common
- Now you can use the tool to manage your logs.

_____________________________________________________________________________________________________________________________________

Aplicação para gerir logs, é muito útil quando se trabalha com logs em modo de depuração e tem muitas funções como:
- Gestão de logs, pode criar, editar, visualizar e remover os logs.
- Base de dados para guardar os logs.
- Escolha do que guardar sobre o log, por exemplo, pode escolher apenas o nome e a informação da data do log.
- Seleção de projetos, pode selecionar o projeto que pretende trabalhar com os logs.
- IA implementada, quando tem um log de erro você pode usar a assistência do ChatGPT para o ajudar a encontrar uma forma de resolver este problema.

Como instalar o Doomsday Logs
- Utilize o link https://drive.google.com/drive/folders/1WMLCvbOl8jaAoVEfkmzlv2174kuKBCHT?usp=sharing para baixar o arquivo zip que contém o Setup.exe e a DLL:
- Extraia o arquivo.
- Execute o Setup.exe.
- Escolha as configurações de instalação que deseja e instale o Doomsday Logs.
- Depois de instalado a ferramenta acesse a pasta de instalação dela, abra a pasta "DoomsdayLogs.DataBase\CurrentDataBase" abra as propriedades dos arquivos de bancos de dados e 
  conceda permissão para todos os usuários e contas de admin.
- Agora já é possível abrir o Doomsday Logs, mas para usar o gerenciamento, temos que configurar a DLL.
- Abra o Visual Studio como administrador, pois o Doomsday Logs usa o editor de registro para obter algumas informações.
- Voltando ao caminho de download, é preciso referenciar a DLL no seu projeto para poder ver as opções de logs no seu código.
- Abra o Manage Nucket Packages da sua aplicação e instale os seguintes pacotes.
  - Microsoft.Bcl.AsyncInterfaces
  - Microsoft.Extensions.Primitives
  - Microsoft.Data.SqlClient
  - System.ComponentModel.Annotations
  - System.Drawing.Common
- Agora você já pode utilizar a ferramenta para gerenciar os seus logs.
