# 🏓 Pong Evolutivo

Projeto inspirado no clássico Pong desenvolvido na Unity utilizando C#.

---

## 📖 Resumo do Projeto

Este projeto recria o clássico jogo Pong em uma versão moderna, com foco em aprendizado de desenvolvimento de jogos, sistemas de pontuação, inteligência artificial e ranking online.

O jogador controla uma plataforma enquanto enfrenta uma CPU que rebate a bola automaticamente.

---

## 🎮 Gameplay

![Gameplay](images/gameplay.png)

---

## ✅ Funcionalidades atuais

- Menu inicial
- Partida jogador vs CPU
- Sistema de pontuação
- Física da bola
- Tela de Game Over
- Reinício de partida
- Sistema de ranking
- Login de usuários

---

## 🚧 Funcionalidades futuras


- Multiplayer online
- Loja de melhorias
- Power-ups durante a partida
- Modo mobile (APK)

---

## 🛠️ Tecnologias utilizadas

- Unity
- C#
- Git
- GitHub
- Visual Studio Code
- HTML
- CSS
- JavaScript
- PHP
- Xampp

---

## 📂 Estrutura do projeto

```txt
Assets/
ProjectSettings/
Packages/
README.md
```

---

## ▶️ Como executar o projeto

1. Clone o repositório:

```bash
git clone https://github.com/SEU_USUARIO/pongGame.git
```

2. Abra o projeto na Unity

3. Execute a cena principal

---

## 📸 Screenshots

### Menu Inicial

![Menu](images/menuPongUnity.png)

### Tela de Configurações

![Settings](images/settings.png)


### Gameplay, efeitos visuais da pontuação

![Gameplay](images/gameplay2.png)

### Game Over

![GameOver](images/gameOver.png)

---

### Web Site(PongWeb)

### Página de Login
![PaginaLogin](images/pongWebLogin.png)

### Página Principal
![PaginaPrincipal](images/pongWeb.png)

## 👨‍💻 Autor

Rodrigo Franco

GitHub:
https://github.com/RodrigoFr10


## Pong Evolutivo - A Reconstrução de um Clássico 

## 📖 Resumo do Projeto

Jogos digitais competitivos e casuais continuam sendo amplamente utilizados como forma de entretenimento e interação entre usuários em diferentes plataformas. Entretanto, versões clássicas como o Pong não possuem, em sua forma original, recursos modernos de progressão, interação social e funcionalidades online, o que pode limitar o engajamento dos jogadores atuais.

Este projeto propõe o desenvolvimento de uma releitura do jogo Pong utilizando a Unity, integrada a um website responsável por funcionalidades complementares. Entre os recursos implementados ou planejados estão inteligência artificial, sistema de pontuação, ranking de jogadores, rede social para compartilhamento de conteúdos e possíveis funcionalidades multiplayer. Dessa forma, busca-se unir a simplicidade de um jogo clássico com recursos contemporâneos de interação, competitividade e gerenciamento da comunidade de jogadores.


# ❗ Definição do Problema

Jogos clássicos como Pong marcaram a história da indústria dos jogos digitais devido à simplicidade de suas mecânicas e facilidade de acesso por diferentes públicos. Entretanto, muitas versões atuais desses jogos preservam apenas sua proposta original, sem incorporar funcionalidades modernas capazes de aumentar a competitividade, a progressão e a interação entre jogadores. Como consequência, a experiência oferecida pode não atender às expectativas do público atual, reduzindo o engajamento e a retenção dos usuários.

Além disso, o desenvolvimento de jogos digitais modernos envolve desafios técnicos relevantes, como a implementação de inteligência artificial, gerenciamento de estados de jogo, persistência de dados, integração entre diferentes aplicações e interfaces voltadas à interação dos usuários. Esses elementos aproximam projetos acadêmicos das práticas utilizadas na indústria de desenvolvimento de software e jogos digitais.

Durante a etapa de discovery, foi identificado que diversos jogos casuais modernos utilizam sistemas de ranking, progressão, feedback visual e funcionalidades online para ampliar a competitividade e aumentar o tempo de retenção dos jogadores. Também foi observado que jogos clássicos continuam sendo amplamente utilizados como base para estudos e prototipagem, devido à simplicidade de sua estrutura e ao potencial para expansão de funcionalidades.

