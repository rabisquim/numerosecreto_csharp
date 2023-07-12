
# Número Secreto

Este é um jogo simples em C# chamado "Número Secreto". O objetivo do jogo é adivinhar um número aleatório gerado pelo computador dentro de um intervalo específico.



## Funcionalidades

   O jogo oferece as seguintes funcionalidades:

Novo jogo: Inicia um novo jogo onde o jogador deve tentar adivinhar o número secreto.
Sair do jogo: Encerra o jogo.

## Uso

Ao iniciar o jogo, será exibido o título "NÚMERO SECRETO" seguido do menu principal. Você pode selecionar a opção desejada digitando o número correspondente e pressionando Enter.

## Novo Jogo

Essa opção permite iniciar um novo jogo. O jogador será solicitado a digitar seu nome e receberá uma mensagem de boas-vindas. O jogador terá 5 chances para adivinhar o número secreto.

* O número secreto é gerado aleatoriamente pelo computador no intervalo de 1 a 100.
* O jogador deve digitar um número entre 1 e 100 para fazer uma tentativa.
* Após cada tentativa, o jogo informará se o número digitado é maior ou menor do que o número secreto.
* Se o jogador acertar o número secreto, será exibida uma mensagem de parabéns junto com o número de tentativas feitas.
* Se o jogador não acertar o número dentro das 5 tentativas, será informado que o jogo acabou e será revelado o número secreto.


## Sair do Jogo

Essa opção encerra a execução do jogo.

## Observações

O código utiliza as funções `ExibeTitulo()` e `ExibeMenu()` para exibir o título e o menu principal do jogo.
O jogo faz uso da classe `Random` para gerar o número secreto aleatoriamente.
Durante a execução do jogo, são utilizados comandos de entrada e saída para interagir com o jogador.
O jogo é iniciado chamando as funções `ExibeTitulo()` e `ExibeMenu()`. Isso exibirá o título e o menu principal do jogo, permitindo que o jogador selecione uma opção.
