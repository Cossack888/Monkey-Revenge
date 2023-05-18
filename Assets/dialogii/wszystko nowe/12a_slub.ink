/* JD nie oddał struny Katzowi */

PASTOR:
Na miłość boską, cóż to za dziwo?! Małpa na ślubie?! Toż robi nam się tutaj prawdziwy cyrk!
* [Kontynuuj]

-> slub1
=== slub1 ===

PATSY:
Słodkki biedaku, a gdzież jest twój dom?
Chodź, nadstaw uszu, twe konie już rżą.
Pędź swoją drogą, tam, gdzie horyzont!
Gdzie niebo czyste i żonę masz tkliwą.
* [Patrzysz zdumiony na pannę młodą. Nawet twój rewolwer nie bardzo wie, jak zareagować.]

-> slub2
=== slub2 ===

PASTOR:
Musisz być zdrożony. Rozgość się, jak widzisz, mamy tu małą uroczystość. To znaczy, ekhem, mam nadzieję, że wkrótce będziemy mieli. Napotkaliśmy kilka drobnych przeszkód... Przepraszam za tę uwagę o cyrku. To było niestosowne. Ursa by nie pochwaliła.
* [Kontynuuj]

-> slub3
=== slub3 ===

LUSTERKOLT:
Prezesie, coś mi tu nie gra. Rozejrzyj się: to nie jest normalne weselicho! Gdzie pan młody? Gdzie whisky i pianista?!
* [Pokiwaj głową. Też coś ci tutaj nie pasuje.]
-> slub4
* [Parsknij lekceważąco - co ten rewolwer znów wymyśla?]
-> slub4

=== slub4 ===

PASTOR:
Och nie, moje dziecko. Wszystko jest w porządku... po prostu, jakby... Ech, no dobrze, powiem ci: mieliśmy mieć muzykę podczas uroczystości. Pianista, niestety, się rozchorował. I miał go zastąpić... Och, miał go zastąpić Stary Katz...
* [Kontynuuj]

-> slubkatz
=== slubkatz ===

Wiem, że nasz Pan nie pochwala takich metod, ale... ale Stary Katz naprawdę nie umie grać na swoim banjo. Ukradłem mu strunę i schowałem za lustrem w kopalni.
* [Podnieś znalezioną strunę i wzrusz ramionami.]
-> strunanieoddana
=== strunanieoddana ===

Na litość Boską! Powinienem był lepiej ją schować...! Jakie szczęście, że mu jej nie oddałeś, dobry z ciebie czł... szympans!
* [Kontynuuj]

-> strunanieoddana0
=== strunanieoddana0 ===

PATSY:
Muzyki nam trzeba, ale żeby była dobra!
Staremu Katzowi nie możemy struny oddać!
* [Kontynuuj]
        
-> strunanieoddana1
=== strunanieoddana1 ===

   PASTOR:
   Bądź dobrym chrześcijaninem... oddaj nam strunę i nie mówmy o tym więcej.
   * [Oddaj strunę Pastorowi.]
    (oddałeś Pastorowi strunę) Cudownie!
   -> strunapastora
   * [Roześmiej się głośno i zjedz strunę.]
    (zachowałeś strunę dla siebie)
   -> strunazjedzona
   
   === strunapastora ===
   
   Dziękuję ci, dziękuję! Pan po raz kolejny udowodnił, że wszyscy jesteśmy Jego dziećmi! Zapraszam cię na poczęstunek, dobry... szympansie.
   * Siadasz przy stole i chwytasz kubek gorącej, słodkiej kawy. Zakończ
   /* bohater dostaje powerupa +1 do uporządkowanej strony mocy */

   -> DONE
   
   === strunazjedzona ===
   
   PATSY:
   Szympans strunę pożarł, dziki jest i zły!
   Popsuć chce wesele, pewnie ma też pchły!
   Idź precz z mojego ślubu, niech cię nie oglądam!
   Nie spełnię żadnych twoich życzeń, żadnych żądań!
   * Odejdź. Zakończ
   /* nie ma powerupa */

-> DONE