Nesse contexto, o projeto propõe o desenvolvimento de uma releitura do jogo Pong utilizando a Unity, integrada a um website responsável pelas funcionalidades online e pelo gerenciamento da comunidade de jogadores. O sistema inclui recursos como inteligência artificial para oponente, sistema de pontuação, ranking persistente e interação entre jogadores por meio da plataforma web. Dessa forma, busca-se combinar a jogabilidade clássica do Pong com recursos modernos de competição, persistência de dados e interação social.


# 🎯 Objetivos

## Objetivo Geral

Desenvolver uma releitura moderna do jogo Pong utilizando a engine Unity, integrada a um website e a um backend para oferecer funcionalidades online. O projeto combina as mecânicas clássicas de gameplay com recursos contemporâneos, como inteligência artificial, sistema de pontuação, ranking persistente e uma plataforma social para interação entre jogadores, proporcionando uma experiência competitiva, interativa e acessível.

---

## Objetivos Específicos

- Implementar a movimentação das plataformas e da bola utilizando física 2D.
- Desenvolver um sistema de pontuação funcional durante as partidas.
- Criar uma inteligência artificial capaz de controlar o oponente.
- Implementar telas de interface, como menu inicial e tela de Game Over.
- Desenvolver um sistema de ranking para armazenamento de pontuações.
- Aplicar conceitos de desenvolvimento de jogos digitais utilizando C# e Unity.
- Proporcionar uma experiência simples e intuitiva para jogadores casuais e competitivos.
- Implementar um sistema de autenticação compartilhado entre o jogo e o website.
- Desenvolver um website com funcionalidades de rede social permitindo a publicação de postagens, comentários e reações.


# 🛠️ Stack Tecnológico

## Unity

A Unity será utilizada como engine principal para o desenvolvimento do jogo. A plataforma oferece suporte ao desenvolvimento de jogos 2D e 3D, accessibilidade com versões gratuitas, além de disponibilizar ferramentas integradas para física, animação, interface gráfica e gerenciamento de cenas. Sua ampla documentação oficial, grande comunidade e compatibilidade multiplataforma tornam a Unity uma das engines mais utilizadas na indústria de jogos digitais.

A escolha da Unity para este projeto deve-se à facilidade de prototipagem, integração com a linguagem C# e suporte à exportação para diferentes plataformas, como computadores e dispositivos móveis.

Documentação oficial:  
https://unity.com/

---

## C#

A linguagem C# será utilizada para implementação da lógica do jogo, controle de movimentação, inteligência artificial, sistema de pontuação e demais funcionalidades do projeto. O C# é amplamente utilizado no desenvolvimento com Unity devido à integração nativa oferecida pela engine.

Sua sintaxe orientada a objetos, organização estrutural e facilidade de manutenção contribuem para o desenvolvimento de sistemas escaláveis e de fácil compreensão.

Documentação oficial:  
https://learn.microsoft.com/dotnet/csharp/

---

## Visual Studio

O Visual Studio será utilizado como ambiente de desenvolvimento integrado (IDE) para criação e edição dos scripts em C#. A ferramenta oferece recursos como depuração, autocomplete, organização de código e integração com Unity.

A escolha da IDE ocorre devido à compatibilidade direta com projetos Unity e à disponibilidade de ferramentas que auxiliam na produtividade e manutenção do código-fonte.

Documentação oficial:  
https://visualstudio.microsoft.com/

---

## Git e GitHub

O Git será utilizado para controle de versão do projeto, permitindo registrar alterações no código-fonte e manter histórico de desenvolvimento. Já o GitHub será utilizado para armazenamento remoto do repositório e gerenciamento colaborativo do projeto.

A utilização dessas ferramentas facilita o versionamento, backup do projeto e acompanhamento da evolução do desenvolvimento.

Git:  
https://git-scm.com/

GitHub:  
https://github.com/

---

## HTML 5
O HTML5 será utilizado para estruturar as páginas do website, definindo elementos como formulários, menus, postagens, comentários e demais componentes da interface. A linguagem é o padrão para construção de páginas web e oferece recursos semânticos que facilitam a organização do conteúdo, a acessibilidade e a compatibilidade entre navegadores.

A escolha do HTML5 deve-se à sua simplicidade, ampla compatibilidade com navegadores modernos e integração com CSS e JavaScript para o desenvolvimento de interfaces web.

Documentação oficial:
https://developer.mozilla.org/docs/Web/HTML

---

## CSS3

O CSS3 será utilizado para estilizar a interface do website, definindo cores, tipografia, espaçamentos, posicionamento dos elementos e responsividade. A tecnologia permite separar a apresentação da estrutura da página, facilitando a manutenção e evolução do sistema.

