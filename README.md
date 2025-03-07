# Sistema de Gerenciamento de Estoque

## Descrição

O **Sistema de Gerenciamento de Estoque** foi desenvolvido para otimizar a administração de produtos, pedidos e usuários em ambientes comerciais. Ele oferece uma solução eficiente e segura para empresas que buscam um controle preciso sobre seus estoques e vendas. Utilizando **C#** como linguagem de programação, **.NET** como plataforma de desenvolvimento e **SQLite** como banco de dados, o sistema é robusto, fácil de usar e personalizável.

## Tecnologias Utilizadas

- **C#**: Linguagem de programação principal.
- **.NET 6/7**: Framework utilizado para o desenvolvimento da aplicação.
- **SQLite**: Banco de dados leve, eficiente e de fácil configuração.
- **XAML (caso haja interface gráfica)**: Para a construção da interface do usuário (caso aplicável).

## Requisitos do Sistema

### Requisitos Funcionais

1. **Gestão de Usuários**:
   - Cadastro, edição e remoção de usuários.
   - Definição de permissões de acesso baseadas no cargo (Administrador ou Vendedor).
   - Listagem de usuários cadastrados.
   
2. **Gestão de Produtos**:
   - Cadastro, edição e remoção de produtos.
   - Controle de preços, quantidades e códigos únicos.
   - Exibição do estoque atual e histórico de movimentações.

3. **Gestão de Pedidos**:
   - Criação de pedidos vinculados a produtos e clientes.
   - Atualização automática do estoque após a finalização de uma venda.
   - Exibição do histórico de pedidos com detalhes das transações.

4. **Controle de Acesso**:
   - Sistema de login seguro para os usuários.
   - Diferenciação de acessos entre Administradores e Vendedores.
   - Controle de sessão para garantir segurança e rastreamento de acessos.

### Requisitos Não Funcionais

1. **Desempenho**:
   - Tempo de resposta para consultas e operações de banco de dados deve ser inferior a 2 segundos.
   - A interface do sistema deve ser responsiva e intuitiva, com foco na experiência do usuário.

2. **Segurança**:
   - O sistema deve garantir a segurança dos dados armazenados, como senhas de usuários e registros financeiros.
   - Proteção contra ataques comuns, como injeção de SQL.

3. **Escalabilidade**:
   - O sistema deve ser projetado de forma a permitir fácil expansão, seja com mais funcionalidades ou integração com outros sistemas.

## Funcionalidades Principais

### 1. Autenticação e Controle de Acesso

- **Login seguro**: Sistema de autenticação com validação de usuário e senha.
- **Controle de acesso**: Permissões diferenciadas para Administradores (com acesso total) e Vendedores (com acesso restrito).
- **Sessões de usuário**: Cada login é associado a uma sessão que pode ser rastreada para segurança.

### 2. Gerenciamento de Usuários

- **Cadastro e manutenção de usuários**: Administradores podem cadastrar, editar e remover usuários.
- **Definição de permissões**: Os usuários podem ser atribuídos aos cargos de Administrador ou Vendedor, com permissões específicas.
- **Listagem de usuários**: Visualização de todos os usuários cadastrados, com a possibilidade de editar ou remover.

### 3. Controle de Produtos

- **Cadastro, edição e remoção de produtos**: Gerencie os produtos do estoque com facilidade.
- **Controle de preços e quantidades**: Mantenha o estoque atualizado com o controle de preços e quantidades disponíveis.
- **Códigos únicos**: Cada produto possui um código único para facilitar a identificação e rastreamento.

### 4. Gestão de Pedidos

- **Criação e gerenciamento de pedidos**: Crie novos pedidos, associe produtos e clientes.
- **Atualização automática do estoque**: O estoque é ajustado automaticamente conforme os pedidos são finalizados.
- **Histórico de pedidos**: Acompanhe todos os pedidos realizados, com detalhes das transações, incluindo data, produtos, quantidade e valores.

### 5. Banco de Dados

- **Armazenamento de dados**: O banco de dados SQLite armazena informações sobre produtos, usuários e pedidos.
- **Integridade dos dados**: Relacionamentos entre tabelas garantem que os dados sejam consistentes e válidos.
- **Consultas rápidas**: O sistema é otimizado para realizar consultas rápidas e eficientes ao banco de dados.
- 
