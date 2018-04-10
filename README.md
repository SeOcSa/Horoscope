# Horoscope
An asp.net core 1.1 MVC application using EF and SQL server who predict the following:
-The evolution of the  grades for a student base on his name and registration number.
-If the student will have a nice or bad day based on current date and the first letter from his Name.

------------------------------------------------------------------------------------------------------------------


Prezice daca media unui student, identificat prin numarul matricol, va creste sau va scadea in viitor, pe baza urmatorului algoritm de horoscop: daca suma caracterelor din numarul matricol si din nume, modulo 2, este egala cu 1, media va creste, iar daca suma este zero, media va descreste
prezice cati dintre studentii cu medie peste 8 vor avea media scazuta in viitor (pe baza algoritmului de predictie de la punctul anterior)
prezice daca un student, identificat prin numarul matricol, va avea astazi o zi buna. Algoritmul de horoscop este: daca ziua din data curenta + prima litera a numelui modulo 2 este 1, va avea o zi buna.
