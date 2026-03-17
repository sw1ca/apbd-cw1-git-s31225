Note to exercise 5

Merge nie był typu fast-forward, ponieważ po utworzeniu gałęzi feature-max, na głównej gałęzi main pojawiły się również nowe commity.
Historia przestała być liniowa, więc Git musiał stworzyć dedykowany commit scalający (3-way merge).

1. Kiedy Git wykona fast-forward, a kiedy powstaje merge commit?
    Git wykonuje fast-forward, gdy gałąź główna nie zmieniła się od czasu utworzenia nowej gałęzi. 
    Wtedy Git przesuwa wskaźnik do przodu. Merge commit powstaje, gdy obie gałęzie rozjechały się i Git musi stworzyć nowy punkt scalający obydwie historie.
2. Czym w praktyce różni się merge od rebase?
    Merge zachowuje pełną historię rozgałęzień i tworzy dodatkowy commit scalający. Rebase przepisuje historię tak, aby wyglądała na liniową.
    Dokleja zmiany z gałęzi na sam koniec aktualnego maina. Dzięki temu graf jest czystszy.
3. W jaki sposób został rozwiązany konflikt w Twoim repozytorium?
    Konflikt wystąpił w pliku Program.cs, ponieważ na obu gałęziach zmieniłem tę samą linię z komunikatem. 
    Rozwiązałem go ręcznie, usuwając znaczniki <<<<, ====, >>>> i łącząc oba komunikaty w jeden spójny kod.