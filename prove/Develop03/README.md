```mermaid
---
title: Animal example
---
classDiagram
    class Scripture{
        -List~Reference~ _reference

        +Scripture(Reference reference, text)
        +hideWords(, word)
        +getText(text)

    }

    class Reference{
        -string _book
        -int _chapter
        -int _verse
        -list~Word~ words

        +getBook() : string
        +setBook(book) : void
        +getChapter() : int
        +setChapter(chapter) : void
        +getVerse() : int
        +setChapter(chapter) : void
    }

    class Word{
        -string _word
        -bool _visable

        +Word(word)
        +getWord() : string
        +setWord(word) : void
        +isVisable() : bool
        +setVisable(visable) : void
        +hideWord(text, word) : void
    }

    Scripture <|-- Reference
    Scripture <|-- Word
    Reference <|-- Word
```
