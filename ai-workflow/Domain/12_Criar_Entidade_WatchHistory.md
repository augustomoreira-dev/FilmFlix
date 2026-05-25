# 12 — Criar Entidade WatchHistory

## Objetivo
Definir a entidade `WatchHistory` para registrar exibições de filmes por usuário.

## Passos recomendados
- Definir propriedades: `Id`, `UserId`, `MovieId`, `WatchedAt`, `ProgressPercent` (opcional).
- Documentar invariantes e políticas de retenção (quando aplicável).
- Criar esqueleto em `FilmFlix.Domain/Entities/WatchHistory.cs`.

## Resultado esperado
- Esqueleto da entidade `WatchHistory` criado e documentado.

## Notas
Evitar incluir comportamento de agregação nesta etapa; foco na modelagem.


# STEP 12 — Criar Entidade WatchHistory

## Objetivo

Criar histórico de visualização local.

---

# Campos esperados

WatchHistory
├── Id
├── MovieId
├── WatchedAt
├── Progress
└── LastPosition

---

# Responsabilidade

Representar histórico de navegação e consumo.

---

# Regras obrigatórias

* Progress entre 0 e 100
* Estrutura preparada para player futuro

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Entidade WatchHistory concluída.

Depois:
PARAR e aguardar validação.
