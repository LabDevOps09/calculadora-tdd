# Projeto Calculadora com TDD  :woman_technologist:

## Descrição

Foi criada uma calculadora com as seguintes funcionalidades:
- Soma
- Subtração
- Multiplicação
- Divisão
- Histórico de operações

## Regras de Negócio

- **Números Inteiros**: A calculadora opera apenas com números inteiros.
- **Parâmetros**: Cada operação utiliza dois parâmetros.
- **Histórico**: Sempre retorna as últimas 3 operações do histórico.

## Estrutura do Projeto  

### 1. Criação da Solução

- **Projeto Principal**: `CalculadoraApp`
  - Implementa a lógica da calculadora e o armazenamento do histórico.

### 2. Criação do Projeto de Teste

- **Projeto de Teste**: `CalculadoraApp.Tests`
  - Contém testes unitários para validar as funcionalidades da calculadora.

### 3. Comunicação Entre Projetos

- O projeto de teste referencia o projeto principal para acessar suas funcionalidades e validar o comportamento da calculadora.

## Instruções para Uso

1. **Construir e Executar o Projeto** :desktop_computer:
   ```bash
   dotnet build
   dotnet run
