# 16 — Validar Domain Core

## Objetivo
Validar que o Domain Core atende às regras de separação de responsabilidades e está pronto para implementação.

## Passos recomendados
- Rever todas as definições de entidades, value objects, enums e interfaces.
- Verificar ausência de dependências de infraestrutura no Domain.
- Confirmar invariantes e contratos documentados.
- Registrar observações e ações corretivas em ADRs, se necessário.

## Resultado esperado
- Domain Core aprovado para implementação incremental.

## Notas
Esta etapa é uma validação; não implementar mudanças sem aprovação.


# STEP 16 — Validar Domain Core

## Objetivo

Validar toda a camada Domain do projeto FilmFlix.

---

# Validar

## Estrutura

Confirmar existência:

* Entities/
* Enums/
* Interfaces/
* ValueObjects/
* Common/

---

## Entidades

Validar:

* Movie
* Genre
* Favorite
* WatchHistory

---

## Enums

Validar:

* MovieStatus

---

## Value Objects

Validar:

* Rating
* ImageUrl

---

## Interfaces

Validar:

* IMovieRepository
* IFavoriteRepository
* IHistoryRepository

---

# Regras arquiteturais

Confirmar:

* domínio sem dependência externa;
* domínio sem EF Core;
* domínio sem TMDB;
* domínio limpo;
* sem acoplamento indevido.

---

# Resultado esperado

Phase 02 — Domain Core concluída com sucesso.

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Phase 02 concluída.

Liberar:
Phase 03 — Integration Layer.
