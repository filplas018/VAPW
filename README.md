# VAPW – Semestrální práce

## Definujte tridu pro simulaci procesu (jako vzor muze slouzit zdrojovy kod knihovny Sim1)
----------------------------------------------------------------------------------------

### Pozadavky:

- tridu (a dalsi prvky typu vycet hodnot a dalsi) definujte ve vlastni knihovne trid (nazvete ji podle formatu "prijmeni_nazevsimulace", napr. Novak_mycka), kterou nasledne pouzijete v projektu simulace 
- vlastni vlakno simulace procesu - vyuziti tridy Thread
- vlastni typ udalosti pri zmene stavu (delegat + udalost)
- verejne vlastnosti tridy prezentujici stav procesu


## Vizualizace procesu
-------------------

### Pozadavky:

- pouzijte dostupne vizualni komponenty pro vizualizaci jednotlivych casti, pripadne vyuzijte kresleni pomoci objektu typu Graphics
- implementujte dva rezimy napojeni na model
  - pomoci udalosti
  - ctenim jeho vlastnosti v pravidelnem intervalu
- definujte vlastni modalni dialog pro nastaveni typu napojeni na model - po potvrzeni dialogu se vizualizace prepne do daneho rezimu


## Priklad simulace
- Mycka aut - vstupni a vystupni vrata se semaforem, myci proces
- Popis situace: Auto prijizdi k mycce, vstupni i vystupni vrata jsou zavrena, na semaforech sviti cervena. Zadani myciho programu a to, ze je auto pripraveno pred myckou, je simulovano vnejsim vstupem (metoda nastaveni prislusneho atributu). Ve chvili, kdy je auto - pred myckou se nejdrive zvednou vstupni vrata a pote se zobrazi na semaforu u vstupu zelena a vystupu zelena. Pritomnost auta v mycce je opet simulovano vnejsim vstupem (viz predchozi)
- v danou chvili se na obou semaforech rozsviti cervena a zacnou sjizdet vstupni vrata. Pote zacne myci proces.
- Po dokonceni myciho procesu se zvednou vystupni vrata a pote rozsviti zelena na vystupnim semaforu. Vnejsim vstupem se indikuje auto za myckou - zavrou se vystupni vrata.
