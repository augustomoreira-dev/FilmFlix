# FilmFlix — Projeto Status

## Objetivo

Este documento controla oficialmente:

* andamento do projeto;
* fases do SDD;
* validações;
* checkpoints;
* progresso arquitetural.

---

# Status Geral

| Área                | Status       |
| ------------------- | ------------ |
| Foundation          | Em andamento |
| Domain Core         | Em andamento |
| Integration Layer   | Não iniciado |
| Application Layer   | Não iniciado |
| API Layer           | Não iniciado |
| Frontend Foundation | Não iniciado |
| Frontend Features   | Não iniciado |
| Qualidade           | Não iniciado |

---

# Phase 01 — Foundation

## Objetivo

Criar a estrutura física e arquitetural inicial do projeto.

---

## Checklist

| Etapa                      | Status | Validação |
| -------------------------- | ------ | --------- |
| Criar estrutura raiz       | ✅      | Validado  |
| Criar backend/             | ✅      | Validado  |
| Criar frontend/            | ✅      | Validado  |
| Criar docs/                | ✅      | Validado  |
| Criar skills/              | ✅      | Validado  |
| Criar sdd/                 | ✅      | Validado  |
| Criar ai-workflow/         | ✅      | Validado  |
| Criar FilmFlix.sln         | ✅      | Validado  |
| Criar projetos backend     | ✅      | Validado  |
| Configurar referências     | ✅      | Validado  |
| Criar Angular workspace    | ✅      | Validado  |
| Validar arquitetura física | ⬜      | Pendente  |

---

# Critérios de conclusão da Phase 01

A fase será considerada concluída quando:

* solution estiver criada;
* projetos backend compilarem;
* referências estiverem corretas;
* Angular iniciar corretamente;
* arquitetura física validada;
* sem arquivos soltos;
* sem duplicações.

---

# Phase 02 — Domain Core

## Objetivo
Modelar as entidades principais do domínio do FilmFlix.

---

## Checklist

| Etapa                    | Status | Validação |
| ------------------------ | ------ | --------- |
| Criar entidade Movie     | ✅      | Validado  |
| Criar entidade Genre     | ✅      | Validado  |
| Criar entidade Favorite  | ✅      | Validado  |
| Criar entidade WatchHistory | ✅   | Validado  |
| Criar enums do domínio   | ✅      | Validado  |
| Criar value objects      | ✅      | Validado  |
| Criar interfaces repositorio | ✅ | Validado  |

---

# Bloqueios atuais

Nenhum.

---

# Próximo passo permitido

STEP 16 — Validar Domain Core

Arquivo:
ai-workflow/Domain/16_Validar_Domain_Core.md

---

# Regras obrigatórias do SDD

* Nunca avançar fases sem validação.
* Nunca implementar múltiplas fases juntas.
* Sempre validar arquitetura antes do código.
* Sempre atualizar este documento após cada etapa.
* Nunca improvisar arquitetura fora dos ADRs.
* Cada módulo deve ser incremental.

---

# Histórico de validações

## [2026-05-23]

Foundation inicial criada e validações recentes:

* `backend/` — solution e projetos criados
* `frontend/filmflix-web/` — scaffold Angular criado
* `docs/`, `skills/`, `sdd/`, `ai-workflow/` — existentes

Validações realizadas:

* `FILM-FLIX/backend/FilmFlix.sln` criado e verificado — VALIDADO
* Projetos backend (FilmFlix.Core, FilmFlix.Infrastructure, FilmFlix.Api, FilmFlix.Domain, FilmFlix.Application, FilmFlix.Tests) criados e adicionados à solution — VALIDADO
* Referências de projeto configuradas conforme regras de arquitetura — VALIDADO
* Frontend scaffold criado em `frontend/filmflix-web` com `ng new` — VALIDADO
* `npm install` concluído em `frontend/filmflix-web` — VALIDADO
* `ng serve` iniciado com sucesso; servidor disponível em `http://localhost:4200/` — VALIDADO
* Entidade `Movie` criada em `backend/FilmFlix.Domain/Entities/Movie.cs` — VALIDADO
* Entidade `Genre` criada em `backend/FilmFlix.Domain/Entities/Genre.cs` — VALIDADO
* Entidade `Favorite` criada em `backend/FilmFlix.Domain/Entities/Favorite.cs` — VALIDADO
* Entidade `WatchHistory` criada em `backend/FilmFlix.Domain/Entities/WatchHistory.cs` — VALIDADO
* Enums de domínio criados em `backend/FilmFlix.Domain/Enums/MovieStatus.cs` — VALIDADO
* Value Objects criados em `backend/FilmFlix.Domain/ValueObjects/` — VALIDADO
* Interfaces de repositório criadas em `backend/FilmFlix.Domain/Interfaces/` — VALIDADO

Status geral atualizado acima.

## Validação do Domain Core — Resultado da execução (2026-05-23)

Checks executados:

* Verificação de referências a infra/instrumentação: nenhum namespace ou uso de EF Core, System.Data, Dapper, HttpClient ou similares encontrado na pasta `backend/FilmFlix.Domain/`.
* Inspeção de Value Objects: `Rating` e `ImageUrl` implementam validações e são imutáveis conforme esperado.
* Inspeção de Entidades: `Movie`, `Genre`, `Favorite`, `WatchHistory` são modelos de domínio simples, sem dependências de infraestrutura.

Observações (ações recomendadas, não implementadas nesta etapa):

* `WatchHistory.ProgressPercent` é um `int` sem validação de invariante (0..100). Recomenda-se validar no construtor ou exposição via Value Object.
* `Favorite` registra regra de negócio (não duplicar `MovieId`) apenas em comentário; considerar invariantes ou políticas no Application Layer.
* `Movie.Status` está definido como `string`; considerar usar o enum `MovieStatus` para evitar strings mágicas.

Conclusão:

* Domain Core aprovado para implementação incremental, com as observações listadas acima que devem ser avaliadas em revisão arquitetural.