A escolha do CSS3 deve-se à sua flexibilidade para criação de interfaces modernas, responsivas e compatíveis com diferentes dispositivos e navegadores.

Documentação oficial:
https://developer.mozilla.org/docs/Web/CSS

---

## JavaScript
O JavaScript será utilizado para adicionar interatividade ao website, permitindo a manipulação dinâmica dos elementos da página, validação de formulários, comunicação assíncrona com o servidor e atualização de conteúdos sem necessidade de recarregar completamente a página.

A escolha do JavaScript deve-se à sua ampla utilização no desenvolvimento web, integração nativa com navegadores e facilidade de comunicação com aplicações backend.

Documentação oficial:
https://developer.mozilla.org/docs/Web/JavaScript

---

## PHP

O PHP será utilizado como linguagem de desenvolvimento do backend do website, sendo responsável pelo processamento das requisições, autenticação de usuários, gerenciamento de sessões, comunicação com o banco de dados e implementação das regras de negócio da aplicação.

A escolha do PHP deve-se à sua simplicidade de desenvolvimento, ampla documentação, boa integração com servidores web e bancos de dados relacionais, além de ser amplamente utilizado em aplicações web dinâmicas.

Documentação oficial:
https://www.php.net/

---

## MySql
O MySQL será utilizado como sistema de gerenciamento de banco de dados relacional, responsável pelo armazenamento das informações dos usuários, postagens, comentários, reações, pontuações e ranking do sistema.

A escolha do MySQL deve-se ao seu desempenho, confiabilidade, facilidade de integração com PHP, ampla documentação e grande utilização em aplicações web.

Documentação oficial:
https://www.mysql.com/

---

## XAMPP 
O XAMPP será utilizado como ambiente de desenvolvimento local, fornecendo os serviços necessários para execução da aplicação web, incluindo o servidor Apache, o interpretador PHP e o banco de dados MySQL.

A escolha do XAMPP deve-se à facilidade de instalação e configuração, permitindo reunir em um único ambiente todas as ferramentas necessárias para o desenvolvimento e testes da aplicação.

Documentação oficial:
https://www.apachefriends.org/

# 🧩 Descrição da Solução

A solução proposta consiste no desenvolvimento de uma releitura moderna do jogo Pong utilizando a engine Unity, integrada a um website desenvolvido com HTML, CSS, JavaScript e PHP, além de um banco de dados MySQL para armazenamento persistente das informações dos usuários e das partidas.

Enquanto o Pong clássico limita a experiência ao momento da partida, sem registrar pontuações ou permitir interação entre jogadores, este projeto amplia essa proposta ao oferecer um ecossistema integrado. As pontuações passam a ser armazenadas em um ranking persistente, permitindo que os jogadores acompanhem seu desempenho ao longo do tempo e o comparem com outros usuários. Dessa forma, conquistas que antes eram perdidas ao encerrar o jogo tornam-se permanentes e compartilháveis.

O jogo mantém as mecânicas clássicas do Pong, com controle das plataformas, movimentação física da bola, sistema de pontuação e um oponente controlado por inteligência artificial. A interface foi desenvolvida para oferecer uma experiência simples e intuitiva, preservando a acessibilidade do jogo original enquanto adiciona novos recursos.

O website complementa a experiência do jogo ao fornecer autenticação de usuários, compartilhando o mesmo sistema de login utilizado na aplicação desenvolvida em Unity. Além do ranking, a plataforma oferece funcionalidades de rede social, permitindo que os jogadores publiquem postagens, comentem conteúdos e expressem suas reações, incentivando a interação da comunidade.

A comunicação entre o jogo, o website e o banco de dados permite centralizar as informações dos usuários e manter a consistência dos dados entre as diferentes aplicações. O projeto também utiliza Git e GitHub para controle de versão e gerenciamento colaborativo do código-fonte, seguindo práticas adotadas no desenvolvimento moderno de software.

Dessa forma, a solução preserva a simplicidade e a jogabilidade que tornaram o Pong um clássico, ao mesmo tempo em que incorpora recursos atuais de persistência de dados, competitividade e interação social, proporcionando uma experiência mais completa aos jogadores.

Telas do sistema vão nesta seção


# 🎮 Regras do Jogo

## Objetivo da Partida

O jogador controla a plataforma localizada na parte inferior da tela, enquanto o oponente é controlado por uma inteligência artificial posicionada na parte superior. O objetivo é impedir que a bola ultrapasse sua plataforma e marcar pontos contra o adversário para avançar de nível.

