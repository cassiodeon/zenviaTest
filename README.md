# zenviaTest

Este projeto trata-se do exercício técnico da Zenvia para o processo seletivo.
O problema escolhido para solucionar foi o do **Caixa Eletrônico**.

## Desenvolvimento

A solução foi desenvolvida em **.net core 3.1** e o projeto foi separado em 3 camadas:

- Business
- Tests
- ConsoleApp

A camada business contém duas classes: **CaixaEletronico** e **Notas**.

A classe CaixaEletronico possui uma lista de notas, desta forma quando um saque for realizado nela é possível verificar se o valor solicitado é válido e também as notas que serão emitidas.

No método sacar da classe CaixaEletronico, para conseguir computar quais notas serão emitas é percorrida a lista de notas, ordenada de forma decrescente, que o caixa eletrônico possui. Neste laço de repetição é utilizado a função DivRem da classe Math, que calcula o quociente de dois números e também retorna o restante em um parâmetro de saída. Logo, é possível calcular o menor número de notas a serem emitidas e também quais são essas notas.

A solução conta também com testes unitários para garantir o correto funcionamento e auxiliar na evolução do desenvolvimento da solução.
Os testes unitários foram desenvolvidos utilizando o framework **NUnit**. Segue a lista de casos cobertos pelos teste unitários:

- SacarDez_RetornaUmaNotaDez
- SacarValorExataNota_RetornaUmaNotaCorrespondente
- SacarOitenta_RetornaUmaCinquentaUmaVinteUmaDez
- SacarCentoOitenta_RetornaUmaCemUmaCinquentaUmaVinteUmaDez
- SacarDuzentosQuarenta_RetornaDuasCemDuasVinte
- SacarZero_RetornaErro
- SacarQuinze_RetornaErroValorIndisponivel

A camada ConsoleApp apenas possui uma aplicação de console que simula 2 saques nos valores de 80 e 130 em um caixa eletrônico que possui as notas 100, 50, 20 e 10.

Foi criada uma imagem Docker da solução a partir do publish do consoleApp para facilitar a sua verificação. Ela foi gerada a partir do arquivo dockerfile presente no repositório e está disponível no seguinte link [https://hub.docker.com/r/cassiodeon/zenviatest](https://hub.docker.com/r/cassiodeon/zenviatest)

## Autor
Cássio Deon - cassiodeon@hotmail.com