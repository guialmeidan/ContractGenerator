<p align="right">
  <a href="https://github.com/guialmeidan/dividends_extractor/blob/main/README-pt.md">
    <img src="https://img.shields.io/badge/PORTUGUESE-4285F4?style=flat&logo=googletranslate&logoColor=white" alt="Google Translate Badge">
  </a>
</p>

# Contract Generator

## About the Project

This repository contains the executable client of a system developed during my volunteer period at [AIESEC in Brazil](https://aiesec.org.br/). It is an application designed for the automated generation of volunteer exchange contracts, aiming to reduce input errors and ensure compliance with the organization's internal policies — as such errors often led to contract invalidation.

The system allows the user to input the information of the involved parties and retrieve exchange opportunity data via an API. At the end of the process, the system automatically generates the contract and the volunteer agreement in .doc (editable) or .pdf formats.

The project was structured in two main layers:

- User authentication API;
- Desktop client (this repository), which handles authentication and consumes a second API to fetch contract and opportunity data.

This client was developed in C#, using Entity Framework as the Object-Relational Mapper (ORM) for data persistence, and SQL Server as the relational database management system (RDBMS).

⚠️ **Notice**: This project has been obsolete since 2018, when my participation in AIESEC ended. Additionally, one of the APIs used to retrieve opportunity data was discontinued, which has compromised the system's current functionality.

## Features

- Authentication screen (login)
- Registration of:
    - Companies
    - People (witnesses, signatories, guardians)
    - Contracts
    - Volunteer agreements
    - Exchange opportunities (integrated with AIESEC's global API)
- Queries for:
    - Contracts
    - Opportunities
    - People
- Automated generation of:
    - Contracts
    - Volunteer agreements

## Architecture and Technologies

- Language: C#
- ORM: Entity Framework
- Database: SQL Server
- Architectural pattern: Separation between data layer and presentation layer
- Document generation: Use of libraries for handling .doc and .pdf files

## Project Status

⚠️ **Discontinued Project**
The system has not been maintained since 2018. Changes to external APIs have rendered it non-functional. This repository is retained as a historical and technical reference.
