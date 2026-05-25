# 15 — Criar Interfaces de Repositório

## Objetivo
Definir as interfaces de repositório para o Domain Core (contratos apenas).

## Passos recomendados
- Definir interfaces: `IMovieRepository`, `IGenreRepository`, `IFavoriteRepository`, `IWatchHistoryRepository`.
- Documentar métodos essenciais (Add, GetById, Find, Remove, ListPaged).
- Criar esqueleto em `FilmFlix.Domain/Repositories/` com arquivos `.cs` de interface (contrato).

## Resultado esperado
- Contratos de repositório definidos e prontos para implementação pela camada Infrastructure.

## Notas
Não implementar detalhes de acesso a dados; apenas contratos e comentários sobre comportamento.


# STEP 15 — Criar Interfaces Repositório

## Objetivo

Criar contratos principais de persistência do domínio.

---

# Criar

* IMovieRepository
* IFavoriteRepository
* IHistoryRepository

---

# Responsabilidade

Definir contratos sem acoplar infraestrutura.

---

# IMPORTANTE

NÃO implementar:

* SQLite;
* EF Core;
* queries reais.

Criar SOMENTE interfaces.

---

# Objetivo arquitetural

Aplicar:
Dependency Inversion Principle.

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Interfaces concluídas.

Depois:
PARAR e aguardar validação.
