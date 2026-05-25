# 13 — Criar Enums do Domínio

## Objetivo
Definir enums compartilhados do domínio (ex: `Rating`, `ContentType`).

## Passos recomendados
- Listar enums necessários e seus valores permitidos.
- Criar arquivos em `FilmFlix.Domain/Enums/` com descrições.
- Referenciar enums nas entidades quando apropriado.

## Resultado esperado
- Enum set básico criado e documentado.

## Notas
Evitar expor enums que possam variar frequentemente; preferir value objects para casos complexos.


# STEP 13 — Criar Enums Domínio

## Objetivo

Criar enums principais do domínio.

---

# Criar

MovieStatus:

* Released
* Upcoming
* Rumored
* Cancelled

---

# Objetivo arquitetural

Evitar strings mágicas no domínio.

---

# IMPORTANTE

Enums devem permanecer:

* simples;
* sem lógica;
* reutilizáveis.

---

# Após concluir

Atualizar:
sdd/Projeto_Status.md

Marcar:
Enums concluídos.

Depois:
PARAR e aguardar validação.
