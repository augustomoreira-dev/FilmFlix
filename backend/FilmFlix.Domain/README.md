# FilmFlix.Domain

## Convecoes da camada Domain

- Esta camada contem apenas modelos de dominio, value objects, enums, interfaces de contrato e elementos de uso comum do dominio.
- Nao deve depender de infraestrutura, persistencia, EF Core ou servicos externos.
- Nao implementar integracoes com TMDB, banco de dados ou logica de API/front-end aqui.
- Pastas:
  - `Entities/` — entidades do dominio.
  - `Enums/` — enums de dominio.
  - `Interfaces/` — contratos e repositorios.
  - `ValueObjects/` — objetos de valor imutaveis.
  - `Common/` — utilitarios e padroes de dominio compartilhados.

## Uso

- Criar apenas definicoes de dominio nesta etapa.
- Validar a estrutura antes de implementar.
