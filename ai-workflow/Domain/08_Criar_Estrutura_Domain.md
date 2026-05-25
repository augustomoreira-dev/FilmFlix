# 08 — Criar Estrutura Domain

## Objetivo
Criar a estrutura de pastas e projetos do domínio (Domain Core) do FilmFlix.

## Passos recomendados
- Criar pasta `src/FilmFlix.Domain/` no backend (se ainda não existir).
- Definir subpastas: `Entities`, `ValueObjects`, `Enums`, `Repositories`.
- Adicionar README com convenções de nomes e responsabilidades.

## Resultado esperado
- Estrutura de pastas criada e versionada.
- README documentando convenções.

## Notas
Não implementar entidades nesta etapa; criar apenas a estrutura física.


# STEP 08 — Criar Estrutura Domain

## Objetivo

Criar a organização inicial da camada Domain.

---

# Estrutura esperada

FilmFlix.Domain/
│
├── Entities/
├── Enums/
├── Interfaces/
├── ValueObjects/
└── Common/

---

# Objetivo arquitetural

Separar responsabilidades do domínio.

---

# IMPORTANTE

NÃO implementar:

* integração TMDB;
* banco;
* EF Core;
* controllers;
* lógica frontend;
* serviços complexos.

---

# Resultado esperado

Estrutura de domínio organizada e limpa.

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Phase 02 iniciada.

Depois:
PARAR e aguardar validação.
