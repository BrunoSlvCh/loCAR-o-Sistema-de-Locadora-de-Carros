# loCARção — Sistema de Locadora de Carros

Sistema desktop desenvolvido em **VB.NET Windows Forms** com banco de dados **SQL Server**, voltado para o gerenciamento completo de uma locadora de veículos.

---

## Funcionalidades

- **Login** com dois tipos de acesso: Administrador e Usuário
- **Recuperação de senha** pelo usuário cadastrado
- **Painel ADM** para cadastro e gerenciamento de contas de acesso
  - Bloquear, Ativar e Excluir contas
- **Cadastro de Clientes** com pesquisa por nome ou CPF
- **Cadastro de Carros** com pesquisa por modelo ou placa
- **Registro de Locações** com cálculo automático do valor estimado
- **Devolução de Veículos** com cálculo automático do valor total cobrado
- **Controle de disponibilidade** dos veículos em tempo real

---

## Tecnologias Utilizadas

- VB.NET — Windows Forms (.NET Framework 4.7.2)
- SQL Server Express
- ADODB (ActiveX Data Objects)
- Visual Studio

---

## Banco de Dados

Execute o arquivo `01_criar_banco.sql` no SQL Server Management Studio (SSMS) para criar o banco e as tabelas automaticamente.

**Tabelas:**
- `tb_contas` — usuários do sistema
- `tb_clientes` — clientes da locadora
- `tb_carros` — veículos disponíveis
- `tb_locacoes` — registro de locações

---

## Acesso Padrão

| Usuário | Senha | Tipo |
|---------|-------|------|
| admin | 1234 | ADM |

---

## Como Configurar

1. Execute o `01_criar_banco.sql` no SSMS
2. Abra o projeto no Visual Studio
3. Adicione a referência COM: **Microsoft ActiveX Data Objects 6.1 Library**
4. Em `Module1.vb` ajuste a string de conexão se necessário:
```
Data Source=.\SQLEXPRESS
```
5. Compile e execute o projeto

---

## Observações

- Carros e clientes que possuem locações registradas **não podem ser excluídos** para preservar o histórico
- Ao finalizar uma devolução o veículo volta automaticamente para disponível
- O sistema possui dois níveis de acesso: **ADM** (acesso total) e **Usuário** (acesso ao menu principal)
