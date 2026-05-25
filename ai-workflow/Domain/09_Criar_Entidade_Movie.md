# 09 — Criar Entidade Movie

## Objetivo
Definir a entidade `Movie` (esqueleto de domínio) com propriedades e invariantes essenciais.

## Passos recomendados
- Definir propriedades: `Id`, `Title`, `Synopsis`, `ReleaseDate`, `DurationMinutes`, `Genres` (lista de ids ou value objects).
- Documentar invariantes e validações (ex: `Title` não vazio, `DurationMinutes` > 0).
- Criar arquivo de especificação/contrato em `FilmFlix.Domain/Entities/Movie.cs` (esqueleto apenas).

## Resultado esperado
- Esqueleto da entidade `Movie` documentado e pronto para implementação controlada.

## Notas
Não implementar lógica de persistência ou métodos complexos; manter apenas a definição do modelo.


# STEP 09 — Criar Entidade Movie

## Objetivo

Criar a principal entidade do domínio:
Movie.

---

# Responsabilidade

Representar um filme normalizado internamente no FilmFlix.

O domínio NÃO deve copiar diretamente a TMDB.

---

# Campos esperados

Movie
├── Id
├── ExternalId
├── Title
├── OriginalTitle
├── Overview
├── PosterUrl
├── BackdropUrl
├── ReleaseDate
├── Runtime
├── Rating
├── VoteCount
├── Popularity
├── Language
├── Genres
├── TrailerUrl
├── IsAdultContent
├── Status
├── CreatedAt
└── UpdatedAt

---

# Regras obrigatórias

* Title obrigatório
* ExternalId obrigatório
* Rating deve possuir faixa válida
* Entidade limpa
* Sem dependência TMDB

---

# IMPORTANTE

NÃO adicionar:

* atributos EF Core;
* JSON attributes;
* HttpClient;
* lógica externa.

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Entidade Movie concluída.

Depois:
PARAR e aguardar validação.
