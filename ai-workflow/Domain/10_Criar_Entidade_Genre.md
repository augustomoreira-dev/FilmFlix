# 10 — Criar Entidade Genre

## Objetivo
Definir a entidade `Genre` que representa categorias de filmes.

## Passos recomendados
- Definir propriedades: `Id`, `Name`, `Description` (opcional).
- Documentar invariantes (ex: `Name` não nulo/nem vazio).
- Criar especificação/esqueleto em `FilmFlix.Domain/Entities/Genre.cs`.

## Resultado esperado
- Esqueleto da entidade `Genre` criado e documentado.

## Notas
Manter a entidade simples; relações com `Movie` devem ser por referências/ids.


# STEP 10 — Criar Entidade Genre

## Objetivo

Criar entidade de categorias de filmes.

---

# Campos esperados

Genre
├── Id
├── ExternalId
├── Name
└── Slug

---

# Responsabilidade

Representar categorias internas do sistema.

---

# IMPORTANTE

* Nome obrigatório
* Slug preparado para frontend
* Não depender da TMDB

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Entidade Genre concluída.

Depois:
PARAR e aguardar validação.
