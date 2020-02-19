No indicador 1. Analisa os elementos para programação desktop e cliente/servidor, que tem como critério a Análise, o objetivo é consolidar a prática em Programação Orientada a Objetos bem como sua aplicabilidade em sistemas desktop, permitindo ao estudante aplicar as relações da vida real em objetos estruturas em uma linguagem de desenvolvimento orientado a objetos, bem como fixar os conteúdos já aplicados em sala de aula. Este indicador foi subdivido em 2 (duas) atividades avaliativas, onde a primeira consiste na consolidação do conhecimento na linguagem C# e sua compatibilidade com a linguagem Java. 

Para analisar o aprendizado, desenvolva um mini sistema de locação de filmes, estilo Blockbuster, que possui como entidades:
* Cliente
    - Identificador Único (ID) (idCliente)
    - Nome (nomeCliente)
    - Data de Nascimento (dtNasc)
    - C.P.F. (cpf)
    - Dias para Devolução (dtDevolucao)
* Filme
    - Identificador Único (ID) (idFilme)
    - Nome (nomeFilme)
    - Data de Lançamento (dtLancamento)
    - Sinopse (sinopse)
    - Valor para Locação (valor)
    - Estoque (qtdEstoque)
* Locação
    - Identificador Único (ID) (idLocacao)
    - I.D. do Cliente (idCliente)
    - Data de Locação (dtLocacao)
    - Data de Devolução (dtDevolucao)
* Filmes Locados
    - I.D. da Locação (idLocacao)
    - I.D. do Filme (idFilme)

Os arquivos fontes deverão ser organizados com `namespaces` coerentes e os objetos possuem os seguintes relacionamentos:
* Cliente possui relacionamento 1-N com Locação
* Locação possui relacionamento 1-N com Filmes Locados
* Filmes possui relacionamento 1-N com Filmes Locados

Não é necessária a utilização de bancos de dados, podendo utilizar `collections` para esta finalidade.

Cada objeto deverá conter, minimamente:
* Cliente
    - Método com a Quantidade de Filmes locados
* Filme
    - Método com a Quantidade de locações realizadas
* Locação
    - Método com o Valor total da Locação
    - Método com a quantidade de filmes locados
    - A data de devolução deverá ser calculada com base na Data de Locação e a quantidade de dias para Devolução que o cliente tem disponível na locadora.

Deverá ser criado um arquivo principal para gerenciamento das informações dos objetos, onde deverão ser criados 10 filmes (a sua escolha) e 5 clientes. Cada cliente deverá fazer algumas locações de filmes e ao final deverá ser exibida a Quantidade de Filmes locados por cada cliente, a quantidade de Locações dos Filmes e o valor total de locação e a quantidade de filmes por Locação.

O código fonte deverá ser trabalhando dentro do GitHub, sendo sincronizado e aberto PR ao final do desenvolvimento.
