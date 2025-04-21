<p align="right">
  <a href="https://github.com/guialmeidan/projetoContratos/blob/master/README.md">
    <img src="https://img.shields.io/badge/ENGLISH-4285F4?style=flat&logo=googletranslate&logoColor=white" alt="Google Translate Badge">
  </a>
</p>

# Gerador de Contratos

## Sobre o Projeto

Este repositório contém o cliente executável de um sistema desenvolvido durante meu período de voluntariado na [AIESEC no Brasil](https://aiesec.org.br/). Trata-se de uma aplicação voltada à geração automatizada de contratos de intercâmbio voluntário, com o objetivo de minimizar erros de preenchimento e garantir a conformidade com as políticas internas da organização — erros esses que, em alguns casos, levavam à invalidação dos documentos.

O sistema permite que o usuário insira os dados das partes envolvidas e consulte informações da vaga de intercâmbio por meio de uma API. Ao final do processo, são gerados automaticamente o contrato e o termo de voluntariado, nos formatos .doc (editável) ou .pdf.

O projeto foi dividido em duas camadas principais:

- [API de autenticação dos usuários](https://github.com/guialmeidan/ContractGenerator-API);
- Cliente desktop (este repositório), que realiza a autenticação e consome uma segunda API para obter os dados da vaga e do contrato.

Este cliente foi desenvolvido em C#, utilizando o Entity Framework como ORM para persistência de dados, e SQL Server como banco de dados relacional.

⚠️ Aviso: Este projeto está obsoleto desde 2018, quando se encerrou minha participação na AIESEC. Além disso, uma das APIs utilizadas para obter os dados das vagas foi descontinuada, comprometendo o funcionamento atual do sistema.

## Funcionalidades

- Tela de autenticação (login)
- Cadastro de:
    - Empresas
    - Pessoas (testemunhas, contratantes, responsáveis)
    - Contratos
    - Termos de voluntariado
    - Vagas (com integração à API global da AIESEC)
- Consultas de:
    - Contratos
    - Vagas
    - Pessoas
- Geração automatizada de:
    - Contrato
    - Termo de voluntariado

## Arquitetura e Tecnologias

- Linguagem: C#
- ORM: Entity Framework
- Banco de dados: SQL Server
- Padrão arquitetural: Separação entre camada de dados e camada de apresentação
- Geração de documentos: Utilização de bibliotecas para manipulação de arquivos .doc e .pdf

## Status do Projeto

⚠️ **Projeto descontinuado**
O sistema não é mais mantido desde 2018. Mudanças nas APIs externas utilizadas inviabilizaram sua operação atual. Este repositório permanece como referência histórica e técnica.
