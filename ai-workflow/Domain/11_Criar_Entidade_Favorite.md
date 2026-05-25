# 11 — Criar Entidade Favorite

## Objetivo
Definir a entidade `Favorite` que liga usuários a filmes favoritados.

## Passos recomendados
- Definir propriedades: `Id`, `UserId`, `MovieId`, `CreatedAt`.
- Documentar regras (ex: um usuário não deve favoritar o mesmo filme duas vezes).
- Criar esqueleto em `FilmFlix.Domain/Entities/Favorite.cs`.

## Resultado esperado
- Esqueleto da entidade `Favorite` pronto para implementação.

## Notas
Não implementar lógica de infraestrutura; apenas definir o modelo e regras de domínio.


# STEP 11 — Criar Entidade Favorite

## Objetivo

Criar entidade de favoritos locais.

---

# Campos esperados

Favorite
├── Id
├── MovieId
├── CreatedAt
└── Notes

---

# Responsabilidade

Representar filmes favoritos do usuário local.

---

# Regras obrigatórias

* Não duplicar MovieId
* Estrutura simples
* Preparado para evolução futura

---

# IMPORTANTE

Ainda NÃO implementar:

* autenticação;
* múltiplos usuários;
* sincronização cloud.

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Entidade Favorite concluída.

Depois:
PARAR e aguardar validação.
