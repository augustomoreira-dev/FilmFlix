# 14 — Criar Value Objects

## Objetivo
Definir value objects relevantes para o domínio (ex: `Duration`, `LocalizedTitle`).

## Passos recomendados
- Identificar propriedades com comportamento/validação que fazem sentido como VO.
- Criar pasta `FilmFlix.Domain/ValueObjects/` e arquivos esqueleto.
- Documentar invariantes e exemplos de uso nas entidades.

## Resultado esperado
- Conjunto inicial de value objects definido e documentado.

## Notas
Value objects devem ser imutáveis e ter validações claras.


# STEP 14 — Criar Value Objects

## Objetivo

Criar objetos de valor reutilizáveis do domínio.

---

# Criar

* Rating
* ImageUrl

---

# Responsabilidade

## Rating

Garantir:

* faixa válida;
* semântica clara;
* encapsulamento.

---

## ImageUrl

Garantir:

* representação consistente de imagens.

---

# IMPORTANTE

Value Objects:

* devem ser imutáveis;
* sem dependências externas;
* sem lógica de infraestrutura.

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Value Objects concluídos.

Depois:
PARAR e aguardar validação.
