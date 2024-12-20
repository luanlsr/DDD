# 🛠️ Arquitetura em Camadas com DDD em .NET Core 🚀  

## **Descrição do Projeto**  
Este projeto implementa um exemplo prático de **Arquitetura em Camadas** combinada com os princípios de **Domain-Driven Design (DDD)** em um CRUD de Produtos. Utiliza o **Entity Framework Core** para persistência dos dados e segue boas práticas de separação de responsabilidades.  

---

## **Tecnologias Utilizadas**  

- ⚙️ **.NET 8.0**  
- 🗄️ **Entity Framework Core**  
- 💾 **SQL Server**  
- 🔧 **Arquitetura em Camadas**  
- 📚 **Domain-Driven Design (DDD)**  
- ✅ **Dependency Injection**  
- 🌐 **Swagger** (para documentação de API)  

---

## **Estrutura do Projeto**  

O projeto foi organizado em **camadas**, seguindo os padrões de **DDD**:


### Descrição das Camadas

1. **Domain**: Contém as entidades de domínio, objetos de valor e interfaces que definem os contratos de repositórios e serviços.

2. **Application**: A camada responsável pela lógica de aplicação, contendo os serviços de aplicação e DTOs. Os serviços de aplicação contêm a lógica de manipulação de dados.

3. **CrossCutting**: Camada compartilhada entre as outras camadas, que contém objetos como DTOs que são usados por várias camadas do sistema.

4. **Infrastructure**: Responsável pela implementação dos repositórios e pelo acesso ao banco de dados utilizando o Entity Framework.


## **Configuração do Ambiente**  

### **Pré-requisitos**  
- Visual Studio 2022 ou superior  
- .NET 8.0 SDK  
- SQL Server instalado ou disponível  

### **Passo a Passo**  

1. **Clone o Repositório**  

```bash
git clone https://github.com/luanlsr/DDD.git
cd projeto-camadas-ddd
```

2. **Configure o Banco de Dados** 

No arquivo appsettings.json, adicione sua Connection String:

```bash
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=SEU_SERVIDOR;Database=ProdutoDB;Trusted_Connection=True;"
  }
}
```

3. **Aplicar as Migrações** 
Rode os seguintes comandos no terminal:
    ```bash 
    dotnet ef database update
    ```

4. **Execute o Projeto** 
    ```bash 
    dotnet run
    ```

5. **Acesse a API** 

Abra o navegador e acesse a documentação da API no Swagger:

https://localhost:5001/swagger
    
    
## Endpoints da API

| Método | Endpoint                | Descrição                           |
|--------|-------------------------|-------------------------------------|
| GET    | /api/produtos            | Lista todos os produtos            |
| GET    | /api/produtos/{id}       | Busca um produto por ID            |
| POST   | /api/produtos            | Cria um novo produto               |
| PUT    | /api/produtos/{id}       | Atualiza um produto existente      |
| DELETE | /api/produtos/{id}       | Remove um produto                  |



## Contribuições 🤝
Fique à vontade para enviar Pull Requests ou abrir Issues com sugestões e melhorias!

## Licença 📄
Este projeto é licenciado sob a licença MIT.

## Contato 📧
Desenvolvido por Luan da Silva Ramalho

LinkedIn: https://www.linkedin.com/in/luan-ramalholsr/

GitHub: https://github.com/luanlsr

    
    
    
    