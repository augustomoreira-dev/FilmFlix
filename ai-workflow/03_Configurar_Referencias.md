# 03 — Configurar Referências

## Objetivo
Configurar referências entre projetos e dependências compartilhadas.

## Passos recomendados
- Definir contratos e bibliotecas compartilhadas (p. ex. `FilmFlix.Contracts`).
- Adicionar referências de projeto (ProjectReference) apenas quando os contratos estiverem aprovados.
- Documentar dependências externas (nugets) e versões aprovadas.

## Verificações
- Não criar dependências circulares.
- Registrar decisões em ADRs quando necessário.

# STEP 03 — Configurar Referências

## Objetivo

Configurar referências corretas entre os projetos.

## Regras arquiteturais

FilmFlix.Domain

* não referencia ninguém

FilmFlix.Application

* referencia Domain

FilmFlix.Infrastructure

* referencia Application + Domain

FilmFlix.Api

* referencia Application + Infrastructure

## IMPORTANTE

Não implementar lógica.
Não criar controllers.
Não criar serviços.

## Após concluir

PARAR e aguardar validação.
