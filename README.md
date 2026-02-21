![ES-3](https://github.com/user-attachments/assets/ba89fbdc-3f30-4c35-8358-2990d871ead1)

# 🥁 CarnaCode 2026 - Desafio 08 - Composite

Oi, eu sou o **Leonardo Malavolti** e este é o espaço onde compartilho minha jornada de aprendizado durante o desafio **CarnaCode 2026**, realizado pelo balta.io. 👻

Aqui você vai encontrar projetos, exercícios e códigos que estou desenvolvendo durante o desafio. O objetivo é colocar a mão na massa, testar ideias e registrar minha evolução no mundo da tecnologia.

---

## 🚀 Sobre este desafio

No desafio **Composite** eu tive que resolver um problema real implementando o **Design Pattern Composite** para estruturar menus hierárquicos de forma uniforme.

Durante este processo eu aprendi:

- ✅ Boas Práticas de Software  
- ✅ Código Limpo  
- ✅ SOLID  
- ✅ Open/Closed Principle  
- ✅ Estruturas em Árvore  
- ✅ Design Patterns (Padrões de Projeto)  

---

## 🧩 Problema

Um sistema de gestão de conteúdo precisa construir menus com:

- Itens simples (links individuais)  
- Submenus aninhados  
- Múltiplos níveis hierárquicos  

O código original tratava **MenuItem** e **MenuGroup** de maneira diferente, o que gerava:

- ✗ Código duplicado  
- ✗ Lógica recursiva espalhada  
- ✗ Cliente precisando saber se estava lidando com item ou grupo  
- ✗ Dificuldade para adicionar novas operações  

---

## 💡 Solução

Foi aplicado o **Composite Pattern**, criando uma abstração comum `MenuComponent` que representa tanto itens simples quanto grupos.

Estrutura aplicada:

- 🔹 MenuComponent (Componente base)  
- 🔹 MenuItem (Leaf)  
- 🔹 MenuGroup (Composite)  

Agora o cliente trata toda a estrutura de forma uniforme, sem precisar diferenciar itens de grupos.

---

## 🏗 Estrutura Aplicada

MenuComponent  
        ▲  
   ┌───────────┐  
MenuItem   MenuGroup  

A estrutura forma uma árvore, onde grupos podem conter outros componentes (itens ou subgrupos).

---

## 🧠 Conceito do Composite

O padrão **Composite** é um padrão estrutural que:

> Permite tratar objetos individuais e composições de objetos de forma uniforme.

Ele é ideal para representar estruturas hierárquicas em forma de árvore.

---

## 🎯 Benefícios Obtidos

- Estrutura hierárquica clara  
- Operações recursivas simplificadas  
- Código desacoplado  
- Cliente não precisa conhecer a estrutura interna  
- Facilidade para adicionar novas operações  

---

## 📚 Sobre o CarnaCode 2026

O desafio **CarnaCode 2026** consiste em implementar todos os 23 padrões de projeto (Design Patterns) em cenários reais.

Durante os desafios desta jornada, os participantes são submetidos ao aprendizado e prática na identificação de códigos não escaláveis e na solução de problemas utilizando padrões consolidados pelo mercado.

---

## 📖 eBook - Fundamentos dos Design Patterns

Minha principal fonte de conhecimento durante o desafio foi o eBook gratuito:

https://lp.balta.io/ebook-fundamentos-design-patterns

---

## 📊 Veja meu progresso no desafio

[Incluir link para o repositório central]

---

### 👨‍💻 Desenvolvido por

Leonardo Malavolti  
Desenvolvedor .NET | C# | Arquitetura de Software