---

## Sistema de Pontuação

* A pontuação é exibida em tempo real durante toda a partida.
* Cada vez que um jogador marca um ponto, sua pontuação é incrementada em **1**.
* A pontuação final registrada no ranking é calculada pela fórmula:

**Pontuação Final = Pontuação do Jogador − Pontuação do Inimigo**

Esse cálculo recompensa vitórias mais dominantes e reduz a pontuação obtida em partidas muito equilibradas ou derrotas.

---

## Crescimento das Plataformas

Sempre que um jogador marca um ponto:

* A plataforma do jogador que pontuou aumenta de tamanho.
* A plataforma do adversário diminui de tamanho.

Esse sistema altera dinamicamente a dificuldade da partida, recompensando o jogador que estiver em vantagem.

Para manter o equilíbrio do jogo:

* Nenhuma plataforma pode ultrapassar metade da altura da tela.
* Se a plataforma do jogador ficar menor que **0.4**, a partida termina e a tela de Game Over é exibida.
* Se a plataforma da inteligência artificial ficar menor que **0.4**, o jogador vence a fase e avança para o próximo nível.

---

## Progressão de Dificuldade

A cada nível concluído:

* A velocidade de movimentação da plataforma controlada pela inteligência artificial aumenta.

Isso torna as partidas progressivamente mais desafiadoras conforme o jogador avança.

---

## Velocidade da Bola

A velocidade da bola é ajustada dinamicamente durante a partida:

* Cada vez que a bola rebate na plataforma do jogador, sua velocidade aumenta.
* Sempre que o oponente marca um ponto, a velocidade da bola é reduzida levemente.

Essa mecânica busca equilibrar a dificuldade, evitando que a bola permaneça rápida demais após longas sequências de rebatidas.

---

## Recorde Pessoal

Ao final da partida, a pontuação final é comparada ao recorde pessoal do jogador.

Caso a nova pontuação seja superior à anteriormente registrada, ela passa a ser o novo recorde pessoal e é armazenada no banco de dados para atualização do ranking.


### Em resumo:
- O jogador controla a plataforma de baixo.
- A IA controla a plataforma de cima.
- O objetivo é impedir que a bola passe pela sua plataforma enquanto tenta marcar pontos no adversário.
- Sistema de pontuação
- A pontuação é exibida em tempo real.
- Cada pontuação aumenta em 1 a pontuação do jogador que marcou.
- A plataforma que pontua cresce e sua inimiga diminui.
- Feedback visual
- O jogador que pontua fica verde e cresce um pouco e seu inimigo fica vermelho e diminui.
- Nenhuma plataforma pode ficar maior que metade do tamanho da tela, impedindo 
- Se a plataforma do jogador ficar menor que 0.4f, ele é levado pra tela de game over
- Se a plataforma inimiga ficar menor que 0.4f, o jogador passa de nível
- A cada nível que o jogador passa, a plataforma inimiga fica mais rápida.
- Cada vez que a bola rebate no jogador, ela fica mais rápida.
- Cada vez que o inimigo pontua a bola perde um pouco de velocidade, facilitando e equilibrando o jogo caso a bola estiver rápida demais para o jogador rebater
- A pontuação final é a pontuação do jogador menos a pontuação do inimigo
- Se a pontuação do jogador for maior que sua pontuação anterior, ela sobscreve e se torna o novo recorde pessoal



# 🏗️ Arquitetura

A arquitetura do projeto foi organizada de forma modular, permitindo separação entre os componentes responsáveis pela lógica do jogo, interface gráfica, gerenciamento de estados e futuras integrações online. O sistema foi desenvolvido utilizando a engine Unity, adotando uma estrutura baseada em cenas e scripts independentes em C#, facilitando manutenção, escalabilidade e futuras expansões do projeto.

O repositório do projeto contém os artefatos produzidos durante o processo de desenvolvimento, incluindo documentos de planejamento, modelagem, levantamento de requisitos e prototipação. Esses materiais auxiliam na organização do projeto e no acompanhamento das decisões tomadas ao longo das etapas de desenvolvimento.

Repositório do projeto:  
https://github.com/RodrigoFr10/pongGame

---

### 5. Diagrama de Arquitetura

Representação geral da organização dos componentes do sistema, demonstrando aproximadamente seu funcionamento.

![Arquitetura](images/imageArquitetura.png)