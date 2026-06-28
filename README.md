# Hashes

Aplicação console em C# para validar pares de hashes informados em uma única linha.

## Descrição

Esta ferramenta lê uma linha de entrada contendo pares de hashes separados por ponto e vírgula (`;`). Cada par deve ter dois valores separados por vírgula (`,`):
- hash calculado
- hash esperado

O programa compara os hashes em cada par e imprime `Correto` ou `Invalido` para cada comparação.

## Formato de entrada

Exemplo de entrada:

```
abc123,abc123;def456,xyz789
```

Saída esperada:

```
Correto
Invalido
```

## Como usar

1. Abra o terminal na pasta do projeto `Hashes`.
2. Compile o projeto com:

```bash
dotnet build
```

3. Execute a aplicação com:

```bash
dotnet run --project Hashes.csproj
```

4. Digite a linha de entrada e pressione Enter.

## Observações

- Não há validação de formato de entrada; o programa assume que cada par contém exatamente dois valores.
- O separador de pares é `;` e o separador interno é `,`.
